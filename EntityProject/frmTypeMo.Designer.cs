namespace EntityProject
{
    partial class frmTypeMo
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
            this.datagridTypem = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTypeID_m = new System.Windows.Forms.TextBox();
            this.txtTypeName_m = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rFSTypemonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeidmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenamemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSModelAssetmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTypem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSTypemonitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridTypem
            // 
            this.datagridTypem.AutoGenerateColumns = false;
            this.datagridTypem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTypem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeidmDataGridViewTextBoxColumn,
            this.typenamemDataGridViewTextBoxColumn,
            this.rFSModelAssetmDataGridViewTextBoxColumn});
            this.datagridTypem.DataSource = this.rFSTypemonitorBindingSource;
            this.datagridTypem.Location = new System.Drawing.Point(38, 40);
            this.datagridTypem.Name = "datagridTypem";
            this.datagridTypem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTypem.Size = new System.Drawing.Size(243, 370);
            this.datagridTypem.TabIndex = 0;
            this.datagridTypem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTypeM_CellClick);
            this.datagridTypem.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.datagridTypem_RowPostPaint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // txtTypeID_m
            // 
            this.txtTypeID_m.Location = new System.Drawing.Point(169, 433);
            this.txtTypeID_m.Name = "txtTypeID_m";
            this.txtTypeID_m.Size = new System.Drawing.Size(100, 20);
            this.txtTypeID_m.TabIndex = 3;
            // 
            // txtTypeName_m
            // 
            this.txtTypeName_m.Location = new System.Drawing.Point(169, 463);
            this.txtTypeName_m.Name = "txtTypeName_m";
            this.txtTypeName_m.Size = new System.Drawing.Size(100, 20);
            this.txtTypeName_m.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type ID Monitor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type Name Monitor :";
            // 
            // rFSTypemonitorBindingSource
            // 
            this.rFSTypemonitorBindingSource.DataSource = typeof(EntityProject.RFS_Type_monitor);
            // 
            // typeidmDataGridViewTextBoxColumn
            // 
            this.typeidmDataGridViewTextBoxColumn.DataPropertyName = "type_id_m";
            this.typeidmDataGridViewTextBoxColumn.HeaderText = "Type ID";
            this.typeidmDataGridViewTextBoxColumn.Name = "typeidmDataGridViewTextBoxColumn";
            // 
            // typenamemDataGridViewTextBoxColumn
            // 
            this.typenamemDataGridViewTextBoxColumn.DataPropertyName = "type_name_m";
            this.typenamemDataGridViewTextBoxColumn.HeaderText = "Type Name";
            this.typenamemDataGridViewTextBoxColumn.Name = "typenamemDataGridViewTextBoxColumn";
            // 
            // rFSModelAssetmDataGridViewTextBoxColumn
            // 
            this.rFSModelAssetmDataGridViewTextBoxColumn.DataPropertyName = "RFS_Model_Asset_m";
            this.rFSModelAssetmDataGridViewTextBoxColumn.HeaderText = "RFS_Model_Asset_m";
            this.rFSModelAssetmDataGridViewTextBoxColumn.Name = "rFSModelAssetmDataGridViewTextBoxColumn";
            this.rFSModelAssetmDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmTypeMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeName_m);
            this.Controls.Add(this.txtTypeID_m);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.datagridTypem);
            this.Name = "frmTypeMo";
            this.Text = "frmTypeM";
            this.Load += new System.EventHandler(this.frmTypeMo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTypem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSTypemonitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridTypem;
        private System.Windows.Forms.BindingSource rFSTypemonitorBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTypeID_m;
        private System.Windows.Forms.TextBox txtTypeName_m;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenamemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFSModelAssetmDataGridViewTextBoxColumn;
    }
}