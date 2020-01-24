namespace EntityProject
{
    partial class frmEmployee
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
            this.cbPosition = new System.Windows.Forms.TextBox();
            this.butdelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.textEnglishName = new System.Windows.Forms.TextBox();
            this.textThaiName = new System.Windows.Forms.TextBox();
            this.textEmployeeID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butExport = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.emidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emnamethDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emnameengDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPosition
            // 
            this.cbPosition.Location = new System.Drawing.Point(385, 522);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(164, 20);
            this.cbPosition.TabIndex = 44;
            // 
            // butdelete
            // 
            this.butdelete.Location = new System.Drawing.Point(845, 526);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(75, 23);
            this.butdelete.TabIndex = 43;
            this.butdelete.Text = "DELETE";
            this.butdelete.UseVisualStyleBackColor = true;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(764, 526);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 42;
            this.butSave.Text = "SAVE";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbLevel.Location = new System.Drawing.Point(764, 451);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(150, 21);
            this.cbLevel.TabIndex = 41;
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(764, 489);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(150, 20);
            this.dateStartDate.TabIndex = 40;
            this.dateStartDate.TabStop = false;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(764, 416);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(150, 21);
            this.cbDepartment.TabIndex = 39;
            // 
            // textEnglishName
            // 
            this.textEnglishName.Location = new System.Drawing.Point(385, 488);
            this.textEnglishName.Name = "textEnglishName";
            this.textEnglishName.Size = new System.Drawing.Size(164, 20);
            this.textEnglishName.TabIndex = 38;
            // 
            // textThaiName
            // 
            this.textThaiName.Location = new System.Drawing.Point(385, 450);
            this.textThaiName.Name = "textThaiName";
            this.textThaiName.Size = new System.Drawing.Size(164, 20);
            this.textThaiName.TabIndex = 37;
            // 
            // textEmployeeID
            // 
            this.textEmployeeID.Location = new System.Drawing.Point(385, 416);
            this.textEmployeeID.Name = "textEmployeeID";
            this.textEmployeeID.Size = new System.Drawing.Size(164, 20);
            this.textEmployeeID.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Start Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(688, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Level :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Department Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Position :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "English Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Thai Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Employee ID :";
            // 
            // butExport
            // 
            this.butExport.Location = new System.Drawing.Point(1018, 8);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(75, 23);
            this.butExport.TabIndex = 45;
            this.butExport.Text = "Export";
            this.butExport.UseVisualStyleBackColor = true;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
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
            this.emidDataGridViewTextBoxColumn,
            this.emnamethDataGridViewTextBoxColumn,
            this.emnameengDataGridViewTextBoxColumn,
            this.depnameDataGridViewTextBoxColumn,
            this.empositionDataGridViewTextBoxColumn,
            this.emlevelDataGridViewTextBoxColumn,
            this.emstartDataGridViewTextBoxColumn,
            this.userupdateDataGridViewTextBoxColumn,
            this.dateupdateDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.viewEmployeeBindingSource;
            this.GridView.Location = new System.Drawing.Point(31, 37);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(1062, 357);
            this.GridView.TabIndex = 46;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // emidDataGridViewTextBoxColumn
            // 
            this.emidDataGridViewTextBoxColumn.DataPropertyName = "em_id";
            this.emidDataGridViewTextBoxColumn.HeaderText = "Emplooyee ID";
            this.emidDataGridViewTextBoxColumn.Name = "emidDataGridViewTextBoxColumn";
            this.emidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emnamethDataGridViewTextBoxColumn
            // 
            this.emnamethDataGridViewTextBoxColumn.DataPropertyName = "em_name_th";
            this.emnamethDataGridViewTextBoxColumn.HeaderText = "Thai Name";
            this.emnamethDataGridViewTextBoxColumn.Name = "emnamethDataGridViewTextBoxColumn";
            this.emnamethDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emnameengDataGridViewTextBoxColumn
            // 
            this.emnameengDataGridViewTextBoxColumn.DataPropertyName = "em_name_eng";
            this.emnameengDataGridViewTextBoxColumn.HeaderText = "English Name";
            this.emnameengDataGridViewTextBoxColumn.Name = "emnameengDataGridViewTextBoxColumn";
            this.emnameengDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depnameDataGridViewTextBoxColumn
            // 
            this.depnameDataGridViewTextBoxColumn.DataPropertyName = "dep_name";
            this.depnameDataGridViewTextBoxColumn.HeaderText = "Department Name";
            this.depnameDataGridViewTextBoxColumn.Name = "depnameDataGridViewTextBoxColumn";
            this.depnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empositionDataGridViewTextBoxColumn
            // 
            this.empositionDataGridViewTextBoxColumn.DataPropertyName = "em_position";
            this.empositionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.empositionDataGridViewTextBoxColumn.Name = "empositionDataGridViewTextBoxColumn";
            this.empositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emlevelDataGridViewTextBoxColumn
            // 
            this.emlevelDataGridViewTextBoxColumn.DataPropertyName = "em_level";
            this.emlevelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.emlevelDataGridViewTextBoxColumn.Name = "emlevelDataGridViewTextBoxColumn";
            this.emlevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emstartDataGridViewTextBoxColumn
            // 
            this.emstartDataGridViewTextBoxColumn.DataPropertyName = "em_start";
            this.emstartDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.emstartDataGridViewTextBoxColumn.Name = "emstartDataGridViewTextBoxColumn";
            this.emstartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userupdateDataGridViewTextBoxColumn
            // 
            this.userupdateDataGridViewTextBoxColumn.DataPropertyName = "user_update";
            this.userupdateDataGridViewTextBoxColumn.HeaderText = "user_update";
            this.userupdateDataGridViewTextBoxColumn.Name = "userupdateDataGridViewTextBoxColumn";
            this.userupdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.userupdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateupdateDataGridViewTextBoxColumn
            // 
            this.dateupdateDataGridViewTextBoxColumn.DataPropertyName = "date_update";
            this.dateupdateDataGridViewTextBoxColumn.HeaderText = "date_update";
            this.dateupdateDataGridViewTextBoxColumn.Name = "dateupdateDataGridViewTextBoxColumn";
            this.dateupdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateupdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewEmployeeBindingSource
            // 
            this.viewEmployeeBindingSource.DataSource = typeof(EntityProject.ViewEmployee);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 562);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.butExport);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.dateStartDate);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.textEnglishName);
            this.Controls.Add(this.textThaiName);
            this.Controls.Add(this.textEmployeeID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cbPosition;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.TextBox textEnglishName;
        private System.Windows.Forms.TextBox textThaiName;
        private System.Windows.Forms.TextBox textEmployeeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.BindingSource viewEmployeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn emidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emnamethDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emnameengDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateupdateDataGridViewTextBoxColumn;
    }
}