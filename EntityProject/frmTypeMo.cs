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
    public partial class frmTypeMo : Form
    {

        myDatabaseEntities db = new myDatabaseEntities();
        string strTypeID_m;
        string strTypeName_m;

        public frmTypeMo()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            var ds = (from c in db.RFS_Type_monitor
                      select new
                      {
                          c.type_id_m,
                          c.type_name_m,

                      }).ToList();
            if (ds.Count > 0)
            {
                this.datagridTypem.DataSource = ds;
            }
        }

        private void frmTypeMo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void GridTypeM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//ดักerror
            {
                txtTypeID_m.Text = datagridTypem.CurrentRow.Cells[0].Value.ToString();
                txtTypeName_m.Text = datagridTypem.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            strTypeID_m = this.txtTypeID_m.Text;
            strTypeName_m = this.txtTypeName_m.Text;


            var ds = (from c in db.RFS_Type_monitor //เอาค่าไปใส่ ds
                      where c.type_id_m == strTypeID_m
                      select c).FirstOrDefault();


            if (txtTypeID_m.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && txtTypeID_m.Text != "")
            {
                db.RFS_Type_monitor.Add(new RFS_Type_monitor()
                {
                    type_id_m = strTypeID_m,
                    type_name_m = strTypeName_m,

                });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();

            }
            else
            {
                ds.type_id_m = strTypeID_m;
                ds.type_name_m = strTypeName_m;


                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            strTypeID_m = txtTypeID_m.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strTypeID_m), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Type_monitor //เอาค่าไปใส่ ds
                           where c.type_id_m == strTypeID_m
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Type_monitor.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }

        private void datagridTypem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(datagridTypem.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b,
                e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
