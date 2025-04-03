using System.Windows.Forms;

namespace QuanLyPhongHoc.CustomNotification
{
    partial class frmCustomNotification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // frmCustomNotification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(302, 23);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCustomNotification";
            Padding = new Padding(10, 15, 10, 10);
            ResumeLayout(false);
        }

        #endregion
    }
}