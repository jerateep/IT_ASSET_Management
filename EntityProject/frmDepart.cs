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
    public partial class frmDepart : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string strDepartmentID;
        string strDepartmentName;
        string strFloor;
        public frmDepart()
        {
            InitializeComponent();
        }

        private void frmDepart_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var ds = (from c in db.RFS_Department
                      select new
                      {
                          c.dep_id,
                          c.dep_name,
                          c.dep_floor

                      }).ToList();
            if (ds.Count > 0)
            {
                this.GridView.DataSource = ds;
            }
        }

        private void GridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(GridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//ดักerror
            {
                textDepartmentID.Text = GridView.CurrentRow.Cells[0].Value.ToString();
                textDepartmentName.Text = GridView.CurrentRow.Cells[1].Value.ToString();
                cbFloor.Text = GridView.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            strDepartmentID = this.textDepartmentID.Text;
            strDepartmentName = this.textDepartmentName.Text;
            strFloor = this.cbFloor.Text;
            var ds = (from c in db.RFS_Department //เอาค่าไปใส่ ds
                      where c.dep_id == strDepartmentID
                      select c).FirstOrDefault();


            if (textDepartmentID.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && textDepartmentID.Text != "")
            {
                db.RFS_Department.Add(new RFS_Department()
                {
                    dep_id = strDepartmentID,
                    dep_name = strDepartmentName,
                    dep_floor = strFloor
                });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();
            }
            else
            {
                ds.dep_id = strDepartmentID;
                ds.dep_name = strDepartmentName;
                ds.dep_floor = strFloor;

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            strDepartmentID = textDepartmentID.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strDepartmentID), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Department //เอาค่าไปใส่ ds
                           where c.dep_id == strDepartmentID
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Department.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }
    }
}
