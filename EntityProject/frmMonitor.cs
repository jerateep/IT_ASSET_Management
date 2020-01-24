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
    public partial class frmMonitor : Form
    {
        string strAsset = "";
        string searchValue = "";
        myDatabaseEntities db = new myDatabaseEntities();
        public string _UserName { get; set; }
        public frmMonitor()
        {
            InitializeComponent();
        }

        private void frmMonitor_Load(object sender, EventArgs e)
        {
            lblUser.Text = _UserName;
            BindData();
        }

        public void BindData()
        {
            var ds = (from c in db.ViewAssetMonitor
                      select new
                      {
                          c.Asset_ID,
                          c.Monitor_ID,
                          c.Type,
                          c.Model,
                          c.Supplier,
                          c.StartDate,
                          c.EndDate,
                          c.Warranty,
                          c.Remark,
                          c.ModifiedBy,
                          c.UpdateTime,
                          c.Status
                      }
           ).ToList();

            if (ds.Count > 0)
            {
                this.GridView.DataSource = ds;
                searchValue = lblAsset.Text;
                SelectData();
            }
        }

        public void SearchData()
        {
            string Keywords1 = txtSearch1.Text.Trim();
            string[] strKeyword = Keywords1.Split(" ".ToCharArray());
            foreach (string i in strKeyword)
            {
                var ds = (from c in db.ViewAssetMonitor
                          where c.Asset_ID.Contains(i)
                                ||
                                c.Monitor_ID.Contains(i)
                                ||
                                c.Type.Contains(i)
                                ||
                                c.Model.Contains(i)
                                ||
                                c.Status.Contains(i)
                          select new
                          {
                              c.Asset_ID,
                              c.Monitor_ID,
                              c.Type,
                              c.Model,
                              c.Supplier,
                              c.StartDate,
                              c.EndDate,
                              c.Warranty,
                              c.Remark,
                              c.ModifiedBy,
                              c.UpdateTime,
                              c.Status
                          }).ToList();
                if (ds.Count > 0)
                {
                    this.GridView.DataSource = ds;
                    searchValue = lblAsset.Text;
                    SelectData();
                }
            }
        }
        public void SelectData()
        {
            int rowIndex = -1;
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in GridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        GridView.CurrentCell = GridView.Rows[rowIndex].Cells[0];
                        GridView.Rows[GridView.CurrentCell.RowIndex].Selected = true;

                        break;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strAsset = GridView.CurrentRow.Cells[0].Value.ToString();
            this.lblAsset.Text = strAsset;
        }

        private void GridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(GridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ds = (from l in db.RFS_Login


                      select l).FirstOrDefault();
            if (ds != null)
            {
                var frmAddmo = new frmAddMonitor();
                frmAddmo._UserName = ds.name;
                frmAddmo.ShowDialog();
            }
          
            BindData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            strAsset = GridView.CurrentRow.Cells[0].Value.ToString();
            var form = new frmUpdateMonitor();
            form._strAsset = strAsset;
            form.ShowDialog();
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            strAsset = GridView.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show(string.Format("Are you ssure to delete {0}?", strAsset), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Asset_monitor
                           where c.asset_list_m == strAsset
                           select c).FirstOrDefault();
                if (del != null)
                {
                    db.RFS_Asset_monitor.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                BindData();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
