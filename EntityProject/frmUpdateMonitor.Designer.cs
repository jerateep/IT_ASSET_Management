namespace EntityProject
{
    partial class frmUpdateMonitor
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
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picAsset = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtMonitorId = new System.Windows.Forms.TextBox();
            this.txtAssetId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(437, 160);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(163, 20);
            this.dtEnd.TabIndex = 91;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(437, 129);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(163, 20);
            this.dtStart.TabIndex = 90;
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(437, 96);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(163, 21);
            this.cbSupplier.TabIndex = 89;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 88;
            this.label16.Text = "Warranty End :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(323, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 87;
            this.label15.Text = "Warranty Start :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(323, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 86;
            this.label13.Text = "Supplier :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(771, 43);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 31);
            this.btnBrowse.TabIndex = 85;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picAsset
            // 
            this.picAsset.BackColor = System.Drawing.Color.Blue;
            this.picAsset.Location = new System.Drawing.Point(626, 95);
            this.picAsset.Name = "picAsset";
            this.picAsset.Size = new System.Drawing.Size(220, 184);
            this.picAsset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAsset.TabIndex = 84;
            this.picAsset.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(754, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 58);
            this.btnSave.TabIndex = 83;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(129, 238);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(163, 80);
            this.txtRemark.TabIndex = 81;
            this.txtRemark.Text = "txtRemark";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(129, 346);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(163, 21);
            this.cbStatus.TabIndex = 82;
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(129, 190);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(163, 21);
            this.cbModel.TabIndex = 78;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(129, 158);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(163, 21);
            this.cbType.TabIndex = 76;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtMonitorId
            // 
            this.txtMonitorId.Location = new System.Drawing.Point(129, 129);
            this.txtMonitorId.Name = "txtMonitorId";
            this.txtMonitorId.Size = new System.Drawing.Size(163, 20);
            this.txtMonitorId.TabIndex = 75;
            this.txtMonitorId.Text = "txtMonitorId";
            // 
            // txtAssetId
            // 
            this.txtAssetId.Location = new System.Drawing.Point(129, 97);
            this.txtAssetId.Name = "txtAssetId";
            this.txtAssetId.ReadOnly = true;
            this.txtAssetId.Size = new System.Drawing.Size(163, 20);
            this.txtAssetId.TabIndex = 72;
            this.txtAssetId.Text = "txtAssetId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Remark :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Monitor Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Asset Id :";
            // 
            // frmUpdateMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 411);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picAsset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtMonitorId);
            this.Controls.Add(this.txtAssetId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateMonitor";
            this.Text = "frmUpdateMonitor";
            this.Load += new System.EventHandler(this.frmUpdateMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAsset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picAsset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtMonitorId;
        private System.Windows.Forms.TextBox txtAssetId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}