using DataAccess.Repository.IRepository;
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
                RequestTable.Rows.Add(request.Split(','));
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

        //new KeyValuePair<int, string>(0, "--Tìm theo--"), 
        //        new KeyValuePair<int, string>(1, "ID"),
        //        new KeyValuePair<int, string>(2, "Tên người tạo"),
        //        new KeyValuePair<int, string>(3, "Loại vấn đề"),
        //        new KeyValuePair<int, string>(4, "Trạng thái")
        private void SearchRequest()
        {
            int searchChoice = (int)cbSearchBy.SelectedValue;
            string searchInput = textBox_SearchBox.Text;

            switch (searchChoice)
            {
                case 1:
                    {
                        if (!IsSearchValid(searchChoice, searchInput))
                        {
                            return;
                        }


                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }

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

        private bool IsSearchValid(int choice, string input)
        {
            frmNotification notification;
            bool isValid = false;
            switch(choice)
            {
                case 1:
                    {
                        if(int.TryParse(input, out _))
                        {
                            isValid = true;
                        }
                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }
            }

            return isValid;
        }
        private frmRequestAddOrUpdate? frmRequestAddOrUpdate;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
