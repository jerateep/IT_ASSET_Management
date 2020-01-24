namespace EntityProject
{
    partial class frmUpdate
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
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.cbSoftware = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.GridSoftwate = new System.Windows.Forms.DataGridView();
            this.assetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewSoftwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picAsset = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.cbDepart = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtServiceTag = new System.Windows.Forms.TextBox();
            this.txtAssetId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelSoftware = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelMonitor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridSoftwate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSoftwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Location = new System.Drawing.Point(101, 424);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(15, 14);
            this.chkMonitor.TabIndex = 78;
            this.chkMonitor.UseVisualStyleBackColor = true;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(427, 493);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(219, 20);
            this.txtDetail.TabIndex = 76;
            this.txtDetail.Text = "txtDetail";
            // 
            // cbSoftware
            // 
            this.cbSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoftware.FormattingEnabled = true;
            this.cbSoftware.Location = new System.Drawing.Point(427, 455);
            this.cbSoftware.Name = "cbSoftware";
            this.cbSoftware.Size = new System.Drawing.Size(219, 21);
            this.cbSoftware.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(359, 496);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "Detail :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(319, 463);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "Software Name :";
            // 
            // GridSoftwate
            // 
            this.GridSoftwate.AutoGenerateColumns = false;
            this.GridSoftwate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridSoftwate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSoftwate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetIdDataGridViewTextBoxColumn,
            this.serviceTagDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.softwareNameDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn});
            this.GridSoftwate.DataSource = this.viewSoftwareBindingSource;
            this.GridSoftwate.Location = new System.Drawing.Point(322, 252);
            this.GridSoftwate.MultiSelect = false;
            this.GridSoftwate.Name = "GridSoftwate";
            this.GridSoftwate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSoftwate.Size = new System.Drawing.Size(524, 186);
            this.GridSoftwate.TabIndex = 72;
            this.GridSoftwate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSoftwate_CellClick);
            this.GridSoftwate.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridSoftwate_RowPostPaint);
            // 
            // assetIdDataGridViewTextBoxColumn
            // 
            this.assetIdDataGridViewTextBoxColumn.DataPropertyName = "AssetId";
            this.assetIdDataGridViewTextBoxColumn.HeaderText = "AssetId";
            this.assetIdDataGridViewTextBoxColumn.Name = "assetIdDataGridViewTextBoxColumn";
            this.assetIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceTagDataGridViewTextBoxColumn
            // 
            this.serviceTagDataGridViewTextBoxColumn.DataPropertyName = "Service_Tag";
            this.serviceTagDataGridViewTextBoxColumn.HeaderText = "Service_Tag";
            this.serviceTagDataGridViewTextBoxColumn.Name = "serviceTagDataGridViewTextBoxColumn";
            this.serviceTagDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // softwareNameDataGridViewTextBoxColumn
            // 
            this.softwareNameDataGridViewTextBoxColumn.DataPropertyName = "SoftwareName";
            this.softwareNameDataGridViewTextBoxColumn.HeaderText = "SoftwareName";
            this.softwareNameDataGridViewTextBoxColumn.Name = "softwareNameDataGridViewTextBoxColumn";
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            // 
            // viewSoftwareBindingSource
            // 
            this.viewSoftwareBindingSource.DataSource = typeof(EntityProject.ViewSoftware);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(427, 218);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(163, 20);
            this.dtEnd.TabIndex = 71;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(427, 182);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(163, 20);
            this.dtStart.TabIndex = 70;
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(427, 149);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(163, 21);
            this.cbSupplier.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(321, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Warranty End :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(318, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "Warranty Start :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Supplier :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(771, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 29);
            this.btnBrowse.TabIndex = 64;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picAsset
            // 
            this.picAsset.BackColor = System.Drawing.Color.Blue;
            this.picAsset.Location = new System.Drawing.Point(626, 55);
            this.picAsset.Name = "picAsset";
            this.picAsset.Size = new System.Drawing.Size(220, 184);
            this.picAsset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAsset.TabIndex = 63;
            this.picAsset.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(753, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 59);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Department :";
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(427, 87);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(163, 21);
            this.cbUser.TabIndex = 60;
            // 
            // cbDepart
            // 
            this.cbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepart.FormattingEnabled = true;
            this.cbDepart.Location = new System.Drawing.Point(427, 55);
            this.cbDepart.Name = "cbDepart";
            this.cbDepart.Size = new System.Drawing.Size(163, 21);
            this.cbDepart.TabIndex = 59;
            this.cbDepart.SelectedIndexChanged += new System.EventHandler(this.cbDepart_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "User :";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(121, 288);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(163, 80);
            this.txtRemark.TabIndex = 53;
            this.txtRemark.Text = "txtRemark";
            // 
            // cbMonitor
            // 
            this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(122, 417);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(163, 21);
            this.cbMonitor.TabIndex = 56;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(122, 381);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(163, 21);
            this.cbStatus.TabIndex = 55;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(121, 252);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(163, 20);
            this.txtIP.TabIndex = 51;
            this.txtIP.Text = "txtIP";
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 13;
            this.cbLocation.Location = new System.Drawing.Point(121, 218);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(163, 21);
            this.cbLocation.TabIndex = 57;
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(120, 183);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(163, 20);
            this.txtSpec.TabIndex = 47;
            this.txtSpec.Text = "txtSpec";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(120, 117);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(163, 21);
            this.cbType.TabIndex = 43;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtServiceTag
            // 
            this.txtServiceTag.Location = new System.Drawing.Point(120, 88);
            this.txtServiceTag.Name = "txtServiceTag";
            this.txtServiceTag.Size = new System.Drawing.Size(163, 20);
            this.txtServiceTag.TabIndex = 42;
            this.txtServiceTag.Text = "txtServiceTag";
            // 
            // txtAssetId
            // 
            this.txtAssetId.Location = new System.Drawing.Point(120, 56);
            this.txtAssetId.Name = "txtAssetId";
            this.txtAssetId.ReadOnly = true;
            this.txtAssetId.Size = new System.Drawing.Size(163, 20);
            this.txtAssetId.TabIndex = 39;
            this.txtAssetId.Text = "txtAssetId";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Monitor :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Remark :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "IP :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Location :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Spec :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Service Tag :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Asset Id :";
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(120, 149);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(163, 21);
            this.cbModel.TabIndex = 79;
            // 
            // btnSoftware
            // 
            this.btnSoftware.Location = new System.Drawing.Point(652, 454);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(95, 21);
            this.btnSoftware.TabIndex = 80;
            this.btnSoftware.Text = "Update Software";
            this.btnSoftware.UseVisualStyleBackColor = true;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonitor.Location = new System.Drawing.Point(121, 460);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(2, 15);
            this.lblMonitor.TabIndex = 81;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(626, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 29);
            this.btnExport.TabIndex = 82;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelSoftware
            // 
            this.btnDelSoftware.Location = new System.Drawing.Point(652, 493);
            this.btnDelSoftware.Name = "btnDelSoftware";
            this.btnDelSoftware.Size = new System.Drawing.Size(95, 20);
            this.btnDelSoftware.TabIndex = 83;
            this.btnDelSoftware.Text = "Delete Software";
            this.btnDelSoftware.UseVisualStyleBackColor = true;
            this.btnDelSoftware.Click += new System.EventHandler(this.btnDelSoftware_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Change Monitor :";
            // 
            // btnDelMonitor
            // 
            this.btnDelMonitor.Location = new System.Drawing.Point(120, 492);
            this.btnDelMonitor.Name = "btnDelMonitor";
            this.btnDelMonitor.Size = new System.Drawing.Size(95, 21);
            this.btnDelMonitor.TabIndex = 85;
            this.btnDelMonitor.Text = "Delete Monitor";
            this.btnDelMonitor.UseVisualStyleBackColor = true;
            this.btnDelMonitor.Click += new System.EventHandler(this.btnDelMonitor_Click);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 536);
            this.Controls.Add(this.btnDelMonitor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnDelSoftware);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.btnSoftware);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.chkMonitor);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.cbSoftware);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.GridSoftwate);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picAsset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.cbDepart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.cbMonitor);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtServiceTag);
            this.Controls.Add(this.txtAssetId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(905, 575);
            this.Name = "frmUpdate";
            this.Text = "frmUpdate";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridSoftwate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSoftwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.ComboBox cbSoftware;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView GridSoftwate;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picAsset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox cbDepart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtServiceTag;
        private System.Windows.Forms.TextBox txtAssetId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewSoftwareBindingSource;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelSoftware;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelMonitor;
    }
}