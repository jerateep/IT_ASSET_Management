namespace EntityProject
{
    partial class frmModel
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
            this.GridModel = new System.Windows.Forms.DataGridView();
            this.modelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTypeName = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtModelID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridModel
            // 
            this.GridModel.AutoGenerateColumns = false;
            this.GridModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelidDataGridViewTextBoxColumn,
            this.modelnameDataGridViewTextBoxColumn,
            this.typenameDataGridViewTextBoxColumn});
            this.GridModel.DataSource = this.viewModelBindingSource;
            this.GridModel.Location = new System.Drawing.Point(29, 53);
            this.GridModel.Name = "GridModel";
            this.GridModel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridModel.Size = new System.Drawing.Size(470, 268);
            this.GridModel.TabIndex = 0;
            this.GridModel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridModel_CellClick);
            this.GridModel.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridModel_RowPostPaint);
            // 
            // modelidDataGridViewTextBoxColumn
            // 
            this.modelidDataGridViewTextBoxColumn.DataPropertyName = "model_id";
            this.modelidDataGridViewTextBoxColumn.HeaderText = "model_id";
            this.modelidDataGridViewTextBoxColumn.Name = "modelidDataGridViewTextBoxColumn";
            // 
            // modelnameDataGridViewTextBoxColumn
            // 
            this.modelnameDataGridViewTextBoxColumn.DataPropertyName = "model_name";
            this.modelnameDataGridViewTextBoxColumn.HeaderText = "model_name";
            this.modelnameDataGridViewTextBoxColumn.Name = "modelnameDataGridViewTextBoxColumn";
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "type_name";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "type_name";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            // 
            // viewModelBindingSource
            // 
            this.viewModelBindingSource.DataSource = typeof(EntityProject.ViewModel);
            // 
            // cbTypeName
            // 
            this.cbTypeName.DisplayMember = "type_name_m";
            this.cbTypeName.FormattingEnabled = true;
            this.cbTypeName.Location = new System.Drawing.Point(254, 416);
            this.cbTypeName.Name = "cbTypeName";
            this.cbTypeName.Size = new System.Drawing.Size(153, 21);
            this.cbTypeName.TabIndex = 24;
            this.cbTypeName.ValueMember = "type_id_m";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(332, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(254, 379);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(153, 20);
            this.txtModelName.TabIndex = 21;
            // 
            // txtModelID
            // 
            this.txtModelID.Location = new System.Drawing.Point(254, 344);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.Size = new System.Drawing.Size(153, 20);
            this.txtModelID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Type Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Model Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Model ID :";
            // 
            // frmModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 521);
            this.Controls.Add(this.cbTypeName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.txtModelID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridModel);
            this.MaximumSize = new System.Drawing.Size(560, 560);
            this.MinimumSize = new System.Drawing.Size(560, 560);
            this.Name = "frmModel";
            this.Text = "frmModel";
            this.Load += new System.EventHandler(this.frmModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridModel;
        private System.Windows.Forms.ComboBox cbTypeName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtModelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewModelBindingSource;
    }
}