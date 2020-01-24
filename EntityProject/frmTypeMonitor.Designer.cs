namespace EntityProject
{
    partial class frmTypeMonitor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeName_m = new System.Windows.Forms.TextBox();
            this.txtTypeID_m = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type Name Monitor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type ID Monitor :";
            // 
            // txtTypeName_m
            // 
            this.txtTypeName_m.Location = new System.Drawing.Point(247, 391);
            this.txtTypeName_m.Name = "txtTypeName_m";
            this.txtTypeName_m.Size = new System.Drawing.Size(171, 20);
            this.txtTypeName_m.TabIndex = 10;
            // 
            // txtTypeID_m
            // 
            this.txtTypeID_m.Location = new System.Drawing.Point(247, 361);
            this.txtTypeID_m.Name = "txtTypeID_m";
            this.txtTypeID_m.Size = new System.Drawing.Size(171, 20);
            this.txtTypeID_m.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(343, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.GridView.Location = new System.Drawing.Point(29, 53);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(470, 268);
            this.GridView.TabIndex = 14;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // frmTypeMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 521);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeName_m);
            this.Controls.Add(this.txtTypeID_m);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "frmTypeMonitor";
            this.Text = "frmTypeMonitor";
            this.Load += new System.EventHandler(this.frmTypeMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTypeName_m;
        private System.Windows.Forms.TextBox txtTypeID_m;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView GridView;
    }
}