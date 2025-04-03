using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository.IRepository;
using DataAccess.Utility;
using DataModels;
using QuanLyPhongHoc.CustomNotification;
using QuanLyPhongHoc.UserAccount.IUserAccount;

namespace QuanLyPhongHoc.MaintainRequestManagement
{
    public partial class frmRequestAddOrUpdate : Form
    {
        private readonly IUnitOfWork unit;
        private readonly ICurrentAccount currentAccount;
        private MaintainRequest? OldRequest;
        // Constructor cho Form Add
        public frmRequestAddOrUpdate(IUnitOfWork _unit, ICurrentAccount _currentAccount)
        {
            unit = _unit;
            currentAccount = _currentAccount;
            InitializeComponent();
            LoadIssueStatus();
            LoadIssueType();

        }
        // Constructor cho Form Update
        public frmRequestAddOrUpdate(IUnitOfWork _unit, ICurrentAccount _currentAccount, int _ID)
        {
            unit = _unit;
            currentAccount = _currentAccount;
            OldRequest = unit.RequestManagement.Get(rq => rq.ID == _ID);
            InitializeComponent();
            GetOldRequest();
        }

        #region Load Events
        private void GetOldRequest()
        {
            label_TitlePanel.Text = "CẬP NHẬP YÊU CẦU";
            button_CreateNewRequest.Text = "CẬP NHẬP";
            textBox_Description.Text = OldRequest.Description;
            textBox_ClassroomID.Text = OldRequest.ClassroomID.ToString();
            LoadIssueStatus();
            LoadIssueType();
        }
        
        private void LoadIssueType()
        {
            var enumList = Enum.GetValues(typeof(IssueType))
                .Cast<IssueType>()
                .Select(e => new { Key = e, Value = EnumHelper.GetEnumDescription(e) })
                .ToList();

            comboBox_IssueType.DataSource = enumList;
            comboBox_IssueType.DisplayMember = "Value";
            comboBox_IssueType.ValueMember = "Key";
            comboBox_IssueType.DropDownStyle = ComboBoxStyle.DropDownList;

            if (OldRequest != null)
            {
                comboBox_IssueType.SelectedValue = OldRequest.IssueType;
            }
        }

        private void LoadIssueStatus()
        {
            var enumList = Enum.GetValues(typeof(IssueStatus))
                .Cast<IssueStatus>()
                .Select(e => new { Key = e, Value = EnumHelper.GetEnumDescription(e) })
                .ToList();
            comboBox_IssueStatus.DataSource = enumList;
            comboBox_IssueStatus.DisplayMember = "Value";
            comboBox_IssueStatus.ValueMember = "Key";
            comboBox_IssueStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            if (OldRequest != null)
            {
                comboBox_IssueStatus.SelectedValue = OldRequest.IssueStatus;
            }
        } 
        #endregion
        private void button_BackToList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_CreateOrUpdateRequest_Click(object sender, EventArgs e)
        {
            string newRequestString = "";

            if(OldRequest == null)
            {
                OldRequest = new MaintainRequest();
            }


            OldRequest.UserID = currentAccount.CurrentUser.ID;
            OldRequest.ClassroomID = Convert.ToInt32(textBox_ClassroomID.Text);
            OldRequest.IssueStatus = (IssueStatus)comboBox_IssueStatus.SelectedValue;
            OldRequest.IssueType = (IssueType)comboBox_IssueType.SelectedValue;
            OldRequest.Description = textBox_Description.Text;

            MaintainValidCheck IsValidData = new MaintainValidCheck(unit);
            string dataInvalid;
            string errorMessage;

            if(IsValidData.IsValid(OldRequest, out dataInvalid, out errorMessage))
            {
                frmCustomNotification notification;

                // Kiểm tra liệu đang cập nhập hay là Add
                // Nếu request mới được tạo bằng từ khóa new tức là ID sẽ bằng 0
                // ID sẽ được cập nhập lại khi thực hiện unit.Save();
                if (OldRequest.ID > 0)  
                {
                    newRequestString += $"{OldRequest.ID},";
                    newRequestString += $"{currentAccount.CurrentUser.Name.ToString()},";
                    newRequestString += $"{EnumHelper.GetEnumDescription((IssueType)comboBox_IssueType.SelectedValue).ToString()},";
                    newRequestString += EnumHelper.GetEnumDescription((IssueStatus)comboBox_IssueStatus.SelectedValue).ToString();

                    unit.RequestManagement.Update(OldRequest);
                    unit.Save();
                    notification = new frmCustomNotification("Đã cập nhập thành công", "success");
                    notification.Show();


                    ((frmRequestControl)this.Owner).UpdateRequest(newRequestString);
                    this.Close();
                    return;
                }
                
                // Lưu chuỗi string để sau khi form này đóng thì sẽ được thêm vào DataGridView
                notification = new frmCustomNotification("Đã tạo yêu cầu thành công", "success");
                unit.RequestManagement.Add(OldRequest);
                unit.Save();

                newRequestString += $"{OldRequest.ID},";
                newRequestString += $"{currentAccount.CurrentUser.Name.ToString()},";
                newRequestString += $"{EnumHelper.GetEnumDescription((IssueType)comboBox_IssueType.SelectedValue).ToString()},";
                newRequestString += EnumHelper.GetEnumDescription((IssueStatus)comboBox_IssueStatus.SelectedValue).ToString();

                notification.Show();
                ((frmRequestControl)this.Owner).AddRequest(newRequestString);
                this.Close();
            }
            else
            {
                switch (dataInvalid)
                {
                    case "classroomid":
                        lbValidClassroomID.Text = errorMessage;
                        break;

                    case "description":
                        lbValidDescription.Text = errorMessage;
                        break;
                }

            }

        }


    }
}
