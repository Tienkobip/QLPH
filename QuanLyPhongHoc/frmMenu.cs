using DataAccess.Data;
using Microsoft.Extensions.DependencyInjection;
using QuanLyPhongHoc.MaintainRequestManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongHoc.CustomControls;
using QuanLyPhongHoc.CustomNotification;
using QuanLyPhongHoc.UserAccount.IUserAccount;
using DataAccess.Repository.IRepository;
using QuanLyPhongHoc.frmPopUpAvatar.IAvatarPopUpFactory;

namespace QuanLyPhongHoc
{
    public partial class frmMenu : ResizeableForm
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ICurrentAccount currentAccount;
        private readonly IAvatarPopUpFactory PopUpAvatar;
        private frmNotification? frmNotification;
        private frmClassroomManagement? frmClassroom;
        private frmAddRemoveClass? frmAddRemoveClass;
        private frmRequestControl? frmMaintain;
        private frmPopUpAvatar.frmPopUpAvatar? frmPopUpAvatar;
        public frmMenu(IServiceProvider _serviceProvider, ICurrentAccount _currentAccount, IAvatarPopUpFactory _PopUpFactory)
        {
            // Nhận IServiceProvider thông qua DI để trả về các form đã đăng ký thay vì tạo các instance mới
            serviceProvider = _serviceProvider;
            currentAccount = _currentAccount;
            PopUpAvatar = _PopUpFactory;
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Đảm bảo khi form maximize không che taskbar
            GifTimerLoad();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pictureBox_MenuIcon.Image = global::QuanLyPhongHoc.Properties.Resources.MenuIconDefault;
        }

        // MOVE FORM
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // DRAG FORM
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private class FileImgPath : EventArgs
        {
            public string imgPath { set; get; }
            public FileImgPath(string imgPath)
            {
                this.imgPath = imgPath;
            }
        }

        #region Transition
        // SIDEBAR TRANSITION
        private bool isSlidebarExpand = false;
        private void SlidebarTransition_Tick(object sender, EventArgs e)
        {
            if (isSlidebarExpand == false)
            {
                Slidebar.Width += 10;
                if (Slidebar.Width >= Slidebar.MaximumSize.Width)
                {
                    SlidebarTransition.Stop();
                    isSlidebarExpand = true;
                }
            }
            else
            {
                Slidebar.Width -= 10;
                if (Slidebar.Width <= Slidebar.MinimumSize.Width)
                {
                    SlidebarTransition.Stop();
                    isSlidebarExpand = false;
                }
            }
        }
        #endregion



        #region Các Event Click của các controls trên viền cửa sổ

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion



