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
using QuanLyPhongHoc.CustomControls;

namespace QuanLyPhongHoc.CustomNotification
{
    public partial class frmCustomNotification : Form
    {
        private TransparentPanel pnlNotificationContainer;
        private PictureBox logo;
        private Timer showUptimer;
        private Timer fadeOutTimer;
        private Label txbMessage;
        public frmCustomNotification(string message, string type)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.ForeColor = Color.White;
            this.Size = new Size(320, 70);
            this.TopMost = true;
            
            Size formSize = this.Size; 
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - formSize.Width - 10, 10);

            logo = new PictureBox()
            {
                Size = new Size(65, 0),
                SizeMode = PictureBoxSizeMode.Normal,
                Dock = DockStyle.Left
            };

            txbMessage = new Label()
            {
                AutoSize = false,
                Text = message,
                MinimumSize = new Size(this.Width - logo.Width, this.Height - 30),
                Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleLeft
            };

            switch (type)
            {
                case "success":
                    this.BackColor = Color.FromArgb(115, 181, 115);
                    logo.Image = global::QuanLyPhongHoc.Properties.Resources.SuccessIcon;
                    break;

                case "error":
                    this.BackColor = Color.FromArgb(202, 94, 88);
                    logo.Image = global::QuanLyPhongHoc.Properties.Resources.ErrorIcon;
                    break;

                case "warning":
                    this.BackColor = Color.FromArgb(249, 168, 32);
                    logo.Image = global::QuanLyPhongHoc.Properties.Resources.WarningIcon;
                    break;
            }

            this.Controls.Add(txbMessage);
            this.Controls.Add(logo);

            showUptimer = new Timer();
            showUptimer.Interval = 3000;
            showUptimer.Tick += (s, e) => { LoadFadeOutTimer(); };
            showUptimer.Start();
        }

        private void LoadFadeOutTimer()
        {
            fadeOutTimer = new Timer();
            fadeOutTimer.Interval = 30;
            fadeOutTimer.Tick += FadeOut_Tick;
            fadeOutTimer.Start();
        }

        private void FadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;

            if(this.Opacity <= 0.05)
            {
                fadeOutTimer.Stop();
                this.Close();
            }
        }
    }
}
