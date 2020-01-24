namespace EntityProject
{
    partial class frmDepart
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.rFSDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butDelete = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.textDepartmentName = new System.Windows.Forms.TextBox();
            this.textDepartmentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depfloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView.AutoGenerateColumns = false;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depidDataGridViewTextBoxColumn,
            this.depnameDataGridViewTextBoxColumn,
            this.depfloorDataGridViewTextBoxColumn,
            this.rFSEmployeeDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.rFSDepartmentBindingSource;
            this.GridView.Location = new System.Drawing.Point(31, 36);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(470, 268);
            this.GridView.TabIndex = 1;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // rFSDepartmentBindingSource
            // 
            this.rFSDepartmentBindingSource.DataSource = typeof(EntityProject.RFS_Department);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(337, 463);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 16;
            this.butDelete.Text = "DELETE";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(253, 463);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(75, 23);
            this.butsave.TabIndex = 15;
            this.butsave.Text = "SAVE";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
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
            this.cbFloor.Location = new System.Drawing.Point(253, 409);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(159, 21);
            this.cbFloor.TabIndex = 14;
            // 
            // textDepartmentName
            // 
            this.textDepartmentName.Location = new System.Drawing.Point(253, 375);
            this.textDepartmentName.Name = "textDepartmentName";
            this.textDepartmentName.Size = new System.Drawing.Size(159, 20);
            this.textDepartmentName.TabIndex = 13;
            // 
            // textDepartmentID
            // 
            this.textDepartmentID.Location = new System.Drawing.Point(253, 343);
            this.textDepartmentID.Name = "textDepartmentID";
            this.textDepartmentID.Size = new System.Drawing.Size(159, 20);
            this.textDepartmentID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Floor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Department Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Department ID :";
            // 
            // depidDataGridViewTextBoxColumn
            // 
            this.depidDataGridViewTextBoxColumn.DataPropertyName = "dep_id";
            this.depidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.depidDataGridViewTextBoxColumn.Name = "depidDataGridViewTextBoxColumn";
            this.depidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depnameDataGridViewTextBoxColumn
            // 
            this.depnameDataGridViewTextBoxColumn.DataPropertyName = "dep_name";
            this.depnameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.depnameDataGridViewTextBoxColumn.Name = "depnameDataGridViewTextBoxColumn";
            this.depnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depfloorDataGridViewTextBoxColumn
            // 
            this.depfloorDataGridViewTextBoxColumn.DataPropertyName = "dep_floor";
            this.depfloorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.depfloorDataGridViewTextBoxColumn.Name = "depfloorDataGridViewTextBoxColumn";
            this.depfloorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rFSEmployeeDataGridViewTextBoxColumn
            // 
            this.rFSEmployeeDataGridViewTextBoxColumn.DataPropertyName = "RFS_Employee";
            this.rFSEmployeeDataGridViewTextBoxColumn.HeaderText = "RFS_Employee";
            this.rFSEmployeeDataGridViewTextBoxColumn.Name = "rFSEmployeeDataGridViewTextBoxColumn";
            this.rFSEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFSEmployeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 521);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.textDepartmentName);
            this.Controls.Add(this.textDepartmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Name = "frmDepart";
            this.Text = "frmDepart";
            this.Load += new System.EventHandler(this.frmDepart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.BindingSource rFSDepartmentBindingSource;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.TextBox textDepartmentName;
        private System.Windows.Forms.TextBox textDepartmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn depidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depfloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFSEmployeeDataGridViewTextBoxColumn;
    }
}