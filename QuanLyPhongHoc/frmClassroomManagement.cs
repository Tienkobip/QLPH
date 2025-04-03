using DataAccess.Repository.IRepository;
using DataAccess.Utility;
using DataModels;
using QuanLyPhongHoc.CustomNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongHoc
{
    public partial class frmClassroomManagement : Form
    {
        private int rowIndex;
        private readonly IUnitOfWork _unitOfWork;
        private bool modeNew;
        private int ID;
        private Classroom? classroom;
        public frmClassroomManagement(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }

        #region Load Events
        private void SetUpDataGridViewHeader()
        {
            ClassroomData = new DataTable();

            ClassroomData.Columns.Add("ID", typeof(string));
            ClassroomData.Columns.Add("Name", typeof(string));
            ClassroomData.Columns.Add("ClassroomType", typeof(string));
            ClassroomData.Columns.Add("ClassroomStatus", typeof(string));
            ClassroomData.Columns.Add("Capacity", typeof(string));
            ClassroomData.Columns.Add("Location", typeof(string));
        }

        private void LoadDataGridView()
        {
            SetUpDataGridViewHeader();

            var classroomInfo = _unitOfWork.Classroom.GetInfoList();
            foreach (string classroom in classroomInfo)
            {
                ClassroomData.Rows.Add(classroom.Split(','));
            }

            dataGridView_ClassroomList.DataSource = ClassroomData;
            dataGridView_ClassroomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadLocation()
        {
            List<string> listItem = new List<string>() { "A1", "A2", "B1", "B2", "C1", "C2", "C3", "C4", "D1", "D2", "I1", "I2", "I3", "I4", "E1", "E2", "E3", "F1", "F2" };
            cbLocation.DataSource = listItem;
            cbLocation.DropDownHeight = 100;
            cbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadClassroomType()
        {
            var enumList = Enum.GetValues(typeof(ClassroomType))
                .Cast<ClassroomType>()
                .Select(e => new { Key = e, Value = EnumHelper.GetEnumDescription(e) })
                .ToList();

            cbType.DataSource = enumList;
            cbType.DisplayMember = "Value";
            cbType.ValueMember = "Key";
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadClassroomStatus()
        {
            var enumList = Enum.GetValues(typeof(ClassroomStatus))
                .Cast<ClassroomStatus>()
                .Select(e => new { Key = e, Value = EnumHelper.GetEnumDescription(e) })
                .ToList();
            cbStatus.DataSource = enumList;
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmClassroomManagement_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadClassroomType();
            LoadClassroomStatus();
            LoadLocation();
            SetControls(false);
        }

        #endregion

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView_ClassroomList.SelectedRows.Count > 0)
            {
                rowIndex = dataGridView_ClassroomList.SelectedRows[0].Index;
                txtId.Text = dataGridView_ClassroomList.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView_ClassroomList.SelectedRows[0].Cells[1].Value.ToString();
                cbType.Text = dataGridView_ClassroomList.SelectedRows[0].Cells[2].Value.ToString();
                cbStatus.Text = dataGridView_ClassroomList.SelectedRows[0].Cells[3].Value.ToString();
                txtCapacity.Text = dataGridView_ClassroomList.SelectedRows[0].Cells[4].Value.ToString();
                cbLocation.Text = dataGridView_ClassroomList.SelectedRows[0].Cells[5].Value.ToString();
                ID = Convert.ToInt32(txtId.Text);
            }
        }

        private void SetControls(bool edit)
        {
            txtId.Enabled = false;
            txtName.Enabled = edit;
            cbType.Enabled = edit;
            cbStatus.Enabled = edit;
            txtCapacity.Enabled = edit;
            cbLocation.Enabled = edit;
            btnNew.Enabled = !edit;
            btnEdit.Enabled = !edit;
            btnDelete.Enabled = !edit;
            btnSave.Enabled = edit;
            btnCancel.Enabled = edit;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControls(true);
            txtName.Focus();
            txtName.Clear();
            cbType.Text = "";
            cbStatus.Text = "";
            txtCapacity.Clear();
            cbLocation.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeNew = false;
            SetControls(true);
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView_ClassroomList.SelectedRows.Count > 0)
            {
                dataGridView_ClassroomList.Rows.RemoveAt(rowIndex);
                classroom = _unitOfWork.Classroom.Get(u => u.ID == ID);
                _unitOfWork.Classroom.Remove(classroom);
                _unitOfWork.Save();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newClass = "";
            if(classroom == null)
            {
                classroom = new Classroom();
            }
            if (modeNew)
            {

                classroom.Name = txtName.Text;
                classroom.Type = (ClassroomType)cbType.SelectedValue;
                classroom.Status = (ClassroomStatus)cbStatus.SelectedValue;
                classroom.Capacity = Convert.ToInt32(txtCapacity.Text);
                classroom.Location = (string)cbLocation.SelectedValue;
                frmCustomNotification notification = new frmCustomNotification("Đã thêm lớp mới thành công!!", "success");
                _unitOfWork.Classroom.Add(classroom);
                _unitOfWork.Save();

                newClass += $"{classroom.ID},";
                newClass += $"{classroom.Name},";
                newClass += $"{EnumHelper.GetEnumDescription(classroom.Type)},";
                newClass += $"{EnumHelper.GetEnumDescription(classroom.Status)},";
                newClass += $"{classroom.Capacity},";
                newClass += $"{classroom.Location}";
                AddClass(newClass);

                notification.Show();
            }
            else
            {
                if (dataGridView_ClassroomList.SelectedRows.Count == 0)
                {
                    return;
                }

                classroom.Name = txtName.Text;
                classroom.Type = (ClassroomType)cbType.SelectedValue;
                classroom.Status = (ClassroomStatus)cbStatus.SelectedValue;
                classroom.Capacity = Convert.ToInt32(txtCapacity.Text);
                classroom.Location = (string)cbLocation.SelectedValue;

                frmCustomNotification notification = new frmCustomNotification("Đã cập nhập dữ liệu thành công!!", "success");
                _unitOfWork.Classroom.Update(classroom);
                _unitOfWork.Save();

                newClass += $"{classroom.Name},";
                newClass += $"{EnumHelper.GetEnumDescription(classroom.Type)},";
                newClass += $"{EnumHelper.GetEnumDescription(classroom.Status)},";
                newClass += $"{classroom.Capacity},";
                newClass += $"{classroom.Location}";

                UpdateClass(newClass);

                notification.Show();
            }

            classroom = null;
            SetControls(false);
        }

        //Thêm class mới vào DataGridView khi đã thành công thêm dữ liệu vào database
        private void AddClass(string newClass)
        {
            ClassroomData.Rows.Add(newClass.Split(','));
        }

        private void UpdateClass(string updatedClass)
        {

            int i = 1;
            string[] updatedData = updatedClass.Split(',');
            foreach(string data in updatedData)
            {
                dataGridView_ClassroomList.Rows[rowIndex].Cells[i].Value = data;
                i++;
            }
        }
        private DataTable ClassroomData;
    }
}
