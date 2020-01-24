namespace EntityProject
{
    partial class frmModel_m
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
            this.dataGridModelm = new System.Windows.Forms.DataGridView();
            this.modelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewModelmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelID_m = new System.Windows.Forms.TextBox();
            this.txtModelName_m = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbTypeName_m = new System.Windows.Forms.ComboBox();
            this.rFSTypemonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rFSModelAssetmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModelm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSTypemonitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSModelAssetmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridModelm
            // 
            this.dataGridModelm.AutoGenerateColumns = false;
            this.dataGridModelm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModelm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelIDDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn});
            this.dataGridModelm.DataSource = this.viewModelmBindingSource;
            this.dataGridModelm.Location = new System.Drawing.Point(26, 38);
            this.dataGridModelm.Name = "dataGridModelm";
            this.dataGridModelm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridModelm.Size = new System.Drawing.Size(345, 428);
            this.dataGridModelm.TabIndex = 0;
            this.dataGridModelm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridModelm_CellClick);
            this.dataGridModelm.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridModelm_RowPostPaint);
            // 
            // modelIDDataGridViewTextBoxColumn
            // 
            this.modelIDDataGridViewTextBoxColumn.DataPropertyName = "Model_ID";
            this.modelIDDataGridViewTextBoxColumn.HeaderText = "Model_ID";
            this.modelIDDataGridViewTextBoxColumn.Name = "modelIDDataGridViewTextBoxColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "Model_Name";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Model_Name";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "Type_Name";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Type_Name";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // viewModelmBindingSource
            // 
            this.viewModelmBindingSource.DataSource = typeof(EntityProject.viewModel_m);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model ID Monitor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model Name Monitor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type Name Monitor :";
            // 
            // txtModelID_m
            // 
            this.txtModelID_m.Location = new System.Drawing.Point(191, 495);
            this.txtModelID_m.Name = "txtModelID_m";
            this.txtModelID_m.Size = new System.Drawing.Size(139, 20);
            this.txtModelID_m.TabIndex = 4;
            // 
            // txtModelName_m
            // 
            this.txtModelName_m.Location = new System.Drawing.Point(191, 523);
            this.txtModelName_m.Name = "txtModelName_m";
            this.txtModelName_m.Size = new System.Drawing.Size(139, 20);
            this.txtModelName_m.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 595);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(258, 595);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbTypeName_m
            // 
            this.cbTypeName_m.DataSource = this.rFSTypemonitorBindingSource;
            this.cbTypeName_m.DisplayMember = "type_name_m";
            this.cbTypeName_m.FormattingEnabled = true;
            this.cbTypeName_m.Location = new System.Drawing.Point(191, 549);
            this.cbTypeName_m.Name = "cbTypeName_m";
            this.cbTypeName_m.Size = new System.Drawing.Size(139, 21);
            this.cbTypeName_m.TabIndex = 8;
            this.cbTypeName_m.ValueMember = "type_id_m";
            // 
            // rFSTypemonitorBindingSource
            // 
            this.rFSTypemonitorBindingSource.DataSource = typeof(EntityProject.RFS_Type_monitor);
            // 
            // rFSModelAssetmBindingSource
            // 
            this.rFSModelAssetmBindingSource.DataSource = typeof(EntityProject.RFS_Model_Asset_m);
            // 
            // frmModel_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 669);
            this.Controls.Add(this.cbTypeName_m);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtModelName_m);
            this.Controls.Add(this.txtModelID_m);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridModelm);
            this.Name = "frmModel_m";
            this.Text = "frmModel_m";
            this.Load += new System.EventHandler(this.frmModel_m_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModelm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSTypemonitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSModelAssetmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridModelm;
        private System.Windows.Forms.BindingSource rFSModelAssetmBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewModelmBindingSource;
        private System.Windows.Forms.TextBox txtModelID_m;
        private System.Windows.Forms.TextBox txtModelName_m;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbTypeName_m;
        private System.Windows.Forms.BindingSource rFSTypemonitorBindingSource;
    }
}