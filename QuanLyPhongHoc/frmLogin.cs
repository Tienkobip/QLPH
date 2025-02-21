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
        private void LoadImg()
        {
            pictureBox_UserIconLogin.Image = new Bitmap(Application.StartupPath + "\\img\\UserIconLogin.png");
            pictureBox_UserIcon.Image = new Bitmap(Application.StartupPath + "\\img\\UserIcon.png");
            pictureBox_Password.Image = new Bitmap(Application.StartupPath + "\\img\\Password.png");
        }

        public frmLogin()
        {
            InitializeComponent();
            LoadImg();
        }

        private void pictureBox_Password_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_Username;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text.Trim().ToString();
            string password = textBox_Password.Text.Trim().ToString();

            if (username == "admin" && password == "admin")
            {
                this.Hide();
                //frmMenu frmMenu = new frmMenu();
                //frmMenu.Show();
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
    }
}
