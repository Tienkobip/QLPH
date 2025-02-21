using DataAccess.Data;
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

namespace QuanLyPhongHoc
{
    public partial class frmMenu : ResizableForm
    {
        private readonly ApplicationDbContext _db;
        private frmMaintain frmMaintain;
        private frmNotification frmNotification;
        private frmClassList frmClassList; 
        private frmAddRemoveClass frmAddRemoveClass;

        public frmMenu(ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _db = dbContext;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Đảm bảo khi form maximize không che taskbar
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
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
        // MENU TRANSITION
        private bool isMenuExpand = false;
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (isMenuExpand == false)
            {
                ClassContainer.Height += 10;
                if (ClassContainer.Size == ClassContainer.MaximumSize)
                {
                    MenuTransition.Stop();
                    isMenuExpand = true;
                }
            }
            else
            {
                ClassContainer.Height -= 10;
                if (ClassContainer.Size == ClassContainer.MinimumSize)
                {
                    MenuTransition.Stop();
                    isMenuExpand = false;
                }
            }
        }

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
            if (isSlidebarExpand)
            {
                MenuTransition.Start();
            }
            else
            { 
            }
        }

        private void panel_ClassList_Click(object sender, EventArgs e)
        {
            if (frmClassList == null)
            {
                frmClassList = new frmClassList();
                frmClassList.FormClosed += frmClassList_FormClosed;
                frmClassList.MdiParent = this;
                frmClassList.Dock = DockStyle.Fill;
                frmClassList.Show();
            }
            else
            {
                frmClassList.Activate();
            }
        }
        private void frmClassList_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmClassList = null;
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
                frmMaintain = new frmMaintain();
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
            //FileImgPath imgPath = new FileImgPath(((PictureBox)sender).ImageLocation);
            //pictureBox_GifFile_Click(sender, imgPath);
            SlidebarTransition.Start();
        }

        // CHẠY CÁC FILE GIF KHI CLICK
        private Timer gifTimer = new Timer();
        private bool isPlaying = false;

        private void pictureBox_GifFile_Click(object sender, EventArgs args)
        {


            if (!isPlaying)
            {
                gifTimer.Interval = 590;
                gifTimer.Tick += (s, ev) =>
                {
                    gifTimer.Stop();
                    if (isSlidebarExpand == false)
                    {
                        // Giữ icon menu mặc định nếu như slidebar chưa expanded
                        ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\img\\MenuIconDefault.png");
                    }
                    else
                    {
                        // Khi đã expaned thì chỉnh qua icon đặc biệt
                        ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\img\\MenuIconExpanded.png");
                    }
                    isPlaying = false;
                };
                gifTimer.Start();
                if (isSlidebarExpand == false)
                {
                    // File Gif chạy icon default sang icon đặc biệt
                    ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\img\\MenuIconTransition.gif");
                }
                else
                {
                    // File GIf chạy icon đặc biệt về icon default
                    ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\img\\MenuIconTransitionReversed.gif");
                }
                isPlaying = true;
            }
        }
        #endregion
    }
}
