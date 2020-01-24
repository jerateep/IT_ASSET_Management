using Microsoft.Office.Interop.Excel;
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
    public partial class frmMain : Form
    {
        string strAsset = "";
        string searchValue = "";
        myDatabaseEntities db = new myDatabaseEntities();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void SearchData()
        {
            string Keywords1 = txtSearch1.Text.Trim();
            var ds = (from c in db.ViewAllData
                      where c.AssetID.Contains(Keywords1)
                            ||
                            c.Service_Tag.Contains(Keywords1)
                            ||
                            c.Type.Contains(Keywords1)
                            ||
                            c.Model.Contains(Keywords1)
                            ||
                            c.Monitor.Contains(Keywords1)
                            ||
                            c.User.Contains(Keywords1)
                            ||
                            c.Location.Contains(Keywords1)
                      select new
                      {
                          c.AssetID,
                          c.Service_Tag,
                          c.Type,
                          c.Model,
                          c.Spec,
                          c.User,
                          c.Level,
                          c.Location,
                          c.Monitor,
                          c.IP,
                          c.Remark,
                          c.Supplier,
                          c.Warranty,
                          c.StartDate,
                          c.EndDate,
                          c.ModifiedBy,
                          c.UpdateTime,
                          c.Status
                      }).ToList();
            if (ds.Count > 0)
            {
                this.GridView.AutoGenerateColumns = false;
                this.GridView.AllowUserToAddRows = false;
                this.GridView.DataSource = ds;
                searchValue = lblAsset.Text;
                SelectData();
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

        public void BindData()
        {
                var ds = (from c in db.ViewAllData
                          select new
                          {
                              c.AssetID,
                              c.Service_Tag,
                              c.Type,
                              c.Model,
                              c.Spec,
                              c.User,
                              c.Level,
                              c.Location,
                              c.Monitor,
                              c.IP,
                              c.Remark,
                              c.Supplier,
                              c.Warranty,
                              c.StartDate,
                              c.EndDate,
                              c.ModifiedBy,
                              c.UpdateTime,
                              c.Status
                          }
                          ).ToList();

                if (ds.Count > 0)
                {
                    this.GridView.AutoGenerateColumns = false;
                    this.GridView.AllowUserToAddRows = false;
                    this.GridView.DataSource = ds;
                    searchValue = lblAsset.Text;
                    SelectData();
                }
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strAsset = GridView.CurrentRow.Cells[0].Value.ToString();
            this.lblAsset.Text = strAsset;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            strAsset = GridView.CurrentRow.Cells[0].Value.ToString();
            if(MessageBox.Show(string.Format("Are you ssure to delete {0}?", strAsset), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (var db = new myDatabaseEntities())
                {
                    var del = (from c in db.RFS_Asset
                               where c.asset_list == strAsset
                               select c).FirstOrDefault();
                    if(del != null)
                    {
                        db.RFS_Asset.Remove(del);
                    }
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Delete Successfully."));
                }
                BindData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            strAsset = GridView.CurrentRow.Cells[0].Value.ToString();
            var form = new frmUpdate();
            form._strAsset = strAsset;
            form.ShowDialog();
            BindData();
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

        private void txtSearch1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SearchData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;
                ws.Cells[1, 1] = "Asset ID";
                ws.Cells[1, 2] = "Service Tag";
                ws.Cells[1, 3] = "Type";
                ws.Cells[1, 4] = "Model";
                ws.Cells[1, 5] = "Spec";
                ws.Cells[1, 6] = "User";
                ws.Cells[1, 7] = "Level";
                ws.Cells[1, 8] = "Location";
                ws.Cells[1, 9] = "Monitor";
                ws.Cells[1, 10] = "IP Address";
                ws.Cells[1, 11] = "Remark";
                ws.Cells[1, 12] = "Supplier";
                ws.Cells[1, 13] = "Warranty";
                ws.Cells[1, 14] = "StartDate";
                ws.Cells[1, 15] = "EndDate";
                for (int i = 0; i < GridView.Rows.Count; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        ws.Cells[i + 2, j + 1] = "'"+GridView.Rows[i].Cells[j].Value;
                    }
                };
            }
            catch (Exception ex)
            {
                string text = ex + "";
            }
        }
    }
}
