namespace EntityProject
{
    partial class frmSupplier
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
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtTex = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.supidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suptelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supfaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suptexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSAssetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSAssetmonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFSSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.AutoGenerateColumns = false;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supidDataGridViewTextBoxColumn,
            this.supnameDataGridViewTextBoxColumn,
            this.suptelDataGridViewTextBoxColumn,
            this.supfaxDataGridViewTextBoxColumn,
            this.supmailDataGridViewTextBoxColumn,
            this.supaddressDataGridViewTextBoxColumn,
            this.suptexDataGridViewTextBoxColumn,
            this.rFSAssetDataGridViewTextBoxColumn,
            this.rFSAssetmonitorDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.rFSSupplierBindingSource;
            this.GridView.Location = new System.Drawing.Point(47, 37);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(1062, 311);
            this.GridView.TabIndex = 2;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1034, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(924, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(667, 438);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(158, 56);
            this.txtAdd.TabIndex = 30;
            // 
            // txtTex
            // 
            this.txtTex.Location = new System.Drawing.Point(667, 509);
            this.txtTex.Name = "txtTex";
            this.txtTex.Size = new System.Drawing.Size(158, 20);
            this.txtTex.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(667, 406);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(332, 509);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(158, 20);
            this.txtFax.TabIndex = 27;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(332, 474);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(158, 20);
            this.txtTel.TabIndex = 26;
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(332, 438);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(158, 20);
            this.txtSupName.TabIndex = 25;
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(332, 406);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(158, 20);
            this.txtSupID.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tex :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "E-mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fax :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Supplier Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Supplier ID :";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(47, 511);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 33;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // supidDataGridViewTextBoxColumn
            // 
            this.supidDataGridViewTextBoxColumn.DataPropertyName = "sup_id";
            this.supidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.supidDataGridViewTextBoxColumn.Name = "supidDataGridViewTextBoxColumn";
            this.supidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supnameDataGridViewTextBoxColumn
            // 
            this.supnameDataGridViewTextBoxColumn.DataPropertyName = "sup_name";
            this.supnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.supnameDataGridViewTextBoxColumn.Name = "supnameDataGridViewTextBoxColumn";
            this.supnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suptelDataGridViewTextBoxColumn
            // 
            this.suptelDataGridViewTextBoxColumn.DataPropertyName = "sup_tel";
            this.suptelDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.suptelDataGridViewTextBoxColumn.Name = "suptelDataGridViewTextBoxColumn";
            this.suptelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supfaxDataGridViewTextBoxColumn
            // 
            this.supfaxDataGridViewTextBoxColumn.DataPropertyName = "sup_fax";
            this.supfaxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.supfaxDataGridViewTextBoxColumn.Name = "supfaxDataGridViewTextBoxColumn";
            this.supfaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supmailDataGridViewTextBoxColumn
            // 
            this.supmailDataGridViewTextBoxColumn.DataPropertyName = "sup_mail";
            this.supmailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.supmailDataGridViewTextBoxColumn.Name = "supmailDataGridViewTextBoxColumn";
            this.supmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supaddressDataGridViewTextBoxColumn
            // 
            this.supaddressDataGridViewTextBoxColumn.DataPropertyName = "sup_address";
            this.supaddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.supaddressDataGridViewTextBoxColumn.Name = "supaddressDataGridViewTextBoxColumn";
            this.supaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suptexDataGridViewTextBoxColumn
            // 
            this.suptexDataGridViewTextBoxColumn.DataPropertyName = "sup_tex";
            this.suptexDataGridViewTextBoxColumn.HeaderText = "TexId";
            this.suptexDataGridViewTextBoxColumn.Name = "suptexDataGridViewTextBoxColumn";
            this.suptexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rFSAssetDataGridViewTextBoxColumn
            // 
            this.rFSAssetDataGridViewTextBoxColumn.DataPropertyName = "RFS_Asset";
            this.rFSAssetDataGridViewTextBoxColumn.HeaderText = "RFS_Asset";
            this.rFSAssetDataGridViewTextBoxColumn.Name = "rFSAssetDataGridViewTextBoxColumn";
            this.rFSAssetDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFSAssetDataGridViewTextBoxColumn.Visible = false;
            // 
            // rFSAssetmonitorDataGridViewTextBoxColumn
            // 
            this.rFSAssetmonitorDataGridViewTextBoxColumn.DataPropertyName = "RFS_Asset_monitor";
            this.rFSAssetmonitorDataGridViewTextBoxColumn.HeaderText = "RFS_Asset_monitor";
            this.rFSAssetmonitorDataGridViewTextBoxColumn.Name = "rFSAssetmonitorDataGridViewTextBoxColumn";
            this.rFSAssetmonitorDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFSAssetmonitorDataGridViewTextBoxColumn.Visible = false;
            // 
            // rFSSupplierBindingSource
            // 
            this.rFSSupplierBindingSource.DataSource = typeof(EntityProject.RFS_Supplier);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 562);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtTex);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Name = "frmSupplier";
            this.Text = "frmSupplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFSSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suptelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supfaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suptexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFSAssetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFSAssetmonitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rFSSupplierBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtTex;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
    }
}