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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel_ControlBoxContainer = new System.Windows.Forms.Panel();
            this.pictureBox_MenuIcon = new System.Windows.Forms.PictureBox();
            this.panel_FormBorderContaienr = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Maximize = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.Slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Maintain = new System.Windows.Forms.Button();
            this.ClassContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ClassAdmin = new System.Windows.Forms.Button();
            this.button_ClassList = new System.Windows.Forms.Button();
            this.button_AddRemoveClass = new System.Windows.Forms.Button();
            this.button_Notification = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.MenuTransition = new System.Windows.Forms.Timer(this.components);
            this.SlidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_ControlBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MenuIcon)).BeginInit();
            this.panel_FormBorderContaienr.SuspendLayout();
            this.Slidebar.SuspendLayout();
            this.ClassContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ControlBoxContainer
            // 
            this.panel_ControlBoxContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_ControlBoxContainer.Controls.Add(this.pictureBox_MenuIcon);
            this.panel_ControlBoxContainer.Controls.Add(this.panel_FormBorderContaienr);
            this.panel_ControlBoxContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBoxContainer.Location = new System.Drawing.Point(3, 3);
            this.panel_ControlBoxContainer.Name = "panel_ControlBoxContainer";
            this.panel_ControlBoxContainer.Size = new System.Drawing.Size(1171, 44);
            this.panel_ControlBoxContainer.TabIndex = 0;
            this.panel_ControlBoxContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox_MenuIcon
            // 
            this.pictureBox_MenuIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_MenuIcon.Image")));
            this.pictureBox_MenuIcon.Location = new System.Drawing.Point(14, 7);
            this.pictureBox_MenuIcon.Name = "pictureBox_MenuIcon";
            this.pictureBox_MenuIcon.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_MenuIcon.TabIndex = 7;
            this.pictureBox_MenuIcon.TabStop = false;
            this.pictureBox_MenuIcon.Click += new System.EventHandler(this.pictureBox_MenuIcon_Click);
            this.pictureBox_MenuIcon.MouseEnter += new System.EventHandler(this.Control_MouseEnterCursor);
            // 
            // panel_FormBorderContaienr
            // 
            this.panel_FormBorderContaienr.Controls.Add(this.button_Close);
            this.panel_FormBorderContaienr.Controls.Add(this.button_Maximize);
            this.panel_FormBorderContaienr.Controls.Add(this.button_Minimize);
            this.panel_FormBorderContaienr.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_FormBorderContaienr.Location = new System.Drawing.Point(973, 0);
            this.panel_FormBorderContaienr.Name = "panel_FormBorderContaienr";
            this.panel_FormBorderContaienr.Size = new System.Drawing.Size(198, 44);
            this.panel_FormBorderContaienr.TabIndex = 2;
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Image = global::QuanLyPhongHoc.Properties.Resources.CloseIcon;
            this.button_Close.Location = new System.Drawing.Point(130, 0);
            this.button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(65, 44);
            this.button_Close.TabIndex = 5;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            this.button_Close.MouseEnter += new System.EventHandler(this.Control_MouseEnter_Close);
            this.button_Close.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // button_Maximize
            // 
            this.button_Maximize.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Maximize.FlatAppearance.BorderSize = 0;
            this.button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maximize.Image = global::QuanLyPhongHoc.Properties.Resources.MaximizeIcon;
            this.button_Maximize.Location = new System.Drawing.Point(65, 0);
            this.button_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Maximize.Name = "button_Maximize";
            this.button_Maximize.Size = new System.Drawing.Size(65, 44);
            this.button_Maximize.TabIndex = 4;
            this.button_Maximize.UseVisualStyleBackColor = true;
            this.button_Maximize.Click += new System.EventHandler(this.button_Maximize_Click);
            this.button_Maximize.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.button_Maximize.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Image = global::QuanLyPhongHoc.Properties.Resources.MinimizeIcon;
            this.button_Minimize.Location = new System.Drawing.Point(0, 0);
            this.button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(65, 44);
            this.button_Minimize.TabIndex = 0;
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            this.button_Minimize.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.button_Minimize.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // Slidebar
            // 
            this.Slidebar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Slidebar.Controls.Add(this.button_Menu);
            this.Slidebar.Controls.Add(this.button_Maintain);
            this.Slidebar.Controls.Add(this.ClassContainer);
            this.Slidebar.Controls.Add(this.button_Notification);
            this.Slidebar.Controls.Add(this.button_Logout);
            this.Slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Slidebar.Location = new System.Drawing.Point(3, 47);
            this.Slidebar.Margin = new System.Windows.Forms.Padding(0);
            this.Slidebar.MaximumSize = new System.Drawing.Size(270, 0);
            this.Slidebar.MinimumSize = new System.Drawing.Size(62, 0);
            this.Slidebar.Name = "Slidebar";
            this.Slidebar.Size = new System.Drawing.Size(62, 570);
            this.Slidebar.TabIndex = 1;
            // 
            // button_Menu
            // 
            this.button_Menu.FlatAppearance.BorderSize = 0;
            this.button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Menu.Image = global::QuanLyPhongHoc.Properties.Resources.MainMenuIcon;
            this.button_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Menu.Location = new System.Drawing.Point(0, 0);
            this.button_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Padding = new System.Windows.Forms.Padding(10, 10, 105, 10);
            this.button_Menu.Size = new System.Drawing.Size(273, 72);
            this.button_Menu.TabIndex = 2;
            this.button_Menu.Text = "Menu";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.button_Menu.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.button_Menu.MouseHover += new System.EventHandler(this.Control_MouseEnterCursor);
            // 
            // button_Maintain
            // 
            this.button_Maintain.FlatAppearance.BorderSize = 0;
            this.button_Maintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Maintain.Image = global::QuanLyPhongHoc.Properties.Resources.MaintainIcon;
            this.button_Maintain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Maintain.Location = new System.Drawing.Point(0, 72);
            this.button_Maintain.Margin = new System.Windows.Forms.Padding(0);
            this.button_Maintain.Name = "button_Maintain";
            this.button_Maintain.Padding = new System.Windows.Forms.Padding(10, 10, 76, 10);
            this.button_Maintain.Size = new System.Drawing.Size(273, 72);
            this.button_Maintain.TabIndex = 3;
            this.button_Maintain.Text = "Quản lý bảo trì";
            this.button_Maintain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Maintain.UseVisualStyleBackColor = true;
            this.button_Maintain.Click += new System.EventHandler(this.button_Maintain_Click);
            this.button_Maintain.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.button_Maintain.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.button_Maintain.MouseHover += new System.EventHandler(this.Control_MouseEnterCursor);
            // 
            // ClassContainer
            // 
            this.ClassContainer.Controls.Add(this.button_ClassAdmin);
            this.ClassContainer.Controls.Add(this.button_ClassList);
            this.ClassContainer.Controls.Add(this.button_AddRemoveClass);
            this.ClassContainer.Location = new System.Drawing.Point(0, 144);
            this.ClassContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ClassContainer.MaximumSize = new System.Drawing.Size(273, 217);
            this.ClassContainer.MinimumSize = new System.Drawing.Size(273, 72);
            this.ClassContainer.Name = "ClassContainer";
            this.ClassContainer.Size = new System.Drawing.Size(273, 72);
            this.ClassContainer.TabIndex = 8;
            // 
            // button_ClassAdmin
            // 
            this.button_ClassAdmin.FlatAppearance.BorderSize = 0;
            this.button_ClassAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClassAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_ClassAdmin.Image = global::QuanLyPhongHoc.Properties.Resources.ClassIcon;
            this.button_ClassAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ClassAdmin.Location = new System.Drawing.Point(0, 0);
            this.button_ClassAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.button_ClassAdmin.Name = "button_ClassAdmin";
            this.button_ClassAdmin.Padding = new System.Windows.Forms.Padding(10, 10, 43, 10);
            this.button_ClassAdmin.Size = new System.Drawing.Size(273, 72);
            this.button_ClassAdmin.TabIndex = 4;
            this.button_ClassAdmin.Text = "Quản lý phòng họp";
            this.button_ClassAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ClassAdmin.UseVisualStyleBackColor = true;
            this.button_ClassAdmin.Click += new System.EventHandler(this.button_Class_Click);
            this.button_ClassAdmin.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.button_ClassAdmin.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.button_ClassAdmin.MouseHover += new System.EventHandler(this.Control_MouseEnterCursor);
            // 
            // button_ClassList
            // 
            this.button_ClassList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ClassList.FlatAppearance.BorderSize = 0;
            this.button_ClassList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_ClassList.Image = global::QuanLyPhongHoc.Properties.Resources.DotIcon;
            this.button_ClassList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ClassList.Location = new System.Drawing.Point(0, 72);
            this.button_ClassList.Margin = new System.Windows.Forms.Padding(0);
            this.button_ClassList.Name = "button_ClassList";
            this.button_ClassList.Padding = new System.Windows.Forms.Padding(15, 10, 18, 10);
            this.button_ClassList.Size = new System.Drawing.Size(273, 72);
            this.button_ClassList.TabIndex = 9;
            this.button_ClassList.Text = "Danh sách phòng học";
            this.button_ClassList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ClassList.UseVisualStyleBackColor = false;
            this.button_ClassList.Click += new System.EventHandler(this.panel_ClassList_Click);
            this.button_ClassList.MouseEnter += new System.EventHandler(this.Control_MouseEnterCursor);
            // 
            // button_AddRemoveClass
            // 
            this.button_AddRemoveClass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_AddRemoveClass.FlatAppearance.BorderSize = 0;
            this.button_AddRemoveClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddRemoveClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_AddRemoveClass.Image = global::QuanLyPhongHoc.Properties.Resources.DotIcon;
            this.button_AddRemoveClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddRemoveClass.Location = new System.Drawing.Point(0, 144);
            this.button_AddRemoveClass.Margin = new System.Windows.Forms.Padding(0);
            this.button_AddRemoveClass.Name = "button_AddRemoveClass";
            this.button_AddRemoveClass.Padding = new System.Windows.Forms.Padding(15, 10, 25, 10);
            this.button_AddRemoveClass.Size = new System.Drawing.Size(273, 72);
            this.button_AddRemoveClass.TabIndex = 10;
            this.button_AddRemoveClass.Text = "Thêm, xóa phòng học";
            this.button_AddRemoveClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddRemoveClass.UseVisualStyleBackColor = false;
            this.button_AddRemoveClass.Click += new System.EventHandler(this.panel_AddRemoveClass_Click);
            this.button_AddRemoveClass.MouseEnter += new System.EventHandler(this.Control_MouseEnterCursor);
            // 
            // button_Notification
            // 
            this.button_Notification.FlatAppearance.BorderSize = 0;
            this.button_Notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Notification.Image = global::QuanLyPhongHoc.Properties.Resources.BellIcon;
            this.button_Notification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Notification.Location = new System.Drawing.Point(0, 216);
            this.button_Notification.Margin = new System.Windows.Forms.Padding(0);
            this.button_Notification.Name = "button_Notification";
            this.button_Notification.Padding = new System.Windows.Forms.Padding(10, 10, 115, 10);
            this.button_Notification.Size = new System.Drawing.Size(273, 72);
            this.button_Notification.TabIndex = 5;
            this.button_Notification.Text = "Thông báo";
            this.button_Notification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Notification.UseVisualStyleBackColor = true;
            this.button_Notification.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.button_Notification.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.button_Notification.MouseHover += new System.EventHandler(this.Control_MouseEnterCursor);
            // 
            // button_Logout
            // 
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Logout.Image = global::QuanLyPhongHoc.Properties.Resources.LogoutIcon;
            this.button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.Location = new System.Drawing.Point(0, 288);
            this.button_Logout.Margin = new System.Windows.Forms.Padding(0);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Padding = new System.Windows.Forms.Padding(10, 10, 115, 10);
            this.button_Logout.Size = new System.Drawing.Size(273, 72);
            this.button_Logout.TabIndex = 6;
            this.button_Logout.Text = "Đăng xuất";
            this.button_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.button_Logout.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.button_Logout.MouseHover += new System.EventHandler(this.Control_MouseEnterCursor);
            // 
            // MenuTransition
            // 
            this.MenuTransition.Interval = 10;
            this.MenuTransition.Tick += new System.EventHandler(this.MenuTransition_Tick);
            // 
            // SlidebarTransition
            // 
            this.SlidebarTransition.Interval = 10;
            this.SlidebarTransition.Tick += new System.EventHandler(this.SlidebarTransition_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1177, 620);
            this.ControlBox = false;
            this.Controls.Add(this.Slidebar);
            this.Controls.Add(this.panel_ControlBoxContainer);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(970, 550);
            this.Name = "frmMenu";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel_ControlBoxContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MenuIcon)).EndInit();
            this.panel_FormBorderContaienr.ResumeLayout(false);
            this.Slidebar.ResumeLayout(false);
            this.ClassContainer.ResumeLayout(false);
            this.ResumeLayout(false);

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