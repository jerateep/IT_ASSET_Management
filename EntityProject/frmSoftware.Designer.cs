namespace EntityProject
{
    partial class frmSoftware
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
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.textRemark = new System.Windows.Forms.TextBox();
            this.textSoftwareName = new System.Windows.Forms.TextBox();
            this.textSoftwareID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rFSSoftwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwarenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareremarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSAssetSoftwareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSSoftwareBindingSource)).BeginInit();
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
            this.softwareidDataGridViewTextBoxColumn,
            this.softwarenameDataGridViewTextBoxColumn,
            this.softwareremarkDataGridViewTextBoxColumn,
            this.rFSAssetSoftwareDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.rFSSoftwareBindingSource;
            this.GridView.Location = new System.Drawing.Point(29, 38);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(470, 268);
            this.GridView.TabIndex = 4;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(344, 440);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 16;
            this.butDelete.Text = "DELETE";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(220, 440);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 15;
            this.butSave.Text = "SAVE";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // textRemark
            // 
            this.textRemark.Location = new System.Drawing.Point(220, 403);
            this.textRemark.Name = "textRemark";
            this.textRemark.Size = new System.Drawing.Size(199, 20);
            this.textRemark.TabIndex = 14;
            // 
            // textSoftwareName
            // 
            this.textSoftwareName.Location = new System.Drawing.Point(220, 371);
            this.textSoftwareName.Name = "textSoftwareName";
            this.textSoftwareName.Size = new System.Drawing.Size(199, 20);
            this.textSoftwareName.TabIndex = 13;
            // 
            // textSoftwareID
            // 
            this.textSoftwareID.Location = new System.Drawing.Point(220, 340);
            this.textSoftwareID.Name = "textSoftwareID";
            this.textSoftwareID.Size = new System.Drawing.Size(199, 20);
            this.textSoftwareID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Software Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Software ID";
            // 
            // rFSSoftwareBindingSource
            // 
            this.rFSSoftwareBindingSource.DataSource = typeof(EntityProject.RFS_Software);
            // 
            // softwareidDataGridViewTextBoxColumn
            // 
            this.softwareidDataGridViewTextBoxColumn.DataPropertyName = "software_id";
            this.softwareidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.softwareidDataGridViewTextBoxColumn.Name = "softwareidDataGridViewTextBoxColumn";
            this.softwareidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // softwarenameDataGridViewTextBoxColumn
            // 
            this.softwarenameDataGridViewTextBoxColumn.DataPropertyName = "software_name";
            this.softwarenameDataGridViewTextBoxColumn.HeaderText = "Software Name";
            this.softwarenameDataGridViewTextBoxColumn.Name = "softwarenameDataGridViewTextBoxColumn";
            this.softwarenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // softwareremarkDataGridViewTextBoxColumn
            // 
            this.softwareremarkDataGridViewTextBoxColumn.DataPropertyName = "software_remark";
            this.softwareremarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.softwareremarkDataGridViewTextBoxColumn.Name = "softwareremarkDataGridViewTextBoxColumn";
            this.softwareremarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rFSAssetSoftwareDataGridViewTextBoxColumn
            // 
            this.rFSAssetSoftwareDataGridViewTextBoxColumn.DataPropertyName = "RFS_Asset_Software";
            this.rFSAssetSoftwareDataGridViewTextBoxColumn.HeaderText = "RFS_Asset_Software";
            this.rFSAssetSoftwareDataGridViewTextBoxColumn.Name = "rFSAssetSoftwareDataGridViewTextBoxColumn";
            this.rFSAssetSoftwareDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFSAssetSoftwareDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 521);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.textRemark);
            this.Controls.Add(this.textSoftwareName);
            this.Controls.Add(this.textSoftwareID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Name = "frmSoftware";
            this.Text = "frmSoftware";
            this.Load += new System.EventHandler(this.frmSoftware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSSoftwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.TextBox textRemark;
        private System.Windows.Forms.TextBox textSoftwareName;
        private System.Windows.Forms.TextBox textSoftwareID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwarenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareremarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFSAssetSoftwareDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rFSSoftwareBindingSource;
    }
}