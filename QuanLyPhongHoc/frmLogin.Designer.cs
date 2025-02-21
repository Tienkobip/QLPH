namespace QuanLyPhongHoc
{
    partial class frmLogin
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
            this.label_Login = new System.Windows.Forms.Label();
            this.pictureBox_UserIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox_Password = new System.Windows.Forms.PictureBox();
            this.pictureBox_UserIconLogin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel_Exit = new System.Windows.Forms.Panel();
            this.label_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIconLogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_Exit.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Login.Location = new System.Drawing.Point(105, 203);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(273, 77);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "LOGIN";
            // 
            // pictureBox_UserIcon
            // 
            this.pictureBox_UserIcon.Location = new System.Drawing.Point(141, 52);
            this.pictureBox_UserIcon.Name = "pictureBox_UserIcon";
            this.pictureBox_UserIcon.Size = new System.Drawing.Size(191, 148);
            this.pictureBox_UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_UserIcon.TabIndex = 2;
            this.pictureBox_UserIcon.TabStop = false;
            // 
            // pictureBox_Password
            // 
            this.pictureBox_Password.Location = new System.Drawing.Point(0, 3);
            this.pictureBox_Password.Name = "pictureBox_Password";
            this.pictureBox_Password.Size = new System.Drawing.Size(35, 36);
            this.pictureBox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Password.TabIndex = 3;
            this.pictureBox_Password.TabStop = false;
            this.pictureBox_Password.Click += new System.EventHandler(this.pictureBox_Password_Click);
            // 
            // pictureBox_UserIconLogin
            // 
            this.pictureBox_UserIconLogin.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_UserIconLogin.Name = "pictureBox_UserIconLogin";
            this.pictureBox_UserIconLogin.Size = new System.Drawing.Size(32, 30);
            this.pictureBox_UserIconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_UserIconLogin.TabIndex = 0;
            this.pictureBox_UserIconLogin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(36, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Username);
            this.panel1.Controls.Add(this.pictureBox_UserIconLogin);
            this.panel1.Location = new System.Drawing.Point(36, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 43);
            this.panel1.TabIndex = 4;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(36, 498);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(395, 77);
            this.button_Login.TabIndex = 9;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // panel_Exit
            // 
            this.panel_Exit.Controls.Add(this.label_Exit);
            this.panel_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Exit.Location = new System.Drawing.Point(0, 581);
            this.panel_Exit.Name = "panel_Exit";
            this.panel_Exit.Size = new System.Drawing.Size(488, 79);
            this.panel_Exit.TabIndex = 7;
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Exit.Location = new System.Drawing.Point(199, 11);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(60, 35);
            this.label_Exit.TabIndex = 0;
            this.label_Exit.Text = "Exit";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(345, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_Password);
            this.panel4.Controls.Add(this.pictureBox_Password);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(36, 369);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 45);
            this.panel4.TabIndex = 9;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(41, 5);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(361, 31);
            this.textBox_Username.TabIndex = 5;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(39, 6);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(361, 31);
            this.textBox_Password.TabIndex = 6;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(488, 660);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Exit);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_UserIcon);
            this.Controls.Add(this.label_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserIconLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Exit.ResumeLayout(false);
            this.panel_Exit.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.PictureBox pictureBox_UserIcon;
        private System.Windows.Forms.PictureBox pictureBox_Password;
        private System.Windows.Forms.PictureBox pictureBox_UserIconLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Panel panel_Exit;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
    }
}