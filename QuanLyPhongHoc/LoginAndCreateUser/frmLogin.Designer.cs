using QuanLyPhongHoc.CustomControls;
using System.Drawing;
using System.Windows.Forms;
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
            label_Login = new Label();
            pictureBox_LoginBackground = new PictureBox();
            pictureBox_Password = new PictureBox();
            pictureBox_UserIconLogin = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel_UserNameInput = new Panel();
            textBox_Username = new TransparentTextBox();
            button_Login = new Button();
            label_Register = new Label();
            panel_UserPasswordInput = new Panel();
            button_ShowAndHidePass = new Button();
            textBox_Password = new TransparentTextBox();
            panel_LoginContainer = new Panel();
            checkBox_RememberMe = new CheckBox();
            button_Exit = new Button();
            button_Github = new Button();
            button_Google = new Button();
            button_Facebook = new Button();
            label_OtherLogin = new Label();
            panel_UserInputContainer = new TransparentPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_LoginBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_UserIconLogin).BeginInit();
            panel_UserNameInput.SuspendLayout();
            panel_UserPasswordInput.SuspendLayout();
            panel_LoginContainer.SuspendLayout();
            panel_UserInputContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label_Login
            // 
            label_Login.AutoSize = true;
            label_Login.BackColor = Color.Transparent;
            label_Login.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Login.ForeColor = SystemColors.ActiveCaptionText;
            label_Login.Location = new Point(221, 21);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(160, 51);
            label_Login.TabIndex = 1;
            label_Login.Text = "LOGIN";
            // 
            // pictureBox_LoginBackground
            // 
            pictureBox_LoginBackground.BackgroundImage = Properties.Resources.LoginBackground;
            pictureBox_LoginBackground.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_LoginBackground.Dock = DockStyle.Fill;
            pictureBox_LoginBackground.Location = new Point(0, 0);
            pictureBox_LoginBackground.Name = "pictureBox_LoginBackground";
            pictureBox_LoginBackground.Size = new Size(560, 800);
            pictureBox_LoginBackground.TabIndex = 11;
            pictureBox_LoginBackground.TabStop = false;
            // 
            // pictureBox_Password
            // 
            pictureBox_Password.BackgroundImage = Properties.Resources.Password;
            pictureBox_Password.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_Password.Location = new Point(3, 4);
            pictureBox_Password.Margin = new Padding(3, 4, 3, 4);
            pictureBox_Password.Name = "pictureBox_Password";
            pictureBox_Password.Size = new Size(32, 38);
            pictureBox_Password.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Password.TabIndex = 3;
            pictureBox_Password.TabStop = false;
            pictureBox_Password.Click += pictureBox_Password_Click;
            // 
            // pictureBox_UserIconLogin
            // 
            pictureBox_UserIconLogin.BackgroundImage = Properties.Resources.UserIconLogin;
            pictureBox_UserIconLogin.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_UserIconLogin.Location = new Point(3, 4);
            pictureBox_UserIconLogin.Margin = new Padding(3, 4, 3, 4);
            pictureBox_UserIconLogin.Name = "pictureBox_UserIconLogin";
            pictureBox_UserIconLogin.Size = new Size(32, 38);
            pictureBox_UserIconLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_UserIconLogin.TabIndex = 0;
            pictureBox_UserIconLogin.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(3, 47);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 1);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(3, 47);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 1);
            panel3.TabIndex = 5;
            // 
            // panel_UserNameInput
            // 
            panel_UserNameInput.Controls.Add(pictureBox_UserIconLogin);
            panel_UserNameInput.Controls.Add(panel2);
            panel_UserNameInput.Controls.Add(textBox_Username);
            panel_UserNameInput.Dock = DockStyle.Top;
            panel_UserNameInput.Location = new Point(0, 0);
            panel_UserNameInput.Margin = new Padding(20);
            panel_UserNameInput.Name = "panel_UserNameInput";
            panel_UserNameInput.Size = new Size(515, 54);
            panel_UserNameInput.TabIndex = 4;
            // 
            // textBox_Username
            // 
            textBox_Username.BackColor = Color.Transparent;
            textBox_Username.BorderStyle = BorderStyle.None;
            textBox_Username.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Username.Location = new Point(38, 4);
            textBox_Username.Margin = new Padding(3, 4, 3, 4);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(463, 31);
            textBox_Username.TabIndex = 5;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.FromArgb(24, 128, 225);
            button_Login.Dock = DockStyle.Bottom;
            button_Login.FlatAppearance.BorderSize = 0;
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Login.ForeColor = Color.White;
            button_Login.Location = new Point(0, 160);
            button_Login.Margin = new Padding(3, 4, 3, 4);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(515, 60);
            button_Login.TabIndex = 9;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // label_Register
            // 
            label_Register.AutoSize = true;
            label_Register.BackColor = Color.Transparent;
            label_Register.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Register.ForeColor = Color.FromArgb(24, 128, 225);
            label_Register.Location = new Point(477, 409);
            label_Register.Name = "label_Register";
            label_Register.Size = new Size(86, 27);
            label_Register.TabIndex = 8;
            label_Register.Text = "Register";
            label_Register.Click += label_Register_Click;
            // 
            // panel_UserPasswordInput
            // 
            panel_UserPasswordInput.Controls.Add(button_ShowAndHidePass);
            panel_UserPasswordInput.Controls.Add(pictureBox_Password);
            panel_UserPasswordInput.Controls.Add(panel3);
            panel_UserPasswordInput.Controls.Add(textBox_Password);
            panel_UserPasswordInput.Location = new Point(0, 79);
            panel_UserPasswordInput.Margin = new Padding(20);
            panel_UserPasswordInput.Name = "panel_UserPasswordInput";
            panel_UserPasswordInput.Size = new Size(515, 54);
            panel_UserPasswordInput.TabIndex = 9;
            // 
            // button_ShowAndHidePass
            // 
            button_ShowAndHidePass.BackgroundImage = Properties.Resources.ShowPasswordIcon;
            button_ShowAndHidePass.BackgroundImageLayout = ImageLayout.Zoom;
            button_ShowAndHidePass.FlatAppearance.BorderSize = 0;
            button_ShowAndHidePass.FlatStyle = FlatStyle.Flat;
            button_ShowAndHidePass.Location = new Point(470, 9);
            button_ShowAndHidePass.Name = "button_ShowAndHidePass";
            button_ShowAndHidePass.Size = new Size(30, 30);
            button_ShowAndHidePass.TabIndex = 7;
            button_ShowAndHidePass.UseVisualStyleBackColor = true;
            button_ShowAndHidePass.Click += button_ShowAndHidePass_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = Color.Transparent;
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Password.Location = new Point(38, 4);
            textBox_Password.Margin = new Padding(3, 4, 3, 4);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(426, 31);
            textBox_Password.TabIndex = 6;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // panel_LoginContainer
            // 
            panel_LoginContainer.BackColor = Color.White;
            panel_LoginContainer.BackgroundImageLayout = ImageLayout.Stretch;
            panel_LoginContainer.Controls.Add(checkBox_RememberMe);
            panel_LoginContainer.Controls.Add(button_Exit);
            panel_LoginContainer.Controls.Add(button_Github);
            panel_LoginContainer.Controls.Add(button_Google);
            panel_LoginContainer.Controls.Add(button_Facebook);
            panel_LoginContainer.Controls.Add(label_OtherLogin);
            panel_LoginContainer.Controls.Add(panel_UserInputContainer);
            panel_LoginContainer.Controls.Add(label_Login);
            panel_LoginContainer.Controls.Add(label_Register);
            panel_LoginContainer.Dock = DockStyle.Right;
            panel_LoginContainer.Location = new Point(560, 0);
            panel_LoginContainer.Name = "panel_LoginContainer";
            panel_LoginContainer.Size = new Size(615, 800);
            panel_LoginContainer.TabIndex = 10;
            // 
            // checkBox_RememberMe
            // 
            checkBox_RememberMe.AutoSize = true;
            checkBox_RememberMe.Checked = true;
            checkBox_RememberMe.CheckState = CheckState.Checked;
            checkBox_RememberMe.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_RememberMe.Location = new Point(51, 409);
            checkBox_RememberMe.Name = "checkBox_RememberMe";
            checkBox_RememberMe.Size = new Size(193, 29);
            checkBox_RememberMe.TabIndex = 12;
            checkBox_RememberMe.Text = "Tự động đăng nhập";
            checkBox_RememberMe.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.FromArgb(227, 0, 34);
            button_Exit.Dock = DockStyle.Bottom;
            button_Exit.FlatAppearance.BorderSize = 0;
            button_Exit.FlatStyle = FlatStyle.Flat;
            button_Exit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            button_Exit.ForeColor = Color.White;
            button_Exit.Location = new Point(0, 749);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(615, 51);
            button_Exit.TabIndex = 15;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_Github
            // 
            button_Github.BackgroundImage = Properties.Resources.GithubIcon;
            button_Github.BackgroundImageLayout = ImageLayout.Zoom;
            button_Github.Location = new Point(410, 550);
            button_Github.Name = "button_Github";
            button_Github.Size = new Size(150, 61);
            button_Github.TabIndex = 14;
            button_Github.UseVisualStyleBackColor = true;
            // 
            // button_Google
            // 
            button_Google.BackgroundImage = Properties.Resources.GoogleIcon;
            button_Google.BackgroundImageLayout = ImageLayout.Zoom;
            button_Google.Location = new Point(228, 550);
            button_Google.Name = "button_Google";
            button_Google.Size = new Size(150, 61);
            button_Google.TabIndex = 13;
            button_Google.UseVisualStyleBackColor = true;
            // 
            // button_Facebook
            // 
            button_Facebook.BackgroundImage = Properties.Resources.FacebookIcon;
            button_Facebook.BackgroundImageLayout = ImageLayout.Zoom;
            button_Facebook.Location = new Point(45, 550);
            button_Facebook.Name = "button_Facebook";
            button_Facebook.Size = new Size(150, 61);
            button_Facebook.TabIndex = 12;
            button_Facebook.UseVisualStyleBackColor = true;
            // 
            // label_OtherLogin
            // 
            label_OtherLogin.AutoSize = true;
            label_OtherLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_OtherLogin.Location = new Point(48, 508);
            label_OtherLogin.Name = "label_OtherLogin";
            label_OtherLogin.Size = new Size(231, 23);
            label_OtherLogin.TabIndex = 11;
            label_OtherLogin.Text = "Hoặc đăng nhập thông qua: ";
            // 
            // panel_UserInputContainer
            // 
            panel_UserInputContainer.BackColor = Color.Transparent;
            panel_UserInputContainer.Controls.Add(panel_UserNameInput);
            panel_UserInputContainer.Controls.Add(button_Login);
            panel_UserInputContainer.Controls.Add(panel_UserPasswordInput);
            panel_UserInputContainer.Location = new Point(48, 170);
            panel_UserInputContainer.Name = "panel_UserInputContainer";
            panel_UserInputContainer.Size = new Size(515, 220);
            panel_UserInputContainer.TabIndex = 10;
            // 
            // frmLogin
            // 
            AcceptButton = button_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1175, 800);
            Controls.Add(pictureBox_LoginBackground);
            Controls.Add(panel_LoginContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_LoginBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_UserIconLogin).EndInit();
            panel_UserNameInput.ResumeLayout(false);
            panel_UserNameInput.PerformLayout();
            panel_UserPasswordInput.ResumeLayout(false);
            panel_UserPasswordInput.PerformLayout();
            panel_LoginContainer.ResumeLayout(false);
            panel_LoginContainer.PerformLayout();
            panel_UserInputContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.PictureBox pictureBox_LoginBackground;
        private System.Windows.Forms.PictureBox pictureBox_Password;
        private System.Windows.Forms.PictureBox pictureBox_UserIconLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_UserNameInput;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_Register;
        private System.Windows.Forms.Panel panel_UserPasswordInput;
        private TransparentTextBox textBox_Username;
        private TransparentTextBox textBox_Password;
        private System.Windows.Forms.Panel panel_LoginContainer;
        private TransparentPanel panel_UserInputContainer;
        private Button button_ShowAndHidePass;
        private Label label_OtherLogin;
        private Button button_Github;
        private Button button_Google;
        private Button button_Facebook;
        private Button button_Exit;
        private CheckBox checkBox_RememberMe;
    }
}