namespace EntityProject
{
    partial class frmDepartment
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
            this.GridDepartment = new System.Windows.Forms.DataGridView();
            this.depidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depfloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDepartmentID = new System.Windows.Forms.TextBox();
            this.textDepartmentName = new System.Windows.Forms.TextBox();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.butsave = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDepartment
            // 
            this.GridDepartment.AutoGenerateColumns = false;
            this.GridDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depidDataGridViewTextBoxColumn,
            this.depnameDataGridViewTextBoxColumn,
            this.depfloorDataGridViewTextBoxColumn,
            this.rFSEmployeeDataGridViewTextBoxColumn});
            this.GridDepartment.DataSource = this.rFSDepartmentBindingSource;
            this.GridDepartment.Location = new System.Drawing.Point(27, 25);
            this.GridDepartment.Name = "GridDepartment";
            this.GridDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDepartment.Size = new System.Drawing.Size(345, 428);
            this.GridDepartment.TabIndex = 0;
            this.GridDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDepartment_CellClick);
            this.GridDepartment.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridDepartment_RowPostPaint);
            // 
            // depidDataGridViewTextBoxColumn
            // 
            this.depidDataGridViewTextBoxColumn.DataPropertyName = "dep_id";
            this.depidDataGridViewTextBoxColumn.HeaderText = "Department ID";
            this.depidDataGridViewTextBoxColumn.Name = "depidDataGridViewTextBoxColumn";
            // 
            // depnameDataGridViewTextBoxColumn
            // 
            this.depnameDataGridViewTextBoxColumn.DataPropertyName = "dep_name";
            this.depnameDataGridViewTextBoxColumn.HeaderText = "Department Name";
            this.depnameDataGridViewTextBoxColumn.Name = "depnameDataGridViewTextBoxColumn";
            // 
            // depfloorDataGridViewTextBoxColumn
            // 
            this.depfloorDataGridViewTextBoxColumn.DataPropertyName = "dep_floor";
            this.depfloorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.depfloorDataGridViewTextBoxColumn.Name = "depfloorDataGridViewTextBoxColumn";
            // 
            // rFSEmployeeDataGridViewTextBoxColumn
            // 
            this.rFSEmployeeDataGridViewTextBoxColumn.DataPropertyName = "RFS_Employee";
            this.rFSEmployeeDataGridViewTextBoxColumn.HeaderText = "RFS_Employee";
            this.rFSEmployeeDataGridViewTextBoxColumn.Name = "rFSEmployeeDataGridViewTextBoxColumn";
            this.rFSEmployeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // rFSDepartmentBindingSource
            // 
            this.rFSDepartmentBindingSource.DataSource = typeof(EntityProject.RFS_Department);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Floor :";
            // 
            // textDepartmentID
            // 
            this.textDepartmentID.Location = new System.Drawing.Point(166, 482);
            this.textDepartmentID.Name = "textDepartmentID";
            this.textDepartmentID.Size = new System.Drawing.Size(159, 20);
            this.textDepartmentID.TabIndex = 4;
            // 
            // textDepartmentName
            // 
            this.textDepartmentName.Location = new System.Drawing.Point(166, 521);
            this.textDepartmentName.Name = "textDepartmentName";
            this.textDepartmentName.Size = new System.Drawing.Size(159, 20);
            this.textDepartmentName.TabIndex = 5;
            // 
            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "B3",
            "B2",
            "B1",
            "FL.1",
            "FL.2",
            "FL.3",
            "FL.4",
            "FL.5",
            "FL.6",
            "FL.7",
            "FL.8",
            "FL.9"});
            this.cbFloor.Location = new System.Drawing.Point(166, 556);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(159, 21);
            this.cbFloor.TabIndex = 6;
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(144, 602);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(75, 23);
            this.butsave.TabIndex = 7;
            this.butsave.Text = "SAVE";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(250, 602);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 8;
            this.butDelete.Text = "DELETE";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 669);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.textDepartmentName);
            this.Controls.Add(this.textDepartmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridDepartment);
            this.MaximumSize = new System.Drawing.Size(416, 708);
            this.MinimumSize = new System.Drawing.Size(416, 708);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn depidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depfloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFSEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rFSDepartmentBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDepartmentID;
        private System.Windows.Forms.TextBox textDepartmentName;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button butDelete;
    }
}