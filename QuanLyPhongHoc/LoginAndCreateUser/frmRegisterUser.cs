using DataAccess.Repository.IRepository;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;

namespace QuanLyPhongHoc.LoginAndCreateUser
{
    public partial class frmRegisterUser : Form
    {
        private readonly IUnitOfWork unit;
        public frmRegisterUser(IUnitOfWork _unit)
        {
            unit = _unit;
            InitializeComponent();
        }

        private void label_SignIn_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = Application.OpenForms["frmLogin"] as frmLogin;

            if (frmLogin != null)
            {
                frmLogin.Show();
                this.Close();
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            DataModels.User newUser = new DataModels.User();

            newUser.Name = textBox_Name.Text;
            newUser.Password = textBox_Password.Text;
            newUser.Email = textBox_Email.Text;
            newUser.Phone = textBox_Phone.Text;

            string? errorMessage;
            string? dataInvalid;

            if (CheckValidUser(newUser, out dataInvalid, out errorMessage))
            {
                unit.User.Add(newUser);
                unit.Save();
                MessageBox.Show("Bạn đã tạo tài khoản thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
            }
            else
            {
                switch (dataInvalid)
                {
                    case "name":
                        lbInvalidName.Text = errorMessage;
                        break;

                    case "pass":
                        lbInvalidPassword.Text = errorMessage;
                        break;

                    case "email":
                        lbInvalidEmail.Text = errorMessage;
                        break;

                    case "phone":
                        lbInvalidPhone.Text = errorMessage;
                        break;

                    case "same name":
                        lbInvalidName.Text = errorMessage;
                        break;
                }
            }
        }

        private bool CheckValidUser(DataModels.User newUser, out string? dataInvalid, out string? errorMessage)
        {
            if (string.IsNullOrEmpty(newUser.Name))
            {
                dataInvalid = "name";
                errorMessage = "Tên không được phép rỗng!";
                return false;
            }
            else if (string.IsNullOrEmpty(newUser.Password))
            {
                dataInvalid = "pass";
                errorMessage = "Mật khẩu không được phép rỗng!";
                return false;
            }
            else if (string.IsNullOrEmpty(newUser.Email))
            {
                dataInvalid = "email";
                errorMessage = "Email không được phép rỗng!";
                return false;
            }
            else if (string.IsNullOrEmpty(newUser.Phone))
            {
                dataInvalid = "phone";
                errorMessage = "Số điện thoại không được phép rỗng!";
                return false;
            }

            // Kiểm tra trùng tên đăng nhập
            DataModels.User validUser = unit.User.Get(user => user.Name == newUser.Name);

            if (validUser == null)
            {
                dataInvalid = null;
                errorMessage = null;
                return true;
            }

            dataInvalid = "same name";
            errorMessage = "Tên đăng nhập đã tồn tại!";
            return false;
        }

    }
}
