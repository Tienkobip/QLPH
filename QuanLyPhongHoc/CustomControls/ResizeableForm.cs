using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongHoc.CustomControls
{
    public class ResizeableForm : Form
    {
        private const int RESIZE_HANDLE_SIZE = 20; // Kích thước vùng resize
        private const int CAPTION_HEIGHT = 40; // Chiều cao của thanh tiêu đề

        public ResizeableForm()
        {
            this.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền mặc định
            this.DoubleBuffered = true; // Giảm nhấp nháy khi vẽ lại
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Vẽ lại khi resize
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Vẽ phần kéo giãn góc dưới bên phải
            Rectangle rc = new Rectangle(this.ClientSize.Width - RESIZE_HANDLE_SIZE, this.ClientSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14,
                      HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                Point cursor = new Point(m.LParam.ToInt32());
                Point clientCursor = this.PointToClient(cursor);

                if (clientCursor.Y <= CAPTION_HEIGHT && clientCursor.Y >= RESIZE_HANDLE_SIZE)
                {
                    m.Result = (IntPtr)2; // HTCAPTION - Kéo form
                    return;
                }
                if (clientCursor.X <= RESIZE_HANDLE_SIZE && clientCursor.Y <= RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (clientCursor.X >= this.ClientSize.Width - RESIZE_HANDLE_SIZE && clientCursor.Y <= RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (clientCursor.X <= RESIZE_HANDLE_SIZE && clientCursor.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (clientCursor.X >= this.ClientSize.Width - RESIZE_HANDLE_SIZE && clientCursor.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (clientCursor.X <= RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTLEFT;
                else if (clientCursor.X >= this.ClientSize.Width - RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTRIGHT;
                else if (clientCursor.Y <= RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTTOP;
                else if (clientCursor.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTBOTTOM;

                return;
            }
            base.WndProc(ref m);
        }
    }
}

