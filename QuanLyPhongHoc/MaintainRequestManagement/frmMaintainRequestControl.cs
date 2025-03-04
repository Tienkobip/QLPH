using DataAccess.Repository.IRepository;
using DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyPhongHoc.MaintainRequestManagement
{
    public partial class frmMaintainRequestControl : Form
    {
        private readonly IUnitOfWork unit;
        public frmMaintainRequestControl(IUnitOfWork _unit)
        {
            unit = _unit;
            InitializeComponent();
        }

        #region Load Events
        private void LoadRequests(object sender, EventArgs args)
        {
            // Thêm các cột cho DataTable
            SetupRequestTableColumn();

            // Thêm dữ liệu vào DataTable
            var requestList = unit.RequestManagement.GetRequestsList();
            foreach (string request in requestList)
            {
                RequestTable.Rows.Add(request);
            }

            // Thêm 2 nút custom xóa và sửa
            ConfigureDataGridView();
        }
        #endregion


        #region Form
        private void button_CreateRequest_Click(object sender, EventArgs e)
        {
            if (frmMaintainRequestAdd == null)
            {
                frmMaintainRequestAdd = new frmMaintainRequestAdd();
                frmMaintainRequestAdd.FormClosed += frmMaintainRequestAdd_FormClosed;
                frmMaintainRequestAdd.Show();
            }
            else
            {
                frmMaintainRequestAdd.Activate();
            }
        }

        private void frmMaintainRequestAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMaintainRequestAdd = null;
        }
        #endregion



        private frmMaintainRequestAdd? frmMaintainRequestAdd;
    }
    
}
