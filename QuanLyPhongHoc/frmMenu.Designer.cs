namespace QuanLyPhongHoc
{
    partial class frmMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            panel_ControlBoxContainer = new System.Windows.Forms.Panel();
            pictureBox_MenuIcon = new System.Windows.Forms.PictureBox();
            panel_FormBorderContaienr = new System.Windows.Forms.Panel();
            button_Close = new System.Windows.Forms.Button();
            button_Maximize = new System.Windows.Forms.Button();
            button_Minimize = new System.Windows.Forms.Button();
            Slidebar = new System.Windows.Forms.FlowLayoutPanel();
            button_Menu = new System.Windows.Forms.Button();
            button_Maintain = new System.Windows.Forms.Button();
            ClassContainer = new System.Windows.Forms.FlowLayoutPanel();
            button_ClassAdmin = new System.Windows.Forms.Button();
            button_ClassList = new System.Windows.Forms.Button();
            button_AddRemoveClass = new System.Windows.Forms.Button();
            button_Notification = new System.Windows.Forms.Button();
            button_Logout = new System.Windows.Forms.Button();
            MenuTransition = new System.Windows.Forms.Timer(components);
            SlidebarTransition = new System.Windows.Forms.Timer(components);
            panel_ControlBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_MenuIcon).BeginInit();
            panel_FormBorderContaienr.SuspendLayout();
            Slidebar.SuspendLayout();
            ClassContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ControlBoxContainer
            // 
            panel_ControlBoxContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            panel_ControlBoxContainer.Controls.Add(pictureBox_MenuIcon);
            panel_ControlBoxContainer.Controls.Add(panel_FormBorderContaienr);
            panel_ControlBoxContainer.Dock = System.Windows.Forms.DockStyle.Top;
            panel_ControlBoxContainer.Location = new System.Drawing.Point(3, 3);
            panel_ControlBoxContainer.Name = "panel_ControlBoxContainer";
            panel_ControlBoxContainer.Size = new System.Drawing.Size(1171, 44);
            panel_ControlBoxContainer.TabIndex = 0;
            panel_ControlBoxContainer.MouseDown += panel1_MouseDown;
            // 
            // pictureBox_MenuIcon
            // 
            pictureBox_MenuIcon.Image = (System.Drawing.Image)resources.GetObject("pictureBox_MenuIcon.Image");
            pictureBox_MenuIcon.Location = new System.Drawing.Point(14, 7);
            pictureBox_MenuIcon.Name = "pictureBox_MenuIcon";
            pictureBox_MenuIcon.Size = new System.Drawing.Size(30, 30);
            pictureBox_MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox_MenuIcon.TabIndex = 7;
            pictureBox_MenuIcon.TabStop = false;
            pictureBox_MenuIcon.Click += pictureBox_MenuIcon_Click;
            pictureBox_MenuIcon.MouseEnter += Control_MouseEnterCursor;
            // 
            // panel_FormBorderContaienr
            // 
            panel_FormBorderContaienr.Controls.Add(button_Close);
            panel_FormBorderContaienr.Controls.Add(button_Maximize);
            panel_FormBorderContaienr.Controls.Add(button_Minimize);
            panel_FormBorderContaienr.Dock = System.Windows.Forms.DockStyle.Right;
            panel_FormBorderContaienr.Location = new System.Drawing.Point(973, 0);
            panel_FormBorderContaienr.Name = "panel_FormBorderContaienr";
            panel_FormBorderContaienr.Size = new System.Drawing.Size(198, 44);
            panel_FormBorderContaienr.TabIndex = 2;
            // 
            // button_Close
            // 
            button_Close.Dock = System.Windows.Forms.DockStyle.Left;
            button_Close.FlatAppearance.BorderSize = 0;
            button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Close.Image = Properties.Resources.CloseIcon;
            button_Close.Location = new System.Drawing.Point(130, 0);
            button_Close.Margin = new System.Windows.Forms.Padding(0);
            button_Close.Name = "button_Close";
            button_Close.Size = new System.Drawing.Size(65, 44);
            button_Close.TabIndex = 5;
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            button_Close.MouseEnter += Control_MouseEnter_Close;
            button_Close.MouseLeave += Control_MouseLeave;
            // 
            // button_Maximize
            // 
            button_Maximize.Dock = System.Windows.Forms.DockStyle.Left;
            button_Maximize.FlatAppearance.BorderSize = 0;
            button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Maximize.Image = Properties.Resources.MaximizeIcon;
            button_Maximize.Location = new System.Drawing.Point(65, 0);
            button_Maximize.Margin = new System.Windows.Forms.Padding(0);
            button_Maximize.Name = "button_Maximize";
            button_Maximize.Size = new System.Drawing.Size(65, 44);
            button_Maximize.TabIndex = 4;
            button_Maximize.UseVisualStyleBackColor = true;
            button_Maximize.Click += button_Maximize_Click;
            button_Maximize.MouseEnter += Control_MouseEnter;
            button_Maximize.MouseLeave += Control_MouseLeave;
            // 
            // button_Minimize
            // 
            button_Minimize.Dock = System.Windows.Forms.DockStyle.Left;
            button_Minimize.FlatAppearance.BorderSize = 0;
            button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Minimize.Image = Properties.Resources.MinimizeIcon;
            button_Minimize.Location = new System.Drawing.Point(0, 0);
            button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            button_Minimize.Name = "button_Minimize";
            button_Minimize.Size = new System.Drawing.Size(65, 44);
            button_Minimize.TabIndex = 0;
            button_Minimize.UseVisualStyleBackColor = false;
            button_Minimize.Click += button_Minimize_Click;
            button_Minimize.MouseEnter += Control_MouseEnter;
            button_Minimize.MouseLeave += Control_MouseLeave;
            // 
            // Slidebar
            // 
            Slidebar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            Slidebar.Controls.Add(button_Menu);
            Slidebar.Controls.Add(button_Maintain);
            Slidebar.Controls.Add(ClassContainer);
            Slidebar.Controls.Add(button_Notification);
            Slidebar.Controls.Add(button_Logout);
            Slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            Slidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            Slidebar.Location = new System.Drawing.Point(3, 47);
            Slidebar.Margin = new System.Windows.Forms.Padding(0);
            Slidebar.MaximumSize = new System.Drawing.Size(270, 0);
            Slidebar.MinimumSize = new System.Drawing.Size(62, 0);
            Slidebar.Name = "Slidebar";
            Slidebar.Size = new System.Drawing.Size(62, 500);
            Slidebar.TabIndex = 1;
            // 
            // button_Menu
            // 
            button_Menu.FlatAppearance.BorderSize = 0;
            button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            button_Menu.Image = Properties.Resources.MainMenuIcon;
            button_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button_Menu.Location = new System.Drawing.Point(0, 0);
            button_Menu.Margin = new System.Windows.Forms.Padding(0);
            button_Menu.Name = "button_Menu";
            button_Menu.Padding = new System.Windows.Forms.Padding(10, 10, 105, 10);
            button_Menu.Size = new System.Drawing.Size(273, 72);
            button_Menu.TabIndex = 2;
            button_Menu.Text = "Menu";
            button_Menu.UseVisualStyleBackColor = true;
            button_Menu.MouseEnter += Control_MouseEnter;
            button_Menu.MouseLeave += Control_MouseLeave;
            button_Menu.MouseHover += Control_MouseEnterCursor;
            // 
            // button_Maintain
            // 
            button_Maintain.FlatAppearance.BorderSize = 0;
            button_Maintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Maintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            button_Maintain.Image = Properties.Resources.MaintainIcon;
            button_Maintain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button_Maintain.Location = new System.Drawing.Point(0, 72);
            button_Maintain.Margin = new System.Windows.Forms.Padding(0);
            button_Maintain.Name = "button_Maintain";
            button_Maintain.Padding = new System.Windows.Forms.Padding(10, 10, 76, 10);
            button_Maintain.Size = new System.Drawing.Size(273, 72);
            button_Maintain.TabIndex = 3;
            button_Maintain.Text = "Quản lý bảo trì";
            button_Maintain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_Maintain.UseVisualStyleBackColor = true;
            button_Maintain.Click += button_Maintain_Click;
            button_Maintain.MouseEnter += Control_MouseEnter;
            button_Maintain.MouseLeave += Control_MouseLeave;
            button_Maintain.MouseHover += Control_MouseEnterCursor;
            // 
            // ClassContainer
            // 
            ClassContainer.Controls.Add(button_ClassAdmin);
            ClassContainer.Controls.Add(button_ClassList);
            ClassContainer.Controls.Add(button_AddRemoveClass);
            ClassContainer.Location = new System.Drawing.Point(0, 144);
            ClassContainer.Margin = new System.Windows.Forms.Padding(0);
            ClassContainer.MaximumSize = new System.Drawing.Size(273, 217);
            ClassContainer.MinimumSize = new System.Drawing.Size(273, 72);
            ClassContainer.Name = "ClassContainer";
            ClassContainer.Size = new System.Drawing.Size(273, 72);
            ClassContainer.TabIndex = 8;
            // 
            // button_ClassAdmin
            // 
            button_ClassAdmin.FlatAppearance.BorderSize = 0;
            button_ClassAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_ClassAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            button_ClassAdmin.Image = Properties.Resources.ClassIcon;
            button_ClassAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button_ClassAdmin.Location = new System.Drawing.Point(0, 0);
            button_ClassAdmin.Margin = new System.Windows.Forms.Padding(0);
            button_ClassAdmin.Name = "button_ClassAdmin";
            button_ClassAdmin.Padding = new System.Windows.Forms.Padding(10, 10, 43, 10);
            button_ClassAdmin.Size = new System.Drawing.Size(273, 72);
            button_ClassAdmin.TabIndex = 4;
            button_ClassAdmin.Text = "Quản lý phòng họp";
            button_ClassAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_ClassAdmin.UseVisualStyleBackColor = true;
            button_ClassAdmin.Click += button_Class_Click;
            button_ClassAdmin.MouseEnter += Control_MouseEnter;
            button_ClassAdmin.MouseLeave += Control_MouseLeave;
            button_ClassAdmin.MouseHover += Control_MouseEnterCursor;
            // 
            // button_ClassList
            // 
            button_ClassList.BackColor = System.Drawing.SystemColors.ControlLight;
            button_ClassList.FlatAppearance.BorderSize = 0;
            button_ClassList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_ClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            button_ClassList.Image = Properties.Resources.DotIcon;
            button_ClassList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button_ClassList.Location = new System.Drawing.Point(0, 72);
            button_ClassList.Margin = new System.Windows.Forms.Padding(0);
            button_ClassList.Name = "button_ClassList";
            button_ClassList.Padding = new System.Windows.Forms.Padding(15, 10, 18, 10);
            button_ClassList.Size = new System.Drawing.Size(273, 72);
            button_ClassList.TabIndex = 9;
            button_ClassList.Text = "Danh sách phòng học";
            button_ClassList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_ClassList.UseVisualStyleBackColor = false;
            button_ClassList.Click += panel_ClassList_Click;
            button_ClassList.MouseEnter += Control_MouseEnterCursor;
            // 
            // button_AddRemoveClass
            // 
            button_AddRemoveClass.BackColor = System.Drawing.SystemColors.ControlLight;
            button_AddRemoveClass.FlatAppearance.BorderSize = 0;
            button_AddRemoveClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_AddRemoveClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            button_AddRemoveClass.Image = Properties.Resources.DotIcon;
            button_AddRemoveClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button_AddRemoveClass.Location = new System.Drawing.Point(0, 144);
            button_AddRemoveClass.Margin = new System.Windows.Forms.Padding(0);
            button_AddRemoveClass.Name = "button_AddRemoveClass";
            button_AddRemoveClass.Padding = new System.Windows.Forms.Padding(15, 10, 25, 10);
            button_AddRemoveClass.Size = new System.Drawing.Size(273, 72);
            button_AddRemoveClass.TabIndex = 10;
            button_AddRemoveClass.Text = "Thêm, xóa phòng học";
            button_AddRemoveClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_AddRemoveClass.UseVisualStyleBackColor = false;
            button_AddRemoveClass.Click += panel_AddRemoveClass_Click;
            button_AddRemoveClass.MouseEnter += Control_MouseEnterCursor;
            // 
            // button_Notification
            // 
            button_Notification.FlatAppearance.BorderSize = 0;
            button_Notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            button_Notification.Image = Properties.Resources.BellIcon;
            button_Notification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button_Notification.Location = new System.Drawing.Point(0, 216);
            button_Notification.Margin = new System.Windows.Forms.Padding(0);
            button_Notification.Name = "button_Notification";
            button_Notification.Padding = new System.Windows.Forms.Padding(10, 10, 115, 10);
            button_Notification.Size = new System.Drawing.Size(273, 72);
            button_Notification.TabIndex = 5;
            button_Notification.Text = "Thông báo";
            button_Notification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_Notification.UseVisualStyleBackColor = true;
            button_Notification.MouseEnter += Control_MouseEnter;
            button_Notification.MouseLeave += Control_MouseLeave;
            button_Notification.MouseHover += Control_MouseEnterCursor;
            // 
            // button_Logout
            // 
            button_Logout.FlatAppearance.BorderSize = 0;
            button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            button_Logout.Image = Properties.Resources.LogoutIcon;
            button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button_Logout.Location = new System.Drawing.Point(0, 288);
            button_Logout.Margin = new System.Windows.Forms.Padding(0);
            button_Logout.Name = "button_Logout";
            button_Logout.Padding = new System.Windows.Forms.Padding(10, 10, 115, 10);
            button_Logout.Size = new System.Drawing.Size(273, 72);
            button_Logout.TabIndex = 6;
            button_Logout.Text = "Đăng xuất";
            button_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_Logout.UseVisualStyleBackColor = true;
            button_Logout.MouseEnter += Control_MouseEnter;
            button_Logout.MouseLeave += Control_MouseLeave;
            button_Logout.MouseHover += Control_MouseEnterCursor;
            // 
            // MenuTransition
            // 
            MenuTransition.Interval = 10;
            MenuTransition.Tick += MenuTransition_Tick;
            // 
            // SlidebarTransition
            // 
            SlidebarTransition.Interval = 10;
            SlidebarTransition.Tick += SlidebarTransition_Tick;
            // 
            // frmMenu
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(1177, 550);
            ControlBox = false;
            Controls.Add(Slidebar);
            Controls.Add(panel_ControlBoxContainer);
            IsMdiContainer = true;
            MinimumSize = new System.Drawing.Size(970, 550);
            Name = "frmMenu";
            Padding = new System.Windows.Forms.Padding(3);
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Load += frmMenu_Load;
            panel_ControlBoxContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_MenuIcon).EndInit();
            panel_FormBorderContaienr.ResumeLayout(false);
            Slidebar.ResumeLayout(false);
            ClassContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ControlBoxContainer;
        private System.Windows.Forms.FlowLayoutPanel Slidebar;
        private System.Windows.Forms.FlowLayoutPanel ClassContainer;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Timer SlidebarTransition;
        private System.Windows.Forms.Panel panel_FormBorderContaienr;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Maximize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.PictureBox pictureBox_MenuIcon;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Button button_Maintain;
        private System.Windows.Forms.Button button_ClassAdmin;
        private System.Windows.Forms.Button button_Notification;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_ClassList;
        private System.Windows.Forms.Button button_AddRemoveClass;
    }
}