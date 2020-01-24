using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class frmModel_m : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string strModelID_m;
        string strModelName_m;
        string strTypeName_m;
        public frmModel_m()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var ds = (from c in db.viewModel_m
                      select new
                      {
                          c.Model_ID,
                          c.Model_Name,
                          c.Type_Name

                      }).ToList();
            if (ds.Count > 0)
            {
                this.dataGridModelm.DataSource = ds;
            }
        }
        public void LoadType()
        {
            var ds = (from c in db.RFS_Type_monitor
                      select new
                      {
                          c.type_id_m,
                          c.type_name_m
                      }).ToList();
            cbTypeName_m.DataSource = ds;
            cbTypeName_m.DisplayMember = "type_name_m";
            cbTypeName_m.ValueMember = "type_id_m";
        }


        private void frmModel_m_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadType();
        }

        private void dataGridModelm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//ดักerror
            {
                txtModelID_m.Text = dataGridModelm.CurrentRow.Cells[0].Value.ToString();
                txtModelName_m.Text = dataGridModelm.CurrentRow.Cells[1].Value.ToString();
                cbTypeName_m.Text = dataGridModelm.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            strModelID_m = this.txtModelID_m.Text;
            strModelName_m = this.txtModelName_m.Text;
            strTypeName_m = this.cbTypeName_m.Text;


            var ds = (from c in db.RFS_Model_Asset_m //เอาค่าไปใส่ ds
                      where c.model_id_m == strModelID_m
                      select c).FirstOrDefault();


            if (txtModelID_m.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && txtModelID_m.Text != "")
            {
                db.RFS_Model_Asset_m.Add(new RFS_Model_Asset_m()
                {

                    model_id_m = strModelID_m,
                    model_name_m = strModelName_m,
                    type_id_m = cbTypeName_m.SelectedValue.ToString()

                });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();

            }
            else
            {
                try//ดักerror
                {
                    ds.model_name_m = strModelName_m;
                    ds.type_id_m = cbTypeName_m.SelectedValue.ToString();
                }
                catch (Exception)
                {

                }

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            strModelID_m = txtModelID_m.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strModelID_m), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Model_Asset_m //เอาค่าไปใส่ ds
                           where c.model_id_m == strModelID_m
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Model_Asset_m.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }

        private void dataGridModelm_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridModelm.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, 
                e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

    }
}
