namespace EntityProject
{
    partial class frmMonitor
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.lblAsset = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.assetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAssetMonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAssetMonitorBindingSource)).BeginInit();
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
            this.assetIDDataGridViewTextBoxColumn,
            this.monitorIDDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.warrantyDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.modifiedByDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.viewAssetMonitorBindingSource;
            this.GridView.Location = new System.Drawing.Point(47, 76);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(1062, 411);
            this.GridView.TabIndex = 1;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1034, 514);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(852, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(944, 514);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(264, 29);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 48;
            this.btnExcel.Text = " Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(183, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(47, 29);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(130, 20);
            this.txtSearch1.TabIndex = 46;
            // 
            // lblAsset
            // 
            this.lblAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAsset.AutoSize = true;
            this.lblAsset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAsset.Location = new System.Drawing.Point(47, 522);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(45, 15);
            this.lblAsset.TabIndex = 45;
            this.lblAsset.Text = "lblAsset";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(1060, 32);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 13);
            this.lblUser.TabIndex = 49;
            this.lblUser.Text = "lblUser";
            // 
            // assetIDDataGridViewTextBoxColumn
            // 
            this.assetIDDataGridViewTextBoxColumn.DataPropertyName = "Asset_ID";
            this.assetIDDataGridViewTextBoxColumn.HeaderText = "Asset_ID";
            this.assetIDDataGridViewTextBoxColumn.Name = "assetIDDataGridViewTextBoxColumn";
            this.assetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monitorIDDataGridViewTextBoxColumn
            // 
            this.monitorIDDataGridViewTextBoxColumn.DataPropertyName = "Monitor_ID";
            this.monitorIDDataGridViewTextBoxColumn.HeaderText = "Monitor_ID";
            this.monitorIDDataGridViewTextBoxColumn.Name = "monitorIDDataGridViewTextBoxColumn";
            this.monitorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warrantyDataGridViewTextBoxColumn
            // 
            this.warrantyDataGridViewTextBoxColumn.DataPropertyName = "Warranty";
            this.warrantyDataGridViewTextBoxColumn.HeaderText = "Warranty";
            this.warrantyDataGridViewTextBoxColumn.Name = "warrantyDataGridViewTextBoxColumn";
            this.warrantyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifiedByDataGridViewTextBoxColumn
            // 
            this.modifiedByDataGridViewTextBoxColumn.DataPropertyName = "ModifiedBy";
            this.modifiedByDataGridViewTextBoxColumn.HeaderText = "ModifiedBy";
            this.modifiedByDataGridViewTextBoxColumn.Name = "modifiedByDataGridViewTextBoxColumn";
            this.modifiedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateTimeDataGridViewTextBoxColumn
            // 
            this.updateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.HeaderText = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
            this.updateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewAssetMonitorBindingSource
            // 
            this.viewAssetMonitorBindingSource.DataSource = typeof(EntityProject.ViewAssetMonitor);
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 562);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch1);
            this.Controls.Add(this.lblAsset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GridView);
            this.Name = "frmMonitor";
            this.Text = "frmMonitor";
            this.Load += new System.EventHandler(this.frmMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAssetMonitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Label lblAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewAssetMonitorBindingSource;
        private System.Windows.Forms.Label lblUser;
    }
}