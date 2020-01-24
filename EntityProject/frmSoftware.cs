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
    public partial class frmSoftware : Form
    {
        string strSoftwareID;
        string strSoftwareName;
        string strRemark;
        myDatabaseEntities db = new myDatabaseEntities();

        public frmSoftware()
        {
            InitializeComponent();
        }

        private void frmSoftware_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var ds = (from c in db.RFS_Software
                      select new
                      {
                          c.software_id,
                          c.software_name,
                          c.software_remark

                      }).ToList();
            if (ds.Count > 0)
            {
                this.GridView.DataSource = ds;
            }
        }

        private void GridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//ดักerror
            {
                textSoftwareID.Text = GridView.CurrentRow.Cells[0].Value.ToString();
                textSoftwareName.Text = GridView.CurrentRow.Cells[1].Value.ToString();
                textRemark.Text = GridView.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            strSoftwareID = this.textSoftwareID.Text;
            strSoftwareName = this.textSoftwareName.Text;
            strRemark = this.textRemark.Text;

            var ds = (from c in db.RFS_Software //เอาค่าไปใส่ ds
                      where c.software_id == strSoftwareID
                      select c).FirstOrDefault();


            if (textSoftwareID.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && textSoftwareID.Text != "")
            {
                db.RFS_Software.Add(new RFS_Software()
                {
                    software_id = strSoftwareID,
                    software_name = strSoftwareName,
                    software_remark = strRemark
                });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();

            }
            else
            {
                ds.software_id = strSoftwareID;
                ds.software_name = strSoftwareName;
                ds.software_remark = strRemark;

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            strSoftwareID = textSoftwareID.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strSoftwareID), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Software //เอาค่าไปใส่ ds
                           where c.software_id == strSoftwareID
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Software.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }
    }
}
