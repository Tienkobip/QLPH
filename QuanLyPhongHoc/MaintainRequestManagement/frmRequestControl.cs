using DataAccess.Repository.IRepository;
using DataAccess.Utility;
using DataModels;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.DependencyInjection;
using QuanLyPhongHoc.CustomNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyPhongHoc.MaintainRequestManagement
{
    public partial class frmRequestControl : Form
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IUnitOfWork unit;
        public frmRequestControl(IUnitOfWork _unit, IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
            unit = _unit;
            InitializeComponent();
        }

        #region Load Events
        private void LoadForm(object sender, EventArgs args)
        {
            LoadCbSearchBy();


            // Thêm các cột cho DataTable
            SetupRequestTableColumn();

            // Thêm dữ liệu vào DataTable
            var requestList = unit.RequestManagement.GetRequestsList();
            foreach (string request in requestList)
            {
                AddRequest(request);
            }
            ConfigureDataGridView();
        }

        private void LoadCbSearchBy()
        {
            var danhSachLuaChon = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(0, "--Tìm theo--"),
                new KeyValuePair < int, string >(1, "ID"),
                new KeyValuePair < int, string >(2, "Tên người tạo"),
                new KeyValuePair < int, string >(3, "Loại vấn đề"),
                new KeyValuePair < int, string >(4, "Trạng thái")
            };

            cbSearchBy.DataSource = danhSachLuaChon;
            cbSearchBy.DisplayMember = "Value";
            cbSearchBy.ValueMember = "Key";
            cbSearchBy.SelectedIndex = 0;
            cbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchBy.SelectedValueChanged += CbSearchBy_SelectedValueChanged;
        }

        private void LoadIssueType()
        {
            var enumList = Enum.GetValues(typeof(IssueType))
                .Cast<IssueType>()
                .Select(e => new { Value = e, Display = EnumHelper.GetEnumDescription(e) })
                .ToList();

            cbSearchInput.DataSource = enumList;
            cbSearchInput.DisplayMember = "Display";
            cbSearchInput.ValueMember = "Value";
            cbSearchInput.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadIssueStatus()
        {
            var enumList = Enum.GetValues(typeof(IssueStatus))
                .Cast<IssueStatus>()
                .Select(e => new { Value = e, Display = EnumHelper.GetEnumDescription(e) })
                .ToList();
            cbSearchInput.DataSource = enumList;
            cbSearchInput.DisplayMember = "Display";
            cbSearchInput.ValueMember = "Value";
            cbSearchInput.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion


        #region Form
        private void button_CreateRequest_Click(object sender, EventArgs e)
        {
            if (frmRequestAddOrUpdate == null)
            {
                frmRequestAddOrUpdate = serviceProvider.GetRequiredService<frmRequestAddOrUpdate>();
                frmRequestAddOrUpdate.FormClosed += frmMaintainRequestAdd_FormClosed;
                frmRequestAddOrUpdate.Owner = this;
                frmRequestAddOrUpdate.ShowDialog();
            }
            else
            {
                frmRequestAddOrUpdate.Activate();
            }
        }

        private void frmMaintainRequestAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmRequestAddOrUpdate = null;
        }
        #endregion



        // Thêm request sau khi frmRequestAddOrUpdate đóng
        public void AddRequest(string request)
        {
            RequestTable.Rows.Add(request.Split(','));
        }

        public void UpdateRequest(string request)
        {
            string[] newData = request.Split(',');
            int cellsIndex = 2;
            int rowIndex = dataGridView_Request.CurrentCell.RowIndex;
            foreach (string data in newData)
            {
                dataGridView_Request.Rows[rowIndex].Cells[cellsIndex].Value = data;
                cellsIndex++;
            }
        }

        private void ResetDataGridView()
        {
            dataGridView_Request.Columns.Remove(editColumn);
            dataGridView_Request.Columns.Remove(deleteColumn);

            dataGridView_Request.DataSource = null;
            dataGridView_Request.Rows.Clear();
            dataGridView_Request.Columns.Clear();
            dataGridView_Request.Refresh();
            RequestTable.Rows.Clear();

            dataGridView_Request.DataSource = RequestTable;
            dataGridView_Request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_Request.Columns.Add(deleteColumn);
            dataGridView_Request.Columns.Add(editColumn);

            dataGridView_Request.Columns["Edit"].Visible = false;
            dataGridView_Request.Columns["Delete"].Visible = false;
        }

        IssueType? cbSearchInputIssueType;
        IssueStatus? cbSearchInputIssueStatus;  
        private void SearchRequest()
        {
            int searchChoice = (int)cbSearchBy.SelectedValue;

            switch (searchChoice)
            {
                case 1:
                    {
                        string searchInput = textBox_SearchBox.Text;
                        if (!IsIDSearchValid(searchChoice, searchInput))
                        {
                            return;
                        }
                        int ID = Convert.ToInt32(searchInput);
                        var filteredList = unit.RequestManagement.GetRequestsList(rq => rq.ID == ID);
                        foreach(string request in filteredList)
                        {
                            AddRequest(request);
                        }
                        break;
                    }
                case 3:
                    {
                        ResetDataGridView();
                        var filteredList = unit.RequestManagement.GetRequestsList(rq => rq.IssueType == cbSearchInputIssueType);
                        foreach (string request in filteredList)
                        {
                            AddRequest(request);
                        }
                        
                        break;
                    }
                case 4:
                    {
                        ResetDataGridView();
                        var filteredList = unit.RequestManagement.GetRequestsList(rq => rq.IssueStatus == cbSearchInputIssueStatus);
                        foreach (string request in filteredList)
                        {
                            AddRequest(request);
                        }
                        break;
                    }
            }
        }

        private bool IsIDSearchValid(int choice, string input)
        {
            frmCustomNotification notification;
            bool isValid = true;
            if(!int.TryParse(input, out int searchID))
            {
                isValid = false;
                notification = new frmCustomNotification("ID không hợp lệ. Vui lòng nhập lại", "warning");
                notification.Show();
                textBox_SearchBox.Focus();
            }
            else if (unit.RequestManagement.Get(rq => rq.ID == searchID) == null)
            {
                isValid = false;
                notification = new frmCustomNotification("ID không tồn tại. Vui lòng nhập lại", "warning");
                notification.Show();
                textBox_SearchBox.Focus();
            }

            return isValid;
        }

        private void textBox_SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Làm sạch danh sách
                ResetDataGridView();

                // Lấy danh sách của các phần tử cần tìm
                SearchRequest();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox_SearchBox_TextChanged(object sender, EventArgs e)
        {
            ResetDataGridView();
            string keyword = textBox_SearchBox.Text.Trim().ToLower();
            var filteredList = unit.RequestManagement.GetRequestsList(rq => rq.User.Name.ToLower().Contains(keyword));
            foreach (string request in filteredList)
            {
                AddRequest(request);
            }
        }
        private void IssueType_SelectedValueChanged(object sender, EventArgs e)
        {
            cbSearchInputIssueType = cbSearchInput.SelectedValue as IssueType?;
            SearchRequest();
        }
        private void IssueStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            cbSearchInputIssueStatus = cbSearchInput.SelectedValue as IssueStatus?;
            SearchRequest();
        }
        private void CbSearchBy_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_SearchBox.Visible = true;
            cbSearchInput.Visible = false;

            if((int)cbSearchBy.SelectedValue == 0)
            {
                ResetDataGridView();
                var list = unit.RequestManagement.GetRequestsList();
                foreach (string request in list)
                {
                    AddRequest(request);
                }
            }
            else if ((int)cbSearchBy.SelectedValue == 1)
            {
                textBox_SearchBox.KeyDown += textBox_SearchBox_KeyDown;
                textBox_SearchBox.TextChanged -= TextBox_SearchBox_TextChanged;
            }
            else if ((int)cbSearchBy.SelectedValue == 2)
            {
                textBox_SearchBox.KeyDown -= textBox_SearchBox_KeyDown;
                textBox_SearchBox.TextChanged += TextBox_SearchBox_TextChanged;
            }
            else if ((int)cbSearchBy.SelectedValue == 3)
            {
                textBox_SearchBox.Visible = false;
                cbSearchInput.Visible = true;
                cbSearchInput.SelectedValueChanged += IssueType_SelectedValueChanged;
                cbSearchInput.SelectedValueChanged -= IssueStatus_SelectedValueChanged;
                LoadIssueType();
                SearchRequest();
            }
            else if ((int)cbSearchBy.SelectedValue == 4)
            {
                textBox_SearchBox.Visible = false;
                cbSearchInput.Visible = true;
                cbSearchInput.SelectedValueChanged -= IssueType_SelectedValueChanged;
                cbSearchInput.SelectedValueChanged += IssueStatus_SelectedValueChanged;
                LoadIssueStatus();
                SearchRequest();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_SearchBox.Visible = !textBox_SearchBox.Visible;
        }

        private frmRequestAddOrUpdate? frmRequestAddOrUpdate;
        private ComboBox? cbSearchInput;
    }

}
