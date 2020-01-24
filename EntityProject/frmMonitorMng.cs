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
    public partial class frmMonitorMng : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string strAssetID;
        string strMonitorID;
        string strModelName;
        string strSupName;
        string strStatus;
        string strUserUp;
        public frmMonitorMng()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var ds = (from c in db.viewassetmoniter
                      select new
                      {
                         c.asset_list_m,
                         c.monitor_id,
                         c.model_name_m,
                         c.start_date,
                         c.end_date,
                         c.status,
                         c.user_update,
                         c.date_update,
                         c.sup_name,
                         c.Warranty

                      }).ToList();
            if (ds.Count > 0)
            {
                dataGridMonitorMng.DataSource = ds;
            }
        }

        public void LoadSupplier()
        {
            var ds = (from c in db.RFS_Supplier
                      select new
                      {
                          c.sup_id,
                          c.sup_name
                      }).ToList();
            cbSupName.DataSource = ds;
            cbSupName.DisplayMember = "sup_name";
            cbSupName.ValueMember = "sup_id";
        }

        public void LoadModel()
        {
            var ds = (from c in db.RFS_Model_Asset_m
                      select new
                      {
                          c.model_id_m,
                          c.model_name_m
                      }).ToList();
            cbModelName.DataSource = ds;
            cbModelName.DisplayMember = "model_name_m";
            cbModelName.ValueMember = "model_id_m";
        }

        private void frmMonitorMng_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadSupplier();
            LoadModel();
        }

        private void dataGridMonitorMng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAssetID.Text = dataGridMonitorMng.CurrentRow.Cells[0].Value.ToString();
                txtMonitorID.Text = dataGridMonitorMng.CurrentRow.Cells[1].Value.ToString();
                cbModelName.Text = dataGridMonitorMng.CurrentRow.Cells[2].Value.ToString();
                cbSupName.Text = dataGridMonitorMng.CurrentRow.Cells[3].Value.ToString();
                tpStartDate.Text = dataGridMonitorMng.CurrentRow.Cells[4].Value.ToString();
                tpEndDate.Text = dataGridMonitorMng.CurrentRow.Cells[5].Value.ToString();
                txtStatus.Text = dataGridMonitorMng.CurrentRow.Cells[6].Value.ToString();
                txtWarranty.Text = dataGridMonitorMng.CurrentRow.Cells[9].Value.ToString();
                
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            strAssetID = this.txtAssetID.Text;
            strMonitorID = this.txtMonitorID.Text;
            strModelName = this.cbModelName.Text;
            strSupName = this.cbSupName.Text;
            



            var ds = (from c in db.RFS_Asset_monitor 
                      where c.asset_list_m == strAssetID
                      select c).FirstOrDefault();


            if (txtAssetID.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && txtAssetID.Text != "")
            {
                db.RFS_Asset_monitor.Add(new RFS_Asset_monitor()
                {
                   
                    asset_list_m = strAssetID,
                    monitor_id = strMonitorID,
                    model_id_m = cbModelName.SelectedValue.ToString(),
                    sup_id = cbSupName.SelectedValue.ToString(),
                    start_date = DateTime.Parse(tpStartDate.Text),
                    end_date = DateTime.Parse(tpEndDate.Text),
                    status = strStatus
                    //user_update = strUserUp,
    



            });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();

            }
            else
            {
                try
                {
                    ds.monitor_id = txtMonitorID.Text;
                    ds.model_id_m = cbModelName.Text;
                    ds.sup_id = cbSupName.SelectedValue.ToString();
                    ds.start_date = DateTime.Parse(tpStartDate.Text);
                    ds.end_date = DateTime.Parse(tpEndDate.Text);
                    ds.status = txtStatus.Text;
                    //ds.user_update = txtUserUp.Text;
                    //ds.date_update = DateTime.Parse(tpDateUp.Text);


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
            strAssetID = txtAssetID.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strAssetID), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Asset_monitor 
                           where c.asset_list_m == strAssetID
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Asset_monitor.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }

        private void dataGridMonitorMng_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridMonitorMng.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b,
                e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
