using Microsoft.Extensions.DependencyInjection;
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

namespace QuanLyPhongHoc.frmPopUpAvatar
{
    public partial class frmPopUpAvatar: Form
    {
        private readonly IServiceProvider serviceProvider;
        public frmPopUpAvatar(Image avatar, IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.White;
            this.Size = new Size(200, 250);
            this.Location = new Point(Cursor.Position.X - this.Width / 2, Cursor.Position.Y + 25);

            picAvatar = new PictureBox()
            {
                Image = avatar,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(100, 100),
                Location = new Point(50, 10),
                Cursor = Cursors.Hand
            };

            btnAccountSettings = new Button()
            {
                Text = "Account Settings",
                Location = new Point(40, 130),
                Size = new Size(120, 30),
                BackColor = Color.LightGray
            };
            btnAccountSettings.Click += (s, e) => MessageBox.Show("Chuyển đến Account Settings!");

            // Tạo nút "Logout"
            btnLogout = new Button()
            {
                Text = "Logout",
                Location = new Point(40, 170),
                Size = new Size(120, 30),
                BackColor = Color.LightGray
            };
            btnLogout.Click += Logout_Click;

            this.Controls.Add(picAvatar);
            this.Controls.Add(btnAccountSettings);
            this.Controls.Add(btnLogout);

            this.Deactivate += DeactiveHandler;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.SavedUserID = 0;
                Properties.Settings.Default.Save();

                Application.Restart();
            }
        }

        private void DeactiveHandler(object sender, EventArgs e)
        {
            if(picAvatar.Focused || btnAccountSettings.Focused || btnLogout.Focused)
            {
                return;
            }            
            // Tự động close nếu cursor click ra ngoài
            this.Close();
        }

        private frmLogin? frmLogin;
        private PictureBox? picAvatar;
        private Button? btnAccountSettings;
        private Button? btnLogout;
    }
}

