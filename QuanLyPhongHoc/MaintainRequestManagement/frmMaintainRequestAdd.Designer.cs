using System.Drawing;
using System.Windows.Forms;


namespace QuanLyPhongHoc.MaintainRequestManagement
{
    partial class frmMaintainRequestAdd
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
            panel_IDContainer = new Panel();
            label_ID = new Label();
            textBox_ID = new TextBox();
            panel_TitleContainer = new Panel();
            label_TitlePanel = new Label();
            panel_IssueTypeContainer = new Panel();
            comboBox_IssueType = new ComboBox();
            label_IssueType = new Label();
            panel_UserIDContainer = new Panel();
            label_UserID = new Label();
            textBox_UserID = new TextBox();
            panel_ClassroomIDContainer = new Panel();
            label_ClassroomID = new Label();
            textBox_ClassroomID = new TextBox();
            panel_IssueStatus = new Panel();
            comboBox_IssueStatus = new ComboBox();
            label_IssueStatus = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel_ = new TableLayoutPanel();
            panel_DescriptionContainer = new Panel();
            textBox_Description = new TextBox();
            label_Description = new Label();
            button_CreateNewRequest = new Button();
            button_BackToList = new Button();
            panel_IDContainer.SuspendLayout();
            panel_TitleContainer.SuspendLayout();
            panel_IssueTypeContainer.SuspendLayout();
            panel_UserIDContainer.SuspendLayout();
            panel_ClassroomIDContainer.SuspendLayout();
            panel_IssueStatus.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel_.SuspendLayout();
            panel_DescriptionContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel_IDContainer
            // 
            panel_IDContainer.Controls.Add(label_ID);
            panel_IDContainer.Controls.Add(textBox_ID);
            panel_IDContainer.Location = new Point(10, 10);
            panel_IDContainer.Margin = new Padding(0, 0, 0, 30);
            panel_IDContainer.Name = "panel_IDContainer";
            panel_IDContainer.Size = new Size(250, 70);
            panel_IDContainer.TabIndex = 7;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Dock = DockStyle.Top;
            label_ID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ID.Location = new Point(0, 0);
            label_ID.Margin = new Padding(0);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(36, 31);
            label_ID.TabIndex = 4;
            label_ID.Text = "ID";
            // 
            // textBox_ID
            // 
            textBox_ID.Dock = DockStyle.Bottom;
            textBox_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ID.Location = new Point(0, 36);
            textBox_ID.Margin = new Padding(0);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(250, 34);
            textBox_ID.TabIndex = 0;
            // 
            // panel_TitleContainer
            // 
            panel_TitleContainer.BackColor = Color.FromArgb(73, 99, 111);
            panel_TitleContainer.Controls.Add(label_TitlePanel);
            panel_TitleContainer.Dock = DockStyle.Top;
            panel_TitleContainer.Location = new Point(0, 0);
            panel_TitleContainer.Name = "panel_TitleContainer";
            panel_TitleContainer.Size = new Size(1082, 60);
            panel_TitleContainer.TabIndex = 8;
            // 
            // label_TitlePanel
            // 
            label_TitlePanel.Dock = DockStyle.Fill;
            label_TitlePanel.Font = new Font("Arial", 16F);
            label_TitlePanel.ForeColor = Color.White;
            label_TitlePanel.Location = new Point(0, 0);
            label_TitlePanel.Name = "label_TitlePanel";
            label_TitlePanel.Size = new Size(1082, 60);
            label_TitlePanel.TabIndex = 0;
            label_TitlePanel.Text = "Thêm Request";
            label_TitlePanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_IssueTypeContainer
            // 
            panel_IssueTypeContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_IssueTypeContainer.Controls.Add(comboBox_IssueType);
            panel_IssueTypeContainer.Controls.Add(label_IssueType);
            panel_IssueTypeContainer.Location = new Point(10, 310);
            panel_IssueTypeContainer.Margin = new Padding(0, 0, 0, 30);
            panel_IssueTypeContainer.Name = "panel_IssueTypeContainer";
            panel_IssueTypeContainer.Size = new Size(250, 70);
            panel_IssueTypeContainer.TabIndex = 11;
            // 
            // comboBox_IssueType
            // 
            comboBox_IssueType.Dock = DockStyle.Bottom;
            comboBox_IssueType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_IssueType.FormattingEnabled = true;
            comboBox_IssueType.Location = new Point(0, 34);
            comboBox_IssueType.Name = "comboBox_IssueType";
            comboBox_IssueType.Size = new Size(250, 36);
            comboBox_IssueType.TabIndex = 13;
            // 
            // label_IssueType
            // 
            label_IssueType.AutoSize = true;
            label_IssueType.Dock = DockStyle.Top;
            label_IssueType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_IssueType.Location = new Point(0, 0);
            label_IssueType.Margin = new Padding(0);
            label_IssueType.Name = "label_IssueType";
            label_IssueType.Size = new Size(119, 31);
            label_IssueType.TabIndex = 4;
            label_IssueType.Text = "Issue Type";
            // 
            // panel_UserIDContainer
            // 
            panel_UserIDContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_UserIDContainer.Controls.Add(label_UserID);
            panel_UserIDContainer.Controls.Add(textBox_UserID);
            panel_UserIDContainer.Location = new Point(10, 110);
            panel_UserIDContainer.Margin = new Padding(0, 0, 0, 30);
            panel_UserIDContainer.Name = "panel_UserIDContainer";
            panel_UserIDContainer.Size = new Size(250, 70);
            panel_UserIDContainer.TabIndex = 9;
            // 
            // label_UserID
            // 
            label_UserID.AutoSize = true;
            label_UserID.Dock = DockStyle.Top;
            label_UserID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_UserID.Location = new Point(0, 0);
            label_UserID.Margin = new Padding(0);
            label_UserID.Name = "label_UserID";
            label_UserID.Size = new Size(88, 31);
            label_UserID.TabIndex = 4;
            label_UserID.Text = "User ID";
            // 
            // textBox_UserID
            // 
            textBox_UserID.Dock = DockStyle.Bottom;
            textBox_UserID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_UserID.Location = new Point(0, 36);
            textBox_UserID.Margin = new Padding(0);
            textBox_UserID.Name = "textBox_UserID";
            textBox_UserID.Size = new Size(250, 34);
            textBox_UserID.TabIndex = 0;
            // 
            // panel_ClassroomIDContainer
            // 
            panel_ClassroomIDContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_ClassroomIDContainer.Controls.Add(label_ClassroomID);
            panel_ClassroomIDContainer.Controls.Add(textBox_ClassroomID);
            panel_ClassroomIDContainer.Location = new Point(10, 210);
            panel_ClassroomIDContainer.Margin = new Padding(0, 0, 0, 30);
            panel_ClassroomIDContainer.Name = "panel_ClassroomIDContainer";
            panel_ClassroomIDContainer.Size = new Size(250, 70);
            panel_ClassroomIDContainer.TabIndex = 10;
            // 
            // label_ClassroomID
            // 
            label_ClassroomID.AutoSize = true;
            label_ClassroomID.Dock = DockStyle.Top;
            label_ClassroomID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ClassroomID.Location = new Point(0, 0);
            label_ClassroomID.Margin = new Padding(0);
            label_ClassroomID.Name = "label_ClassroomID";
            label_ClassroomID.Size = new Size(148, 31);
            label_ClassroomID.TabIndex = 4;
            label_ClassroomID.Text = "Classroom ID";
            // 
            // textBox_ClassroomID
            // 
            textBox_ClassroomID.Dock = DockStyle.Bottom;
            textBox_ClassroomID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ClassroomID.Location = new Point(0, 36);
            textBox_ClassroomID.Margin = new Padding(0);
            textBox_ClassroomID.Name = "textBox_ClassroomID";
            textBox_ClassroomID.Size = new Size(250, 34);
            textBox_ClassroomID.TabIndex = 0;
            // 
            // panel_IssueStatus
            // 
            panel_IssueStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_IssueStatus.Controls.Add(comboBox_IssueStatus);
            panel_IssueStatus.Controls.Add(label_IssueStatus);
            panel_IssueStatus.Location = new Point(10, 410);
            panel_IssueStatus.Margin = new Padding(0);
            panel_IssueStatus.Name = "panel_IssueStatus";
            panel_IssueStatus.Size = new Size(250, 70);
            panel_IssueStatus.TabIndex = 12;
            // 
            // comboBox_IssueStatus
            // 
            comboBox_IssueStatus.Dock = DockStyle.Bottom;
            comboBox_IssueStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_IssueStatus.FormattingEnabled = true;
            comboBox_IssueStatus.Location = new Point(0, 34);
            comboBox_IssueStatus.Name = "comboBox_IssueStatus";
            comboBox_IssueStatus.Size = new Size(250, 36);
            comboBox_IssueStatus.TabIndex = 13;
            // 
            // label_IssueStatus
            // 
            label_IssueStatus.AutoSize = true;
            label_IssueStatus.Dock = DockStyle.Top;
            label_IssueStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_IssueStatus.Location = new Point(0, 0);
            label_IssueStatus.Margin = new Padding(0);
            label_IssueStatus.Name = "label_IssueStatus";
            label_IssueStatus.Size = new Size(133, 31);
            label_IssueStatus.TabIndex = 4;
            label_IssueStatus.Text = "Issue Status";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(panel_IDContainer);
            flowLayoutPanel1.Controls.Add(panel_UserIDContainer);
            flowLayoutPanel1.Controls.Add(panel_ClassroomIDContainer);
            flowLayoutPanel1.Controls.Add(panel_IssueTypeContainer);
            flowLayoutPanel1.Controls.Add(panel_IssueStatus);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(23, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(351, 499);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel_
            // 
            tableLayoutPanel_.ColumnCount = 2;
            tableLayoutPanel_.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.2610359F));
            tableLayoutPanel_.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.73896F));
            tableLayoutPanel_.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel_.Controls.Add(panel_DescriptionContainer, 1, 0);
            tableLayoutPanel_.Dock = DockStyle.Top;
            tableLayoutPanel_.Location = new Point(0, 60);
            tableLayoutPanel_.Name = "tableLayoutPanel_";
            tableLayoutPanel_.Padding = new Padding(20);
            tableLayoutPanel_.RowCount = 1;
            tableLayoutPanel_.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_.Size = new Size(1082, 545);
            tableLayoutPanel_.TabIndex = 16;
            // 
            // panel_DescriptionContainer
            // 
            panel_DescriptionContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_DescriptionContainer.Controls.Add(textBox_Description);
            panel_DescriptionContainer.Controls.Add(label_Description);
            panel_DescriptionContainer.Dock = DockStyle.Fill;
            panel_DescriptionContainer.Location = new Point(377, 20);
            panel_DescriptionContainer.Margin = new Padding(0, 0, 0, 30);
            panel_DescriptionContainer.Name = "panel_DescriptionContainer";
            panel_DescriptionContainer.Size = new Size(685, 475);
            panel_DescriptionContainer.TabIndex = 14;
            // 
            // textBox_Description
            // 
            textBox_Description.Dock = DockStyle.Fill;
            textBox_Description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Description.Location = new Point(0, 31);
            textBox_Description.Margin = new Padding(0);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.ScrollBars = ScrollBars.Vertical;
            textBox_Description.Size = new Size(685, 444);
            textBox_Description.TabIndex = 14;
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Dock = DockStyle.Top;
            label_Description.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Description.Location = new Point(0, 0);
            label_Description.Margin = new Padding(0);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(131, 31);
            label_Description.TabIndex = 4;
            label_Description.Text = "Description";
            // 
            // button_CreateNewRequest
            // 
            button_CreateNewRequest.BackColor = Color.FromArgb(44, 62, 80);
            button_CreateNewRequest.FlatStyle = FlatStyle.Flat;
            button_CreateNewRequest.ForeColor = Color.White;
            button_CreateNewRequest.Location = new Point(23, 634);
            button_CreateNewRequest.Name = "button_CreateNewRequest";
            button_CreateNewRequest.Size = new Size(182, 63);
            button_CreateNewRequest.TabIndex = 20;
            button_CreateNewRequest.Text = "CREATE";
            button_CreateNewRequest.UseVisualStyleBackColor = false;
            // 
            // button_BackToList
            // 
            button_BackToList.BackColor = Color.AntiqueWhite;
            button_BackToList.FlatStyle = FlatStyle.Flat;
            button_BackToList.ForeColor = Color.Black;
            button_BackToList.Location = new Point(230, 634);
            button_BackToList.Name = "button_BackToList";
            button_BackToList.Size = new Size(182, 63);
            button_BackToList.TabIndex = 21;
            button_BackToList.Text = "BACK TO LIST";
            button_BackToList.UseVisualStyleBackColor = false;
            button_BackToList.Click += button_BackToList_Click;
            // 
            // frmMaintainRequestAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 751);
            Controls.Add(button_BackToList);
            Controls.Add(button_CreateNewRequest);
            Controls.Add(tableLayoutPanel_);
            Controls.Add(panel_TitleContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMaintainRequestAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMaintainRequestAdd";
            panel_IDContainer.ResumeLayout(false);
            panel_IDContainer.PerformLayout();
            panel_TitleContainer.ResumeLayout(false);
            panel_IssueTypeContainer.ResumeLayout(false);
            panel_IssueTypeContainer.PerformLayout();
            panel_UserIDContainer.ResumeLayout(false);
            panel_UserIDContainer.PerformLayout();
            panel_ClassroomIDContainer.ResumeLayout(false);
            panel_ClassroomIDContainer.PerformLayout();
            panel_IssueStatus.ResumeLayout(false);
            panel_IssueStatus.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel_.ResumeLayout(false);
            panel_DescriptionContainer.ResumeLayout(false);
            panel_DescriptionContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_IDContainer;
        private Panel panel_TitleContainer;
        private Label label_TitlePanel;
        private Label label_ID;
        private TextBox textBox_ID;
        private Panel panel_UserIDContainer;
        private Label label_UserID;
        private TextBox textBox_UserID;
        private Panel panel_ClassroomIDContainer;
        private Label label_ClassroomID;
        private TextBox textBox_ClassroomID;
        private Panel panel_IssueTypeContainer;
        private Label label_IssueType;
        private ComboBox comboBox_IssueType;
        private Panel panel_IssueStatus;
        private ComboBox comboBox_IssueStatus;
        private Label label_IssueStatus;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel_;
        private Panel panel_DescriptionContainer;
        private TextBox textBox_Description;
        private Label label_Description;
        private Button button_CreateNewRequest;
        private Button button_BackToList;
    }
}