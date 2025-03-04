using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Utility;
using DataModels;

namespace QuanLyPhongHoc.MaintainRequestManagement
{
    public partial class frmMaintainRequestAdd : Form
    {
        public frmMaintainRequestAdd()
        {
            InitializeComponent();
            LoadIssueStatus();
            LoadIssueType();
        }

        #region Load Events
        private void LoadIssueType()
        {
            var enumList = Enum.GetValues(typeof(IssueType))
                .Cast<IssueType>()
                .Select(e => new {Key = e, Value = EnumHelper.GetEnumDescription(e)})
                .ToList();

            comboBox_IssueType.DataSource = enumList;
            comboBox_IssueType.DisplayMember = "Value";
            comboBox_IssueType.ValueMember = "Key";
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
        }
        #endregion
        private void button_BackToList_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
