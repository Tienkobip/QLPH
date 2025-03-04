using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Diagnostics.SymbolStore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyPhongHoc.MaintainRequestManagement
{
    partial class frmMaintainRequestControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainRequestControl));
            comboBox_entriesComboBox = new ComboBox();
            editColumn = new DataGridViewButtonColumn();
            deleteColumn = new DataGridViewButtonColumn();
            panel_SearchControls = new Panel();
            button_SearchIcon = new Button();
            textBox_SearchBox = new TextBox();
            panel_PaginationPanel = new Panel();
            panel_PaginationContainer = new Panel();
            button_Back = new Button();
            button_Next = new Button();
            label_PageNum = new Label();
            label_PageInfoLabel = new Label();
            label_entriesLabel = new Label();
            button_CreateRequest = new Button();
            button_Edit = new Button();
            button_Remove = new Button();
            dataGridView_Request = new DataGridView();
            panel_ControlsContainer = new Panel();
            panel_EntriesShowContainer = new Panel();
            label_ShowLabel = new Label();
            panel_SearchAndCreate = new Panel();
            panel_SearchControls.SuspendLayout();
            panel_PaginationPanel.SuspendLayout();
            panel_PaginationContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Request).BeginInit();
            panel_ControlsContainer.SuspendLayout();
            panel_EntriesShowContainer.SuspendLayout();
            panel_SearchAndCreate.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_entriesComboBox
            // 
            comboBox_entriesComboBox.Items.AddRange(new object[] { "10", "25", "50", "100" });
            comboBox_entriesComboBox.Location = new Point(64, 12);
            comboBox_entriesComboBox.Name = "comboBox_entriesComboBox";
            comboBox_entriesComboBox.Size = new Size(60, 28);
            comboBox_entriesComboBox.TabIndex = 0;
            // 
            // editColumn
            // 
            editColumn.MinimumWidth = 6;
            editColumn.Name = "editColumn";
            editColumn.Width = 125;
            // 
            // deleteColumn
            // 
            deleteColumn.MinimumWidth = 6;
            deleteColumn.Name = "deleteColumn";
            deleteColumn.Width = 125;
            // 
            // panel_SearchControls
            // 
            panel_SearchControls.Controls.Add(button_SearchIcon);
            panel_SearchControls.Controls.Add(textBox_SearchBox);
            panel_SearchControls.Dock = DockStyle.Left;
            panel_SearchControls.Location = new Point(0, 0);
            panel_SearchControls.Name = "panel_SearchControls";
            panel_SearchControls.Size = new Size(417, 50);
            panel_SearchControls.TabIndex = 0;
            // 
            // button_SearchIcon
            // 
            button_SearchIcon.BackgroundImage = Properties.Resources.SearchIcon;
            button_SearchIcon.BackgroundImageLayout = ImageLayout.Zoom;
            button_SearchIcon.Dock = DockStyle.Left;
            button_SearchIcon.FlatAppearance.BorderSize = 0;
            button_SearchIcon.FlatStyle = FlatStyle.Flat;
            button_SearchIcon.Location = new Point(359, 0);
            button_SearchIcon.Margin = new Padding(0);
            button_SearchIcon.Name = "button_SearchIcon";
            button_SearchIcon.Size = new Size(40, 50);
            button_SearchIcon.TabIndex = 2;
            button_SearchIcon.UseVisualStyleBackColor = true;
            // 
            // textBox_SearchBox
            // 
            textBox_SearchBox.Dock = DockStyle.Left;
            textBox_SearchBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SearchBox.Location = new Point(0, 0);
            textBox_SearchBox.Margin = new Padding(0);
            textBox_SearchBox.Name = "textBox_SearchBox";
            textBox_SearchBox.Size = new Size(359, 38);
            textBox_SearchBox.TabIndex = 1;
            // 
            // panel_PaginationPanel
            // 
            panel_PaginationPanel.Controls.Add(panel_PaginationContainer);
            panel_PaginationPanel.Controls.Add(label_PageInfoLabel);
            panel_PaginationPanel.Dock = DockStyle.Bottom;
            panel_PaginationPanel.Location = new Point(0, 560);
            panel_PaginationPanel.Name = "panel_PaginationPanel";
            panel_PaginationPanel.Size = new Size(900, 40);
            panel_PaginationPanel.TabIndex = 0;
            // 
            // panel_PaginationContainer
            // 
            panel_PaginationContainer.Controls.Add(button_Back);
            panel_PaginationContainer.Controls.Add(button_Next);
            panel_PaginationContainer.Controls.Add(label_PageNum);
            panel_PaginationContainer.Dock = DockStyle.Right;
            panel_PaginationContainer.Location = new Point(650, 0);
            panel_PaginationContainer.Name = "panel_PaginationContainer";
            panel_PaginationContainer.Size = new Size(250, 40);
            panel_PaginationContainer.TabIndex = 3;
            // 
            // button_Back
            // 
            button_Back.AutoSize = true;
            button_Back.BackColor = Color.LightGray;
            button_Back.Dock = DockStyle.Left;
            button_Back.FlatAppearance.BorderSize = 0;
            button_Back.FlatStyle = FlatStyle.Flat;
            button_Back.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Back.Location = new Point(0, 0);
            button_Back.Margin = new Padding(5);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(94, 40);
            button_Back.TabIndex = 1;
            button_Back.Text = "Quay lại";
            button_Back.UseVisualStyleBackColor = false;
            // 
            // button_Next
            // 
            button_Next.AutoSize = true;
            button_Next.Dock = DockStyle.Right;
            button_Next.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Next.Location = new Point(154, 0);
            button_Next.Margin = new Padding(5);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(96, 40);
            button_Next.TabIndex = 0;
            button_Next.Text = "Tiếp theo";
            // 
            // label_PageNum
            // 
            label_PageNum.BackColor = Color.LightGray;
            label_PageNum.Location = new Point(105, 7);
            label_PageNum.Name = "label_PageNum";
            label_PageNum.Size = new Size(40, 30);
            label_PageNum.TabIndex = 1;
            label_PageNum.Text = "1";
            label_PageNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_PageInfoLabel
            // 
            label_PageInfoLabel.AutoSize = true;
            label_PageInfoLabel.Location = new Point(12, 12);
            label_PageInfoLabel.Margin = new Padding(3);
            label_PageInfoLabel.Name = "label_PageInfoLabel";
            label_PageInfoLabel.Size = new Size(186, 20);
            label_PageInfoLabel.TabIndex = 0;
            label_PageInfoLabel.Text = "Showing 1 to 8 of 8 entries";
            // 
            // label_entriesLabel
            // 
            label_entriesLabel.AutoSize = true;
            label_entriesLabel.Location = new Point(133, 15);
            label_entriesLabel.Name = "label_entriesLabel";
            label_entriesLabel.Size = new Size(53, 20);
            label_entriesLabel.TabIndex = 1;
            label_entriesLabel.Text = "entries";
            // 
            // button_CreateRequest
            // 
            button_CreateRequest.BackColor = Color.FromArgb(44, 62, 80);
            button_CreateRequest.Dock = DockStyle.Right;
            button_CreateRequest.FlatStyle = FlatStyle.Flat;
            button_CreateRequest.ForeColor = Color.White;
            button_CreateRequest.Location = new Point(423, 0);
            button_CreateRequest.Name = "button_CreateRequest";
            button_CreateRequest.Size = new Size(182, 50);
            button_CreateRequest.TabIndex = 2;
            button_CreateRequest.Text = "✚ CREATE NEW REQUEST";
            button_CreateRequest.UseVisualStyleBackColor = false;
            button_CreateRequest.Click += button_CreateRequest_Click;
            // 
            // button_Edit
            // 
            button_Edit.BackColor = Color.Lime;
            button_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            button_Edit.FlatAppearance.BorderSize = 0;
            button_Edit.FlatStyle = FlatStyle.Flat;
            button_Edit.Location = new Point(124, 12);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(94, 29);
            button_Edit.TabIndex = 2;
            button_Edit.UseVisualStyleBackColor = false;
            // 
            // button_Remove
            // 
            button_Remove.BackColor = Color.Red;
            button_Remove.BackgroundImage = (Image)resources.GetObject("button_Remove.BackgroundImage");
            button_Remove.BackgroundImageLayout = ImageLayout.Zoom;
            button_Remove.FlatAppearance.BorderSize = 0;
            button_Remove.FlatStyle = FlatStyle.Flat;
            button_Remove.Location = new Point(541, 18);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(94, 29);
            button_Remove.TabIndex = 3;
            button_Remove.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Request
            // 
            dataGridView_Request.AllowUserToAddRows = false;
            dataGridView_Request.AllowUserToDeleteRows = false;
            dataGridView_Request.BackgroundColor = Color.White;
            dataGridView_Request.BorderStyle = BorderStyle.None;
            dataGridView_Request.ColumnHeadersHeight = 29;
            dataGridView_Request.Dock = DockStyle.Fill;
            dataGridView_Request.Location = new Point(0, 70);
            dataGridView_Request.Name = "dataGridView_Request";
            dataGridView_Request.ReadOnly = true;
            dataGridView_Request.RowHeadersVisible = false;
            dataGridView_Request.RowHeadersWidth = 51;
            dataGridView_Request.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Request.Size = new Size(900, 490);
            dataGridView_Request.TabIndex = 2;
            dataGridView_Request.Tag = "dataGridView_Request";
            // 
            // panel_ControlsContainer
            // 
            panel_ControlsContainer.Controls.Add(panel_EntriesShowContainer);
            panel_ControlsContainer.Controls.Add(panel_SearchAndCreate);
            panel_ControlsContainer.Dock = DockStyle.Top;
            panel_ControlsContainer.Location = new Point(0, 0);
            panel_ControlsContainer.Name = "panel_ControlsContainer";
            panel_ControlsContainer.Padding = new Padding(10);
            panel_ControlsContainer.Size = new Size(900, 70);
            panel_ControlsContainer.TabIndex = 1;
            // 
            // panel_EntriesShowContainer
            // 
            panel_EntriesShowContainer.Controls.Add(label_entriesLabel);
            panel_EntriesShowContainer.Controls.Add(label_ShowLabel);
            panel_EntriesShowContainer.Controls.Add(comboBox_entriesComboBox);
            panel_EntriesShowContainer.Dock = DockStyle.Left;
            panel_EntriesShowContainer.Location = new Point(10, 10);
            panel_EntriesShowContainer.Name = "panel_EntriesShowContainer";
            panel_EntriesShowContainer.Size = new Size(250, 50);
            panel_EntriesShowContainer.TabIndex = 2;
            // 
            // label_ShowLabel
            // 
            label_ShowLabel.AutoSize = true;
            label_ShowLabel.Location = new Point(0, 15);
            label_ShowLabel.Margin = new Padding(0);
            label_ShowLabel.Name = "label_ShowLabel";
            label_ShowLabel.Size = new Size(61, 20);
            label_ShowLabel.TabIndex = 0;
            label_ShowLabel.Text = "Hiển thị";
            // 
            // panel_SearchAndCreate
            // 
            panel_SearchAndCreate.Controls.Add(panel_SearchControls);
            panel_SearchAndCreate.Controls.Add(button_CreateRequest);
            panel_SearchAndCreate.Dock = DockStyle.Right;
            panel_SearchAndCreate.Location = new Point(285, 10);
            panel_SearchAndCreate.Name = "panel_SearchAndCreate";
            panel_SearchAndCreate.Size = new Size(605, 50);
            panel_SearchAndCreate.TabIndex = 3;
            // 
            // frmMaintainRequestControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(dataGridView_Request);
            Controls.Add(panel_PaginationPanel);
            Controls.Add(panel_ControlsContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMaintainRequestControl";
            Text = "MaintainRequestControl";
            Load += LoadRequests;
            panel_SearchControls.ResumeLayout(false);
            panel_SearchControls.PerformLayout();
            panel_PaginationPanel.ResumeLayout(false);
            panel_PaginationPanel.PerformLayout();
            panel_PaginationContainer.ResumeLayout(false);
            panel_PaginationContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Request).EndInit();
            panel_ControlsContainer.ResumeLayout(false);
            panel_EntriesShowContainer.ResumeLayout(false);
            panel_EntriesShowContainer.PerformLayout();
            panel_SearchAndCreate.ResumeLayout(false);
            ResumeLayout(false);

        }

        private DataTable RequestTable;
        private void SetupRequestTableColumn()
        {
            RequestTable = new DataTable();

            RequestTable.Columns.Add("ID", typeof(string));
            RequestTable.Columns.Add("User Name", typeof(string));
            RequestTable.Columns.Add("IssuesType", typeof(string));
            RequestTable.Columns.Add("IssueStatus", typeof(string));
            RequestTable.Columns.Add("Edit", typeof(string));
            RequestTable.Columns.Add("Delete", typeof(string));
        }
        private void ConfigureDataGridView()
        {
            dataGridView_Request.DataSource = RequestTable;
            dataGridView_Request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add button columns

            editColumn.Name = "EditButton";
            editColumn.HeaderText = "";
            editColumn.Text = "✎ EDIT";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.FlatStyle = FlatStyle.Flat;
            editColumn.DefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            editColumn.DefaultCellStyle.ForeColor = Color.White;

            deleteColumn.Name = "DeleteButton";
            deleteColumn.HeaderText = "";
            deleteColumn.Text = "🗑 DELETE";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.FlatStyle = FlatStyle.Flat;
            deleteColumn.DefaultCellStyle.BackColor = Color.FromArgb(220, 53, 69);
            deleteColumn.DefaultCellStyle.ForeColor = Color.White;

            dataGridView_Request.Columns.Add(editColumn);
            dataGridView_Request.Columns.Add(deleteColumn);

            dataGridView_Request.Columns["Edit"].Visible = false;
            dataGridView_Request.Columns["Delete"].Visible = false;

        }

        #endregion
        private ComboBox comboBox_entriesComboBox = new ComboBox();
        private Panel panel_ControlsContainer;
        private Panel panel_PaginationPanel;
        private Label label_entriesLabel;
        private Label label_ShowLabel;
        private Label label_PageInfoLabel;
        private Label label_PageNum;
        private Panel panel_SearchControls;
        private Button button_SearchIcon;
        private TextBox textBox_SearchBox;
        private Button button_CreateRequest;
        private Button button_Edit;
        private Button button_Remove;
        private Button button_Back;
        private Button button_Next;
        private DataGridViewButtonColumn editColumn;
        private DataGridViewButtonColumn deleteColumn;
        private DataGridView dataGridView_Request;
        private Panel panel_EntriesShowContainer;
        private Panel panel_SearchAndCreate;
        private Panel panel_PaginationContainer;
    }
}