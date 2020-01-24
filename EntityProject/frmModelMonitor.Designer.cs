namespace EntityProject
{
    partial class frmModelMonitor
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.cbTypeName_m = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtModelName_m = new System.Windows.Forms.TextBox();
            this.txtModelID_m = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
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
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(30, 48);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(470, 268);
            this.GridView.TabIndex = 3;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // cbTypeName_m
            // 
            this.cbTypeName_m.DisplayMember = "type_name_m";
            this.cbTypeName_m.FormattingEnabled = true;
            this.cbTypeName_m.Location = new System.Drawing.Point(234, 417);
            this.cbTypeName_m.Name = "cbTypeName_m";
            this.cbTypeName_m.Size = new System.Drawing.Size(153, 21);
            this.cbTypeName_m.TabIndex = 16;
            this.cbTypeName_m.ValueMember = "type_id_m";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(231, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtModelName_m
            // 
            this.txtModelName_m.Location = new System.Drawing.Point(234, 380);
            this.txtModelName_m.Name = "txtModelName_m";
            this.txtModelName_m.Size = new System.Drawing.Size(153, 20);
            this.txtModelName_m.TabIndex = 13;
            // 
            // txtModelID_m
            // 
            this.txtModelID_m.Location = new System.Drawing.Point(234, 345);
            this.txtModelID_m.Name = "txtModelID_m";
            this.txtModelID_m.Size = new System.Drawing.Size(153, 20);
            this.txtModelID_m.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type Name Monitor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model Name Monitor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Model ID Monitor :";
            // 
            // frmModelMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 521);
            this.Controls.Add(this.cbTypeName_m);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtModelName_m);
            this.Controls.Add(this.txtModelID_m);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Name = "frmModelMonitor";
            this.Text = "frmModelMonitor";
            this.Load += new System.EventHandler(this.frmModelMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.ComboBox cbTypeName_m;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtModelName_m;
        private System.Windows.Forms.TextBox txtModelID_m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}