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
    public partial class frmType : Form
    {
        string strtypeID;
        string strtypeName;
        myDatabaseEntities db = new myDatabaseEntities();
        public frmType()
        {
            InitializeComponent();
        }

        private void frmType_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var ds = (from c in db.RFS_Type
                      select new
                      {
                          c.type_id,
                          c.type_name,

                      }).ToList();
            if (ds.Count > 0)
            {
                this.GridView.DataSource = ds;
            }
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//ดักerror
            {
                textTypeName.Text = GridView.CurrentRow.Cells[0].Value.ToString();
                textTypeID.Text = GridView.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void GridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void butsave_Click(object sender, EventArgs e)
        {
            strtypeID = this.textTypeID.Text;
            strtypeName = this.textTypeName.Text;

            var ds = (from c in db.RFS_Type //เอาค่าไปใส่ ds
                      where c.type_id == strtypeID
                      select c).FirstOrDefault();


            if (textTypeID.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && textTypeID.Text != "")
            {
                db.RFS_Type.Add(new RFS_Type()
                {
                    type_id = strtypeID,
                    type_name = strtypeName,
                });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();

            }
            else
            {
                ds.type_name = strtypeName;
                ds.type_id = strtypeID;

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            strtypeID = textTypeID.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strtypeID), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Type //เอาค่าไปใส่ ds
                           where c.type_id == strtypeID
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Type.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }
    }
}
