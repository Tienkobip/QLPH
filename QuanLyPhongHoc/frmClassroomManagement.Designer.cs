using System.Drawing;

namespace QuanLyPhongHoc
{
    partial class frmClassroomManagement
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
            grpClassroomInformation = new System.Windows.Forms.GroupBox();
            cbLocation = new System.Windows.Forms.ComboBox();
            cbStatus = new System.Windows.Forms.ComboBox();
            cbType = new System.Windows.Forms.ComboBox();
            btnExit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            lbType = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtCapacity = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            lbClassroomName = new System.Windows.Forms.Label();
            lbStatus = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lbClassroomId = new System.Windows.Forms.Label();
            dataGridView_ClassroomList = new System.Windows.Forms.DataGridView();
            grpClassroomInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ClassroomList).BeginInit();
            SuspendLayout();
            // 
            // grpClassroomInformation
            // 
            grpClassroomInformation.Controls.Add(cbLocation);
            grpClassroomInformation.Controls.Add(cbStatus);
            grpClassroomInformation.Controls.Add(cbType);
            grpClassroomInformation.Controls.Add(btnExit);
            grpClassroomInformation.Controls.Add(btnCancel);
            grpClassroomInformation.Controls.Add(btnSave);
            grpClassroomInformation.Controls.Add(btnDelete);
            grpClassroomInformation.Controls.Add(btnEdit);
            grpClassroomInformation.Controls.Add(btnNew);
            grpClassroomInformation.Controls.Add(label6);
            grpClassroomInformation.Controls.Add(lbType);
            grpClassroomInformation.Controls.Add(label5);
            grpClassroomInformation.Controls.Add(txtCapacity);
            grpClassroomInformation.Controls.Add(txtName);
            grpClassroomInformation.Controls.Add(lbClassroomName);
            grpClassroomInformation.Controls.Add(lbStatus);
            grpClassroomInformation.Controls.Add(txtId);
            grpClassroomInformation.Controls.Add(lbClassroomId);
            grpClassroomInformation.Dock = System.Windows.Forms.DockStyle.Left;
            grpClassroomInformation.ForeColor = System.Drawing.Color.Blue;
            grpClassroomInformation.Location = new System.Drawing.Point(30, 30);
            grpClassroomInformation.Margin = new System.Windows.Forms.Padding(0);
            grpClassroomInformation.Name = "grpClassroomInformation";
            grpClassroomInformation.Padding = new System.Windows.Forms.Padding(0);
            grpClassroomInformation.Size = new System.Drawing.Size(455, 645);
            grpClassroomInformation.TabIndex = 0;
            grpClassroomInformation.TabStop = false;
            grpClassroomInformation.Text = "Classroom Information";
            // 
            // cbLocation
            // 
            cbLocation.FormattingEnabled = true;
            cbLocation.Location = new System.Drawing.Point(122, 328);
            cbLocation.Name = "cbLocation";
            cbLocation.Size = new System.Drawing.Size(212, 33);
            cbLocation.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new System.Drawing.Point(122, 215);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(212, 33);
            cbStatus.TabIndex = 3;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new System.Drawing.Point(122, 157);
            cbType.Name = "cbType";
            cbType.Size = new System.Drawing.Size(212, 33);
            cbType.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(286, 467);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(113, 49);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(155, 467);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(113, 49);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(286, 403);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(113, 49);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(25, 467);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(113, 49);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(155, 403);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(113, 49);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(25, 403);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(113, 49);
            btnNew.TabIndex = 2;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(21, 327);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 25);
            label6.TabIndex = 0;
            label6.Text = "Location:";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new System.Drawing.Point(21, 153);
            lbType.Name = "lbType";
            lbType.Size = new System.Drawing.Size(63, 25);
            lbType.TabIndex = 0;
            lbType.Text = "Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 270);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 25);
            label5.TabIndex = 0;
            label5.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new System.Drawing.Point(122, 274);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new System.Drawing.Size(212, 30);
            txtCapacity.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(122, 97);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(212, 30);
            txtName.TabIndex = 1;
            // 
            // lbClassroomName
            // 
            lbClassroomName.AutoSize = true;
            lbClassroomName.Location = new System.Drawing.Point(21, 96);
            lbClassroomName.Name = "lbClassroomName";
            lbClassroomName.Size = new System.Drawing.Size(70, 25);
            lbClassroomName.TabIndex = 0;
            lbClassroomName.Text = "Name:";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new System.Drawing.Point(21, 214);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new System.Drawing.Size(74, 25);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "Status:";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(122, 41);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(105, 30);
            txtId.TabIndex = 1;
            // 
            // lbClassroomId
            // 
            lbClassroomId.AutoSize = true;
            lbClassroomId.Location = new System.Drawing.Point(21, 40);
            lbClassroomId.Name = "lbClassroomId";
            lbClassroomId.Size = new System.Drawing.Size(34, 25);
            lbClassroomId.TabIndex = 0;
            lbClassroomId.Text = "Id:";
            // 
            // dataGridView_ClassroomList
            // 
            dataGridView_ClassroomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ClassroomList.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView_ClassroomList.Location = new System.Drawing.Point(485, 30);
            dataGridView_ClassroomList.Name = "dataGridView_ClassroomList";
            dataGridView_ClassroomList.RowHeadersWidth = 51;
            dataGridView_ClassroomList.Size = new System.Drawing.Size(842, 645);
            dataGridView_ClassroomList.TabIndex = 2;
            dataGridView_ClassroomList.SelectionChanged += dataGridView_SelectionChanged;
            dataGridView_ClassroomList.BackgroundColor = Color.White;
            dataGridView_ClassroomList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_ClassroomList.ReadOnly = true;
            dataGridView_ClassroomList.AllowUserToAddRows = false;
            dataGridView_ClassroomList.AllowUserToDeleteRows = false;
            // 
            // frmClassroomManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1357, 705);
            Controls.Add(dataGridView_ClassroomList);
            Controls.Add(grpClassroomInformation);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmClassroomManagement";
            Padding = new System.Windows.Forms.Padding(30);
            Text = "frmClassroomManagement";
            Load += frmClassroomManagement_Load;
            grpClassroomInformation.ResumeLayout(false);
            grpClassroomInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ClassroomList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpClassroomInformation;
        private System.Windows.Forms.Label lbClassroomId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbClassroomName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.DataGridView dataGridView_ClassroomList;
    }
}