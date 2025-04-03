using System.Drawing;
using System.Windows.Forms;


namespace QuanLyPhongHoc.MaintainRequestManagement
{
    partial class frmRequestAddOrUpdate
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
            panel_TitleContainer = new Panel();
            label_TitlePanel = new Label();
            panel_IssueTypeContainer = new Panel();
            comboBox_IssueType = new ComboBox();
            label_IssueType = new Label();
            panel_ClassroomIDContainer = new Panel();
            label_ClassroomID = new Label();
            textBox_ClassroomID = new TextBox();
            panel_IssueStatus = new Panel();
            comboBox_IssueStatus = new ComboBox();
            label_IssueStatus = new Label();
            flowLayoutPanel_Left = new FlowLayoutPanel();
            lbValidClassroomID = new Label();
            tableLayoutPanel_ = new TableLayoutPanel();
            panel_Right = new Panel();
            lbValidDescription = new Label();
            textBox_Description = new TextBox();
            label_Description = new Label();
            button_CreateNewRequest = new Button();
            button_BackToList = new Button();
            panel_TitleContainer.SuspendLayout();
            panel_IssueTypeContainer.SuspendLayout();
            panel_ClassroomIDContainer.SuspendLayout();
            panel_IssueStatus.SuspendLayout();
            flowLayoutPanel_Left.SuspendLayout();
            tableLayoutPanel_.SuspendLayout();
            panel_Right.SuspendLayout();
            SuspendLayout();
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
            label_TitlePanel.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TitlePanel.ForeColor = Color.White;
            label_TitlePanel.Location = new Point(0, 0);
            label_TitlePanel.Name = "label_TitlePanel";
            label_TitlePanel.Size = new Size(1082, 60);
            label_TitlePanel.TabIndex = 0;
            label_TitlePanel.Text = "THÊM YÊU CẦU";
            label_TitlePanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_IssueTypeContainer
            // 
            panel_IssueTypeContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_IssueTypeContainer.Controls.Add(comboBox_IssueType);
            panel_IssueTypeContainer.Controls.Add(label_IssueType);
            panel_IssueTypeContainer.Location = new Point(10, 130);
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
            label_IssueType.Size = new Size(130, 31);
            label_IssueType.TabIndex = 4;
            label_IssueType.Text = "Loại vấn đề";
            // 
            // panel_ClassroomIDContainer
            // 
            panel_ClassroomIDContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_ClassroomIDContainer.Controls.Add(label_ClassroomID);
            panel_ClassroomIDContainer.Controls.Add(textBox_ClassroomID);
            panel_ClassroomIDContainer.Location = new Point(10, 30);
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
            label_ClassroomID.Size = new Size(152, 31);
            label_ClassroomID.TabIndex = 4;
            label_ClassroomID.Text = "ID phòng học";
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
            panel_IssueStatus.Location = new Point(10, 230);
            panel_IssueStatus.Margin = new Padding(0, 0, 0, 30);
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
            label_IssueStatus.Size = new Size(119, 31);
            label_IssueStatus.TabIndex = 4;
            label_IssueStatus.Text = "Tình trạng";
            // 
            // flowLayoutPanel_Left
            // 
            flowLayoutPanel_Left.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel_Left.Controls.Add(lbValidClassroomID);
            flowLayoutPanel_Left.Controls.Add(panel_ClassroomIDContainer);
            flowLayoutPanel_Left.Controls.Add(panel_IssueTypeContainer);
            flowLayoutPanel_Left.Controls.Add(panel_IssueStatus);
            flowLayoutPanel_Left.Dock = DockStyle.Fill;
            flowLayoutPanel_Left.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Left.Location = new Point(23, 23);
            flowLayoutPanel_Left.Name = "flowLayoutPanel_Left";
            flowLayoutPanel_Left.Padding = new Padding(10);
            flowLayoutPanel_Left.Size = new Size(351, 499);
            flowLayoutPanel_Left.TabIndex = 15;
            // 
            // lbValidClassroomID
            // 
            lbValidClassroomID.AutoSize = true;
            lbValidClassroomID.ForeColor = Color.Red;
            lbValidClassroomID.Location = new Point(13, 10);
            lbValidClassroomID.Name = "lbValidClassroomID";
            lbValidClassroomID.Size = new Size(0, 20);
            lbValidClassroomID.TabIndex = 14;
            // 
            // tableLayoutPanel_
            // 
            tableLayoutPanel_.ColumnCount = 2;
            tableLayoutPanel_.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.2610359F));
            tableLayoutPanel_.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.73896F));
            tableLayoutPanel_.Controls.Add(flowLayoutPanel_Left, 0, 0);
            tableLayoutPanel_.Controls.Add(panel_Right, 1, 0);
            tableLayoutPanel_.Dock = DockStyle.Top;
            tableLayoutPanel_.Location = new Point(0, 60);
            tableLayoutPanel_.Name = "tableLayoutPanel_";
            tableLayoutPanel_.Padding = new Padding(20);
            tableLayoutPanel_.RowCount = 1;
            tableLayoutPanel_.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_.Size = new Size(1082, 545);
            tableLayoutPanel_.TabIndex = 16;
            // 
            // panel_Right
            // 
            panel_Right.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_Right.Controls.Add(lbValidDescription);
            panel_Right.Controls.Add(textBox_Description);
            panel_Right.Controls.Add(label_Description);
            panel_Right.Dock = DockStyle.Fill;
            panel_Right.Location = new Point(377, 20);
            panel_Right.Margin = new Padding(0);
            panel_Right.Name = "panel_Right";
            panel_Right.Size = new Size(685, 505);
            panel_Right.TabIndex = 14;
            // 
            // lbValidDescription
            // 
            lbValidDescription.AutoSize = true;
            lbValidDescription.ForeColor = Color.Red;
            lbValidDescription.Location = new Point(214, 9);
            lbValidDescription.Name = "lbValidDescription";
            lbValidDescription.Size = new Size(0, 20);
            lbValidDescription.TabIndex = 17;
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
            textBox_Description.Size = new Size(685, 474);
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
            label_Description.Size = new Size(188, 31);
            label_Description.TabIndex = 4;
            label_Description.Text = "Thông tin chi tiết";
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
            button_CreateNewRequest.Text = "THÊM ";
            button_CreateNewRequest.UseVisualStyleBackColor = false;
            button_CreateNewRequest.Click += button_CreateOrUpdateRequest_Click;
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
            button_BackToList.Text = "QUAY VỀ";
            button_BackToList.UseVisualStyleBackColor = false;
            button_BackToList.Click += button_BackToList_Click;
            // 
            // frmRequestAddOrUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 751);
            Controls.Add(button_BackToList);
            Controls.Add(button_CreateNewRequest);
            Controls.Add(tableLayoutPanel_);
            Controls.Add(panel_TitleContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRequestAddOrUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMaintainRequestAdd";
            panel_TitleContainer.ResumeLayout(false);
            panel_IssueTypeContainer.ResumeLayout(false);
            panel_IssueTypeContainer.PerformLayout();
            panel_ClassroomIDContainer.ResumeLayout(false);
            panel_ClassroomIDContainer.PerformLayout();
            panel_IssueStatus.ResumeLayout(false);
            panel_IssueStatus.PerformLayout();
            flowLayoutPanel_Left.ResumeLayout(false);
            flowLayoutPanel_Left.PerformLayout();
            tableLayoutPanel_.ResumeLayout(false);
            panel_Right.ResumeLayout(false);
            panel_Right.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_TitleContainer;
        private Label label_TitlePanel;
        private Panel panel_ClassroomIDContainer;
        private Label label_ClassroomID;
        private TextBox textBox_ClassroomID;
        private Panel panel_IssueTypeContainer;
        private Label label_IssueType;
        private ComboBox comboBox_IssueType;
        private Panel panel_IssueStatus;
        private ComboBox comboBox_IssueStatus;
        private Label label_IssueStatus;
        private FlowLayoutPanel flowLayoutPanel_Left;
        private TableLayoutPanel tableLayoutPanel_;
        private Panel panel_Right;
        private TextBox textBox_Description;
        private Label label_Description;
        private Button button_CreateNewRequest;
        private Button button_BackToList;
        private Label lbValidClassroomID;
        private Label lbValidDescription;
    }
}