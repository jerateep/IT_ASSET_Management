namespace EntityProject
{
    partial class frmType
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
            this.butdelete = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.textTypeName = new System.Windows.Forms.TextBox();
            this.textTypeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.rFSTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSModelAssetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butdelete
            // 
            this.butdelete.Location = new System.Drawing.Point(282, 459);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(75, 23);
            this.butdelete.TabIndex = 12;
            this.butdelete.Text = "DELETE";
            this.butdelete.UseVisualStyleBackColor = true;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(201, 459);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(75, 23);
            this.butsave.TabIndex = 11;
            this.butsave.Text = "SAVE";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // textTypeName
            // 
            this.textTypeName.Location = new System.Drawing.Point(201, 396);
            this.textTypeName.Name = "textTypeName";
            this.textTypeName.Size = new System.Drawing.Size(156, 20);
            this.textTypeName.TabIndex = 10;
            // 
            // textTypeID
            // 
            this.textTypeID.Location = new System.Drawing.Point(201, 360);
            this.textTypeID.Name = "textTypeID";
            this.textTypeID.Size = new System.Drawing.Size(156, 20);
            this.textTypeID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tpye ID";
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
            this.typeidDataGridViewTextBoxColumn,
            this.typenameDataGridViewTextBoxColumn,
            this.rFSModelAssetDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.rFSTypeBindingSource;
            this.GridView.Location = new System.Drawing.Point(35, 65);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(470, 268);
            this.GridView.TabIndex = 13;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // rFSTypeBindingSource
            // 
            this.rFSTypeBindingSource.DataSource = typeof(EntityProject.RFS_Type);
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "type_id";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            this.typeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "type_name";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            this.typenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rFSModelAssetDataGridViewTextBoxColumn
            // 
            this.rFSModelAssetDataGridViewTextBoxColumn.DataPropertyName = "RFS_Model_Asset";
            this.rFSModelAssetDataGridViewTextBoxColumn.HeaderText = "RFS_Model_Asset";
            this.rFSModelAssetDataGridViewTextBoxColumn.Name = "rFSModelAssetDataGridViewTextBoxColumn";
            this.rFSModelAssetDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFSModelAssetDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 521);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.textTypeName);
            this.Controls.Add(this.textTypeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmType";
            this.Text = "frmType";
            this.Load += new System.EventHandler(this.frmType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.TextBox textTypeName;
        private System.Windows.Forms.TextBox textTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFSModelAssetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rFSTypeBindingSource;
    }
}