        #region Form
        // FORM CLASSLIST
        private void button_Class_Click(object sender, EventArgs e)
        {
            if (frmClassroom == null)
            {
                frmClassroom = serviceProvider.GetRequiredService<frmClassroomManagement>();
                frmClassroom.FormClosed += frmClassroom_FormClosed;
                frmClassroom.MdiParent = this;
                frmClassroom.Dock = DockStyle.Fill;
                frmClassroom.Show();
            }
            else
            {
                frmClassroom.Activate();
            }
        }
        private void frmClassroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmClassroom = null;
        }

        // FORM ADDREMOVECLASS
        private void panel_AddRemoveClass_Click(object sender, EventArgs e)
        {
            if (frmAddRemoveClass == null)
            {
                frmAddRemoveClass = new frmAddRemoveClass();
                frmAddRemoveClass.FormClosed += frmAddRemoveClass_FormClosed;
                frmAddRemoveClass.MdiParent = this;
                frmAddRemoveClass.Dock = DockStyle.Fill;
                frmAddRemoveClass.Show();
            }
            else
            {
                frmAddRemoveClass.Activate();
            }
        }
        private void frmAddRemoveClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAddRemoveClass = null;
        }

        // FORM NOTIFICATION
        private void panel_Notification_Click(object sender, EventArgs e)
        {
            if (frmNotification == null)
            {
                frmNotification = new frmNotification();
                frmNotification.FormClosed += frmNotification_FormClosed;
                frmNotification.MdiParent = this;
                frmNotification.Dock = DockStyle.Fill;
                frmNotification.Show();
            }
            else
            {
                frmNotification.Activate();
            }
        }
        private void frmNotification_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNotification = null;
        }

        // FORM MAINTAIN
        private void button_Maintain_Click(object sender, EventArgs e)
        {
            if (frmMaintain == null || frmMaintain.IsDisposed)
            {
                frmMaintain = serviceProvider.GetRequiredService<frmRequestControl>();
                frmMaintain.FormClosed += frmMaintain_FormClosed;
                frmMaintain.MdiParent = this;
                frmMaintain.Dock = DockStyle.Fill;
                frmMaintain.Show();
            }
            else
            {
                frmMaintain.Activate();
            }
        }

        private void frmMaintain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMaintain = null;
        }

        #endregion



        #region Mouse Event
        // THAY ĐỔI MÀU KHI HOVER CHUỘT
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(120, 120, 120);
        }
        private void Control_MouseEnter_Close(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(232, 17, 35);
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        // THAY ĐỔI CON TRỎ KHI HOVER CHUỘT
        private void Control_MouseEnterCursor(object sender, EventArgs e)
        {
            ((Control)sender).Cursor = Cursors.Hand;
        }
        private void Control_MouseLeaveCursor(object sender, EventArgs e)
        {
            ((Control)sender).Cursor = Cursors.Hand;
        }

        // HIỆU ỨNG FADE IN KHI TRỎ
        private void Control_MouseEnter_FadeIn(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            int alpha = 50;
            timer.Tick += (s, args) =>
            {
                if (alpha < 200)
                {
                    ((Control)sender).BackColor = Color.FromArgb(alpha, 173, 216, 230);
                    alpha += 10;
                }
                else
                {
                    timer.Stop();
                }
            };
            timer.Start();
        }
        #endregion



        #region Xử lý Menu Icon

        private void pictureBox_MenuIcon_Click(object sender, EventArgs e)
        {
            SlidebarTransition.Start();
            pictureBox_GifFile_Click();
        }

        // CHẠY CÁC FILE GIF KHI CLICK

        private Timer gifTimer = new Timer();
        private void GifTimerLoad()
        {
            gifTimer.Interval = 400;
            gifTimer.Tick += GifTimer_Tick;
        }

        private bool isPlaying = false;

        private void pictureBox_GifFile_Click()
        {
            if (isPlaying) return; // Nếu đang chạy thì bỏ qua

            isPlaying = true;
            gifTimer.Start();

            // Chuyển icon sang GIF khi bắt đầu
            pictureBox_MenuIcon.Image = isSlidebarExpand
                ? Properties.Resources.MenuIconTransitionReversed
                : Properties.Resources.MenuIconTransition;
        }

        private void GifTimer_Tick(object sender, EventArgs e)
        {
            gifTimer.Stop(); // Dừng Timer

            // Chuyển icon sau khi GIF kết thúc
            pictureBox_MenuIcon.Image = isSlidebarExpand
                ? Properties.Resources.MenuIconExpanded
                : Properties.Resources.MenuIconDefault;

            // Cho phép click tiếp tục
            isPlaying = false;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            var notification = new CustomNotification.frmCustomNotification("Đã click button", "warning");
            notification.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Xin chào {currentAccount.CurrentUser.Name}");
        }

        private void roundPictureBox_Avatar_Click(object sender, EventArgs e)
        {
            if (frmPopUpAvatar != null)
            {
                frmPopUpAvatar.Close();
                frmPopUpAvatar = null;
            }
            frmPopUpAvatar = PopUpAvatar.Create(roundPictureBox_Avatar.Image);
            frmPopUpAvatar.Show();
        }

    }
}
