namespace EntityProject
{
    partial class frmMonitorMng
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
            this.dataGridMonitorMng = new System.Windows.Forms.DataGridView();
            this.assetlistmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelnamemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewassetmoniterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssetID = new System.Windows.Forms.TextBox();
            this.txtMonitorID = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.tpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSupName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.cbModelName = new System.Windows.Forms.ComboBox();
            this.viewassetmoniterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewmoniterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rFSAssetmonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitorMng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewassetmoniterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewassetmoniterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmoniterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSAssetmonitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMonitorMng
            // 
            this.dataGridMonitorMng.AutoGenerateColumns = false;
            this.dataGridMonitorMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonitorMng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetlistmDataGridViewTextBoxColumn,
            this.monitoridDataGridViewTextBoxColumn,
            this.modelnamemDataGridViewTextBoxColumn,
            this.supnameDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.userupdateDataGridViewTextBoxColumn,
            this.dateupdateDataGridViewTextBoxColumn,
            this.warrantyDataGridViewTextBoxColumn});
            this.dataGridMonitorMng.DataSource = this.viewassetmoniterBindingSource1;
            this.dataGridMonitorMng.Location = new System.Drawing.Point(49, 30);
            this.dataGridMonitorMng.Name = "dataGridMonitorMng";
            this.dataGridMonitorMng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMonitorMng.Size = new System.Drawing.Size(843, 330);
            this.dataGridMonitorMng.TabIndex = 0;
            this.dataGridMonitorMng.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMonitorMng_CellClick);
            this.dataGridMonitorMng.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridMonitorMng_RowPostPaint);
            // 
            // assetlistmDataGridViewTextBoxColumn
            // 
            this.assetlistmDataGridViewTextBoxColumn.DataPropertyName = "asset_list_m";
            this.assetlistmDataGridViewTextBoxColumn.HeaderText = "asset_list_m";
            this.assetlistmDataGridViewTextBoxColumn.Name = "assetlistmDataGridViewTextBoxColumn";
            // 
            // monitoridDataGridViewTextBoxColumn
            // 
            this.monitoridDataGridViewTextBoxColumn.DataPropertyName = "monitor_id";
            this.monitoridDataGridViewTextBoxColumn.HeaderText = "monitor_id";
            this.monitoridDataGridViewTextBoxColumn.Name = "monitoridDataGridViewTextBoxColumn";
            // 
            // modelnamemDataGridViewTextBoxColumn
            // 
            this.modelnamemDataGridViewTextBoxColumn.DataPropertyName = "model_name_m";
            this.modelnamemDataGridViewTextBoxColumn.HeaderText = "model_name_m";
            this.modelnamemDataGridViewTextBoxColumn.Name = "modelnamemDataGridViewTextBoxColumn";
            // 
            // supnameDataGridViewTextBoxColumn
            // 
            this.supnameDataGridViewTextBoxColumn.DataPropertyName = "sup_name";
            this.supnameDataGridViewTextBoxColumn.HeaderText = "sup_name";
            this.supnameDataGridViewTextBoxColumn.Name = "supnameDataGridViewTextBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // userupdateDataGridViewTextBoxColumn
            // 
            this.userupdateDataGridViewTextBoxColumn.DataPropertyName = "user_update";
            this.userupdateDataGridViewTextBoxColumn.HeaderText = "user_update";
            this.userupdateDataGridViewTextBoxColumn.Name = "userupdateDataGridViewTextBoxColumn";
            this.userupdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateupdateDataGridViewTextBoxColumn
            // 
            this.dateupdateDataGridViewTextBoxColumn.DataPropertyName = "date_update";
            this.dateupdateDataGridViewTextBoxColumn.HeaderText = "date_update";
            this.dateupdateDataGridViewTextBoxColumn.Name = "dateupdateDataGridViewTextBoxColumn";
            this.dateupdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // warrantyDataGridViewTextBoxColumn
            // 
            this.warrantyDataGridViewTextBoxColumn.DataPropertyName = "Warranty";
            this.warrantyDataGridViewTextBoxColumn.HeaderText = "Warranty";
            this.warrantyDataGridViewTextBoxColumn.Name = "warrantyDataGridViewTextBoxColumn";
            // 
            // viewassetmoniterBindingSource1
            // 
            this.viewassetmoniterBindingSource1.DataSource = typeof(EntityProject.viewassetmoniter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asset ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monitor ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Supplier Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "End Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(695, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status :";
            // 
            // txtAssetID
            // 
            this.txtAssetID.Location = new System.Drawing.Point(150, 381);
            this.txtAssetID.Name = "txtAssetID";
            this.txtAssetID.Size = new System.Drawing.Size(164, 20);
            this.txtAssetID.TabIndex = 10;
            // 
            // txtMonitorID
            // 
            this.txtMonitorID.Location = new System.Drawing.Point(150, 409);
            this.txtMonitorID.Name = "txtMonitorID";
            this.txtMonitorID.Size = new System.Drawing.Size(164, 20);
            this.txtMonitorID.TabIndex = 11;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(744, 381);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(148, 20);
            this.txtStatus.TabIndex = 16;
            // 
            // tpStartDate
            // 
            this.tpStartDate.Location = new System.Drawing.Point(451, 413);
            this.tpStartDate.Name = "tpStartDate";
            this.tpStartDate.Size = new System.Drawing.Size(168, 20);
            this.tpStartDate.TabIndex = 21;
            // 
            // tpEndDate
            // 
            this.tpEndDate.Location = new System.Drawing.Point(451, 442);
            this.tpEndDate.Name = "tpEndDate";
            this.tpEndDate.Size = new System.Drawing.Size(168, 20);
            this.tpEndDate.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(685, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(821, 496);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbSupName
            // 
            this.cbSupName.FormattingEnabled = true;
            this.cbSupName.Location = new System.Drawing.Point(452, 381);
            this.cbSupName.Name = "cbSupName";
            this.cbSupName.Size = new System.Drawing.Size(167, 21);
            this.cbSupName.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Warranty :";
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(744, 415);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.ReadOnly = true;
            this.txtWarranty.Size = new System.Drawing.Size(148, 20);
            this.txtWarranty.TabIndex = 28;
            // 
            // cbModelName
            // 
            this.cbModelName.FormattingEnabled = true;
            this.cbModelName.Location = new System.Drawing.Point(150, 441);
            this.cbModelName.Name = "cbModelName";
            this.cbModelName.Size = new System.Drawing.Size(164, 21);
            this.cbModelName.TabIndex = 29;
            // 
            // viewassetmoniterBindingSource
            // 
            this.viewassetmoniterBindingSource.DataSource = typeof(EntityProject.viewassetmoniter);
            // 
            // viewmoniterBindingSource
            // 
            this.viewmoniterBindingSource.DataSource = typeof(EntityProject.viewmoniter);
            // 
            // rFSAssetmonitorBindingSource
            // 
            this.rFSAssetmonitorBindingSource.DataSource = typeof(EntityProject.RFS_Asset_monitor);
            // 
            // frmMonitorMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 531);
            this.Controls.Add(this.cbModelName);
            this.Controls.Add(this.txtWarranty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSupName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tpEndDate);
            this.Controls.Add(this.tpStartDate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMonitorID);
            this.Controls.Add(this.txtAssetID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMonitorMng);
            this.Name = "frmMonitorMng";
            this.Text = "frmMonitorMng";
            this.Load += new System.EventHandler(this.frmMonitorMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitorMng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewassetmoniterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewassetmoniterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmoniterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSAssetmonitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMonitorMng;
        private System.Windows.Forms.BindingSource rFSAssetmonitorBindingSource;
        private System.Windows.Forms.BindingSource viewmoniterBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource viewassetmoniterBindingSource;
        private System.Windows.Forms.BindingSource viewassetmoniterBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAssetID;
        private System.Windows.Forms.TextBox txtMonitorID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker tpStartDate;
        private System.Windows.Forms.DateTimePicker tpEndDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbSupName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetlistmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelnamemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbModelName;
    }
}