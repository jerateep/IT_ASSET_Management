namespace EntityProject
{
    partial class frmLocation
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
            System.Windows.Forms.Button butsave;
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.textDepartmentName = new System.Windows.Forms.TextBox();
            this.textDepartmentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butdelete = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            butsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "B3",
            "B2",
            "B1",
            "FL.1",
            "FL.2",
            "FL.3",
            "FL.4",
            "FL.5",
            "FL.6",
            "FL.7",
            "FL.8",
            "FL.9"});
            this.cbFloor.Location = new System.Drawing.Point(222, 435);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(193, 21);
            this.cbFloor.TabIndex = 17;
            // 
            // textDepartmentName
            // 
            this.textDepartmentName.Location = new System.Drawing.Point(222, 404);
            this.textDepartmentName.Name = "textDepartmentName";
            this.textDepartmentName.Size = new System.Drawing.Size(193, 20);
            this.textDepartmentName.TabIndex = 16;
            // 
            // textDepartmentID
            // 
            this.textDepartmentID.Location = new System.Drawing.Point(222, 374);
            this.textDepartmentID.Name = "textDepartmentID";
            this.textDepartmentID.Size = new System.Drawing.Size(193, 20);
            this.textDepartmentID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Floor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Department Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Department ID :";
            // 
            // butdelete
            // 
            this.butdelete.Location = new System.Drawing.Point(340, 483);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(75, 23);
            this.butdelete.TabIndex = 11;
            this.butdelete.Text = "DELETE";
            this.butdelete.UseVisualStyleBackColor = true;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butsave
            // 
            butsave.Location = new System.Drawing.Point(222, 483);
            butsave.Name = "butsave";
            butsave.Size = new System.Drawing.Size(75, 23);
            butsave.TabIndex = 10;
            butsave.Text = "SAVE";
            butsave.UseVisualStyleBackColor = true;
            butsave.Click += new System.EventHandler(this.butsave_Click);
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
            this.GridView.Location = new System.Drawing.Point(26, 58);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(470, 268);
            this.GridView.TabIndex = 18;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridView_RowPostPaint);
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 521);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.textDepartmentName);
            this.Controls.Add(this.textDepartmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(butsave);
            this.Name = "frmLocation";
            this.Text = "frmLocation";
            this.Load += new System.EventHandler(this.frmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.TextBox textDepartmentName;
        private System.Windows.Forms.TextBox textDepartmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.DataGridView GridView;
    }
}