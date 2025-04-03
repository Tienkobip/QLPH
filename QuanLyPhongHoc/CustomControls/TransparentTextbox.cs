using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyPhongHoc.CustomControls
{
    public class TransparentTextBox : TextBox
    {
        public TransparentTextBox()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.None;
        }
    }
}
