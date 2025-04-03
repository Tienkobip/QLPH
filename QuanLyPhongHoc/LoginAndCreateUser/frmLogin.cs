using DataAccess.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;
using QuanLyPhongHoc.LoginAndCreateUser;
using QuanLyPhongHoc.MaintainRequestManagement;
using QuanLyPhongHoc.UserAccount.IUserAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongHoc
{
    public partial class frmLogin : Form
    {
        private readonly IUnitOfWork unit;
        private readonly IServiceProvider serviceProvider;
        private readonly IAccountAuth accountAuth;
        private readonly ICurrentAccount currentAccount;
        public frmLogin(IServiceProvider _serviceProvider, IUnitOfWork _unit, IAccountAuth _accountAuth, ICurrentAccount _currentAccount)
        {
            unit = _unit;
            serviceProvider = _serviceProvider;
            accountAuth = _accountAuth;
            currentAccount = _currentAccount;
            InitializeComponent();
        }
        private void pictureBox_Password_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_Username;

            if (Properties.Settings.Default.RememberMe && Properties.Settings.Default.SavedUserID > 0)
            {
                var user = unit.User.Get(u => u.ID == Properties.Settings.Default.SavedUserID);

                if(user != null)
                {
                    currentAccount.CurrentUser = user;

                    this.Hide();
                    frmMenu = serviceProvider.GetService<frmMenu>();
                    frmMenu.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (accountAuth.Login(textBox_Username.Text, textBox_Password.Text))
            {
                // Lưu tài khoản vào setting để lần sau khi mở lại thì người dùng
                // ko cần đăng nhập 
                Properties.Settings.Default.RememberMe = checkBox_RememberMe.Checked;
                Properties.Settings.Default.SavedUserID = currentAccount.CurrentUser.ID;
                Properties.Settings.Default.Save();

                this.Hide();
                frmMenu = serviceProvider.GetRequiredService<frmMenu>();
                frmMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Password.Clear();
                textBox_Username.Focus();
            }
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Forms
        private void label_Register_Click(object sender, EventArgs e)
        {
            if (frmRegisterUser == null)
            {
                frmRegisterUser = serviceProvider.GetRequiredService<frmRegisterUser>();
                frmRegisterUser.FormClosed += frmRegisterUser_FormClosed;
                this.Hide();
                frmRegisterUser.Show();
            }
            else
            {
                frmRegisterUser.Activate();
            }
        }
        private void frmRegisterUser_FormClosed(object sender, EventArgs e)
        {
            frmRegisterUser = null;
        }
        #endregion
        private frmRegisterUser frmRegisterUser;


        private bool isPasswordShow = true;
        private void button_ShowAndHidePass_Click(object sender, EventArgs e)
        {
            if (isPasswordShow == true)
            {
                button_ShowAndHidePass.BackgroundImage = global::QuanLyPhongHoc.Properties.Resources.HidePasswordIcon;
                isPasswordShow = false;

                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                button_ShowAndHidePass.BackgroundImage = global::QuanLyPhongHoc.Properties.Resources.ShowPasswordIcon;
                isPasswordShow = true;

                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }


        private frmMenu frmMenu;
    }
}
