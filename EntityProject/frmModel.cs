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
    public partial class frmModel : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string strModelID;
        string strModelName;
        string strTypeName;

        public frmModel()
        {
            InitializeComponent();
        }
        public void LoadType()
        {
            var ds = (from c in db.RFS_Type
                      select new
                      {
                          c.type_id,
                          c.type_name
                      }).ToList();
            cbTypeName.DataSource = ds;
            cbTypeName.DisplayMember = "type_name";
            cbTypeName.ValueMember = "type_id";
        }
        public void LoadData()
        {
            var ds = (from c in db.ViewModel
                      select new
                      {
                          c.model_id,
                          c.model_name,
                          c.type_name

                      }).ToList();
            if (ds.Count > 0)
            {
                this.GridModel.DataSource = ds;
            }
        }
        private void frmModel_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadType();
        }

        private void GridModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//ดักerror
            {
                txtModelID.Text = GridModel.CurrentRow.Cells[0].Value.ToString();
                txtModelName.Text = GridModel.CurrentRow.Cells[1].Value.ToString();
                cbTypeName.Text = GridModel.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            strModelID = this.txtModelID.Text;
            strModelName = this.txtModelName.Text;
            strTypeName = this.cbTypeName.Text;


            var ds = (from c in db.RFS_Model_Asset //เอาค่าไปใส่ ds
                      where c.model_id == strModelID
                      select c).FirstOrDefault();


            if (txtModelID.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && txtModelID.Text != "")
            {
                db.RFS_Model_Asset.Add(new RFS_Model_Asset()
                {

                    model_id = strModelID,
                    model_name = strModelName,
                    type_id = cbTypeName.SelectedValue.ToString()
                });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();
            }
            else
            {
                try//ดักerror
                {
                    ds.model_name = strModelName;
                    ds.type_id = cbTypeName.SelectedValue.ToString();
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
            strModelID = txtModelID.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strModelID), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Model_Asset //เอาค่าไปใส่ ds
                           where c.model_id == strModelID
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Model_Asset.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }

        private void GridModel_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(GridModel.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b,
                e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
