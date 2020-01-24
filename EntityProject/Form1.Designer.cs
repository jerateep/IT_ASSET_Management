namespace EntityProject
{
    partial class frmMain
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
            this.lblAsset = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.TabCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.TabEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.TabDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.TabLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.TabSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.TabInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.TabType = new System.Windows.Forms.ToolStripMenuItem();
            this.TabTypeMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.TabModel = new System.Windows.Forms.ToolStripMenuItem();
            this.TabModelMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.TabSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.TabMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.assetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rFSAssetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSAssetBindingSource)).BeginInit();
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
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetIDDataGridViewTextBoxColumn,
            this.serviceTagDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.monitorDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.warrantyDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.modifiedByDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.vallBindingSource;
            this.GridView.Location = new System.Drawing.Point(48, 73);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(1062, 424);
            this.GridView.TabIndex = 0;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // lblAsset
            // 
            this.lblAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAsset.AutoSize = true;
            this.lblAsset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAsset.Location = new System.Drawing.Point(48, 521);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(45, 15);
            this.lblAsset.TabIndex = 1;
            this.lblAsset.Text = "lblAsset";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(873, 513);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(954, 513);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1035, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(48, 37);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(130, 20);
            this.txtSearch1.TabIndex = 5;
            this.txtSearch1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch1_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(184, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(265, 34);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = " Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabCompany,
            this.TabInventory});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1162, 24);
            this.mainMenu.TabIndex = 8;
            this.mainMenu.Text = "mainMenu";
            // 
            // TabCompany
            // 
            this.TabCompany.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabEmployee,
            this.TabDepartment,
            this.TabLocation,
            this.TabSupplier});
            this.TabCompany.Name = "TabCompany";
            this.TabCompany.Size = new System.Drawing.Size(71, 20);
            this.TabCompany.Text = "Company";
            // 
            // TabEmployee
            // 
            this.TabEmployee.Name = "TabEmployee";
            this.TabEmployee.Size = new System.Drawing.Size(137, 22);
            this.TabEmployee.Text = "Employee";
            this.TabEmployee.Click += new System.EventHandler(this.TabEmployee_Click);
            // 
            // TabDepartment
            // 
            this.TabDepartment.Name = "TabDepartment";
            this.TabDepartment.Size = new System.Drawing.Size(137, 22);
            this.TabDepartment.Text = "Department";
            this.TabDepartment.Click += new System.EventHandler(this.TabDepartment_Click);
            // 
            // TabLocation
            // 
            this.TabLocation.Name = "TabLocation";
            this.TabLocation.Size = new System.Drawing.Size(137, 22);
            this.TabLocation.Text = "Location";
            this.TabLocation.Click += new System.EventHandler(this.TabLocation_Click);
            // 
            // TabSupplier
            // 
            this.TabSupplier.Name = "TabSupplier";
            this.TabSupplier.Size = new System.Drawing.Size(137, 22);
            this.TabSupplier.Text = "Supplier";
            this.TabSupplier.Click += new System.EventHandler(this.TabSupplier_Click);
            // 
            // TabInventory
            // 
            this.TabInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabType,
            this.TabTypeMonitor,
            this.TabModel,
            this.TabModelMonitor,
            this.TabSoftware,
            this.TabMonitor});
            this.TabInventory.Name = "TabInventory";
            this.TabInventory.Size = new System.Drawing.Size(100, 20);
            this.TabInventory.Text = "Inventory Mng.";
            // 
            // TabType
            // 
            this.TabType.Name = "TabType";
            this.TabType.Size = new System.Drawing.Size(154, 22);
            this.TabType.Text = "Type";
            this.TabType.Click += new System.EventHandler(this.TabType_Click);
            // 
            // TabTypeMonitor
            // 
            this.TabTypeMonitor.Name = "TabTypeMonitor";
            this.TabTypeMonitor.Size = new System.Drawing.Size(154, 22);
            this.TabTypeMonitor.Text = "Type Monitor";
            this.TabTypeMonitor.Click += new System.EventHandler(this.TabTypeMonitor_Click);
            // 
            // TabModel
            // 
            this.TabModel.Name = "TabModel";
            this.TabModel.Size = new System.Drawing.Size(154, 22);
            this.TabModel.Text = "Model";
            this.TabModel.Click += new System.EventHandler(this.TabModel_Click);
            // 
            // TabModelMonitor
            // 
            this.TabModelMonitor.Name = "TabModelMonitor";
            this.TabModelMonitor.Size = new System.Drawing.Size(154, 22);
            this.TabModelMonitor.Text = "Model Monitor";
            this.TabModelMonitor.Click += new System.EventHandler(this.TabModelMonitor_Click);
            // 
            // TabSoftware
            // 
            this.TabSoftware.Name = "TabSoftware";
            this.TabSoftware.Size = new System.Drawing.Size(154, 22);
            this.TabSoftware.Text = "Software";
            this.TabSoftware.Click += new System.EventHandler(this.TabSoftware_Click);
            // 
            // TabMonitor
            // 
            this.TabMonitor.Name = "TabMonitor";
            this.TabMonitor.Size = new System.Drawing.Size(154, 22);
            this.TabMonitor.Text = "Monitor Mng.";
            this.TabMonitor.Click += new System.EventHandler(this.TabMonitor_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(1071, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "lblUser";
            // 
            // assetIDDataGridViewTextBoxColumn
            // 
            this.assetIDDataGridViewTextBoxColumn.DataPropertyName = "AssetID";
            this.assetIDDataGridViewTextBoxColumn.HeaderText = "Asset ID";
            this.assetIDDataGridViewTextBoxColumn.Name = "assetIDDataGridViewTextBoxColumn";
            this.assetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceTagDataGridViewTextBoxColumn
            // 
            this.serviceTagDataGridViewTextBoxColumn.DataPropertyName = "Service_Tag";
            this.serviceTagDataGridViewTextBoxColumn.HeaderText = "Service Tag";
            this.serviceTagDataGridViewTextBoxColumn.Name = "serviceTagDataGridViewTextBoxColumn";
            this.serviceTagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "Spec";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monitorDataGridViewTextBoxColumn
            // 
            this.monitorDataGridViewTextBoxColumn.DataPropertyName = "Monitor";
            this.monitorDataGridViewTextBoxColumn.HeaderText = "Monitor";
            this.monitorDataGridViewTextBoxColumn.Name = "monitorDataGridViewTextBoxColumn";
            this.monitorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            this.iPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warrantyDataGridViewTextBoxColumn
            // 
            this.warrantyDataGridViewTextBoxColumn.DataPropertyName = "Warranty";
            this.warrantyDataGridViewTextBoxColumn.HeaderText = "Warranty";
            this.warrantyDataGridViewTextBoxColumn.Name = "warrantyDataGridViewTextBoxColumn";
            this.warrantyDataGridViewTextBoxColumn.ReadOnly = true;
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
            // vallBindingSource
            // 
            this.vallBindingSource.DataSource = typeof(EntityProject.ViewAllData);
            // 
            // rFSAssetBindingSource
            // 
            this.rFSAssetBindingSource.DataSource = typeof(EntityProject.RFS_Asset);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 562);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAsset);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSAssetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.BindingSource vallBindingSource;
        private System.Windows.Forms.BindingSource rFSAssetBindingSource;
        private System.Windows.Forms.Label lblAsset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem TabCompany;
        private System.Windows.Forms.ToolStripMenuItem TabEmployee;
        private System.Windows.Forms.ToolStripMenuItem TabDepartment;
        private System.Windows.Forms.ToolStripMenuItem TabLocation;
        private System.Windows.Forms.ToolStripMenuItem TabSupplier;
        private System.Windows.Forms.ToolStripMenuItem TabInventory;
        private System.Windows.Forms.ToolStripMenuItem TabType;
        private System.Windows.Forms.ToolStripMenuItem TabTypeMonitor;
        private System.Windows.Forms.ToolStripMenuItem TabModel;
        private System.Windows.Forms.ToolStripMenuItem TabModelMonitor;
        private System.Windows.Forms.ToolStripMenuItem TabSoftware;
        private System.Windows.Forms.ToolStripMenuItem TabMonitor;
        private System.Windows.Forms.Label lblUser;
    }
}

