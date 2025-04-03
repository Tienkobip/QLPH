using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace QuanLyPhongHoc.CustomControls
{
    public class RoundPictureBox : PictureBox   
    {
        private float borderThickness = 3f;
        private Color borderColor = Color.Black;

        [Browsable(true)] // Hiển thị trong Property Grid
        [Category("Custom Properties")]
        [Description("Độ dày của viền.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // Đảm bảo được serialize
        public float BorderThickness
        {
            get => borderThickness;
            set
            {
                borderThickness = value;
                this.Invalidate(); // Vẽ lại PictureBox khi giá trị thay đổi
            }
        }

        [Browsable(true)]
        [Category("Custom Properties")]
        [Description("Màu sắc của viền.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public RoundPictureBox()
        {
            this.BackColor = Color.Transparent;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if(this.Image != null)
            {
                using (GraphicsPath gp = new GraphicsPath())
                using (Pen borderPen = new Pen(BorderColor, BorderThickness))
                {
                    pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    float scaleFactor = 0.65f; // Thu nhỏ hình ellipse 65% so với PictureBox
                    int newWidth = (int)(this.Width * scaleFactor);
                    int newHeight = (int)(this.Height * scaleFactor);
                    int XEllipse = (this.Width - newWidth) / 2;
                    int YEllipse = (this.Height - newHeight) / 2;


                    gp.AddEllipse(XEllipse, YEllipse, newWidth, newHeight);
                    this.Region = new Region(gp);

                    pe.Graphics.SetClip(gp);
                    pe.Graphics.DrawImage(this.Image, new Rectangle(XEllipse, YEllipse, newWidth, newHeight));

                    pe.Graphics.ResetClip();
                    pe.Graphics.DrawEllipse(borderPen, new Rectangle(XEllipse, YEllipse, newWidth, newHeight));
                }
            }
            else
            {
                this.Image = Properties.Resources.DefaultAvatar;
            }
        }
    }
}
