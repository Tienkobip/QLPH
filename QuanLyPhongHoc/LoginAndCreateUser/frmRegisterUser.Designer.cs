namespace QuanLyPhongHoc.LoginAndCreateUser
{
    partial class frmRegisterUser
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label_SignUp = new System.Windows.Forms.Label();
            label_Name = new System.Windows.Forms.Label();
            textBox_Name = new System.Windows.Forms.TextBox();
            panel_SignUpInputContainer = new System.Windows.Forms.Panel();
            lbInvalidPhone = new System.Windows.Forms.Label();
            lbInvalidPassword = new System.Windows.Forms.Label();
            lbInvalidEmail = new System.Windows.Forms.Label();
            lbInvalidName = new System.Windows.Forms.Label();
            textBox_Phone = new System.Windows.Forms.TextBox();
            label_Phone = new System.Windows.Forms.Label();
            button_SignUp = new System.Windows.Forms.Button();
            textBox_Password = new System.Windows.Forms.TextBox();
            label_Password = new System.Windows.Forms.Label();
            textBox_Email = new System.Windows.Forms.TextBox();
            label_Email = new System.Windows.Forms.Label();
            label_ReturnLogin = new System.Windows.Forms.Label();
            label_SignIn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_SignUpInputContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.SignUpBackground;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(435, 576);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label_SignUp
            // 
            label_SignUp.AutoSize = true;
            label_SignUp.Font = new System.Drawing.Font("Century Gothic", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_SignUp.Location = new System.Drawing.Point(453, 19);
            label_SignUp.Name = "label_SignUp";
            label_SignUp.Size = new System.Drawing.Size(178, 51);
            label_SignUp.TabIndex = 1;
            label_SignUp.Text = "Sign up";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_Name.Location = new System.Drawing.Point(10, 0);
            label_Name.Name = "label_Name";
            label_Name.Size = new System.Drawing.Size(62, 25);
            label_Name.TabIndex = 3;
            label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_Name.Location = new System.Drawing.Point(0, 31);
            textBox_Name.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new System.Drawing.Size(381, 27);
            textBox_Name.TabIndex = 4;
            // 
            // panel_SignUpInputContainer
            // 
            panel_SignUpInputContainer.Controls.Add(lbInvalidPhone);
            panel_SignUpInputContainer.Controls.Add(lbInvalidPassword);
            panel_SignUpInputContainer.Controls.Add(lbInvalidEmail);
            panel_SignUpInputContainer.Controls.Add(lbInvalidName);
            panel_SignUpInputContainer.Controls.Add(textBox_Phone);
            panel_SignUpInputContainer.Controls.Add(label_Phone);
            panel_SignUpInputContainer.Controls.Add(button_SignUp);
            panel_SignUpInputContainer.Controls.Add(textBox_Password);
            panel_SignUpInputContainer.Controls.Add(label_Password);
            panel_SignUpInputContainer.Controls.Add(textBox_Email);
            panel_SignUpInputContainer.Controls.Add(label_Email);
            panel_SignUpInputContainer.Controls.Add(textBox_Name);
            panel_SignUpInputContainer.Controls.Add(label_Name);
            panel_SignUpInputContainer.Location = new System.Drawing.Point(453, 103);
            panel_SignUpInputContainer.Name = "panel_SignUpInputContainer";
            panel_SignUpInputContainer.Size = new System.Drawing.Size(384, 336);
            panel_SignUpInputContainer.TabIndex = 2;
            // 
            // lbInvalidPhone
            // 
            lbInvalidPhone.AutoSize = true;
            lbInvalidPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbInvalidPhone.ForeColor = System.Drawing.Color.Red;
            lbInvalidPhone.Location = new System.Drawing.Point(81, 208);
            lbInvalidPhone.Name = "lbInvalidPhone";
            lbInvalidPhone.Size = new System.Drawing.Size(0, 20);
            lbInvalidPhone.TabIndex = 17;
            // 
            // lbInvalidPassword
            // 
            lbInvalidPassword.AutoSize = true;
            lbInvalidPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbInvalidPassword.ForeColor = System.Drawing.Color.Red;
            lbInvalidPassword.Location = new System.Drawing.Point(120, 140);
            lbInvalidPassword.Name = "lbInvalidPassword";
            lbInvalidPassword.Size = new System.Drawing.Size(0, 20);
            lbInvalidPassword.TabIndex = 16;
            // 
            // lbInvalidEmail
            // 
            lbInvalidEmail.AutoSize = true;
            lbInvalidEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbInvalidEmail.ForeColor = System.Drawing.Color.Red;
            lbInvalidEmail.Location = new System.Drawing.Point(81, 72);
            lbInvalidEmail.Name = "lbInvalidEmail";
            lbInvalidEmail.Size = new System.Drawing.Size(0, 20);
            lbInvalidEmail.TabIndex = 15;
            // 
            // lbInvalidName
            // 
            lbInvalidName.AutoSize = true;
            lbInvalidName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbInvalidName.ForeColor = System.Drawing.Color.Red;
            lbInvalidName.Location = new System.Drawing.Point(81, 4);
            lbInvalidName.Name = "lbInvalidName";
            lbInvalidName.Size = new System.Drawing.Size(0, 20);
            lbInvalidName.TabIndex = 5;
            // 
            // textBox_Phone
            // 
            textBox_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_Phone.Location = new System.Drawing.Point(0, 235);
            textBox_Phone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new System.Drawing.Size(381, 27);
            textBox_Phone.TabIndex = 14;
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_Phone.Location = new System.Drawing.Point(10, 204);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new System.Drawing.Size(66, 25);
            label_Phone.TabIndex = 13;
            label_Phone.Text = "Phone";
            // 
            // button_SignUp
            // 
            button_SignUp.BackColor = System.Drawing.Color.FromArgb(95, 127, 255);
            button_SignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button_SignUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            button_SignUp.FlatAppearance.BorderSize = 0;
            button_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_SignUp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button_SignUp.ForeColor = System.Drawing.Color.White;
            button_SignUp.Image = Properties.Resources.SignUpIcon;
            button_SignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_SignUp.Location = new System.Drawing.Point(0, 288);
            button_SignUp.Name = "button_SignUp";
            button_SignUp.Size = new System.Drawing.Size(384, 48);
            button_SignUp.TabIndex = 10;
            button_SignUp.Text = "Sign up";
            button_SignUp.UseVisualStyleBackColor = false;
            button_SignUp.Click += button_SignUp_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_Password.Location = new System.Drawing.Point(0, 167);
            textBox_Password.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new System.Drawing.Size(381, 27);
            textBox_Password.TabIndex = 9;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_Password.Location = new System.Drawing.Point(10, 136);
            label_Password.Name = "label_Password";
            label_Password.Size = new System.Drawing.Size(92, 25);
            label_Password.TabIndex = 8;
            label_Password.Text = "Password";
            // 
            // textBox_Email
            // 
            textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_Email.Location = new System.Drawing.Point(0, 99);
            textBox_Email.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new System.Drawing.Size(381, 27);
            textBox_Email.TabIndex = 7;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_Email.Location = new System.Drawing.Point(10, 68);
            label_Email.Name = "label_Email";
            label_Email.Size = new System.Drawing.Size(58, 25);
            label_Email.TabIndex = 6;
            label_Email.Text = "Email";
            // 
            // label_ReturnLogin
            // 
            label_ReturnLogin.AutoSize = true;
            label_ReturnLogin.Location = new System.Drawing.Point(534, 511);
            label_ReturnLogin.Name = "label_ReturnLogin";
            label_ReturnLogin.Size = new System.Drawing.Size(178, 20);
            label_ReturnLogin.TabIndex = 3;
            label_ReturnLogin.Text = "Already have an account?";
            label_ReturnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SignIn
            // 
            label_SignIn.AutoSize = true;
            label_SignIn.ForeColor = System.Drawing.Color.Blue;
            label_SignIn.Location = new System.Drawing.Point(697, 511);
            label_SignIn.Name = "label_SignIn";
            label_SignIn.Size = new System.Drawing.Size(54, 20);
            label_SignIn.TabIndex = 4;
            label_SignIn.Text = "Sign In";
            label_SignIn.Click += label_SignIn_Click;
            // 
            // frmRegisterUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 576);
            Controls.Add(label_SignIn);
            Controls.Add(label_ReturnLogin);
            Controls.Add(panel_SignUpInputContainer);
            Controls.Add(label_SignUp);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmRegisterUser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCreateUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_SignUpInputContainer.ResumeLayout(false);
            panel_SignUpInputContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_SignUp;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Panel panel_SignUpInputContainer;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Label label_ReturnLogin;
        private System.Windows.Forms.Label label_SignIn;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label lbInvalidName;
        private System.Windows.Forms.Label lbInvalidEmail;
        private System.Windows.Forms.Label lbInvalidPassword;
        private System.Windows.Forms.Label lbInvalidPhone;
    }
}