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
    public partial class frmEmployee : Form
    {
        string strEmployeeID;
        string strEmployeeT;
        string strEmployeeE;
        string strEmPosition;
        string strDepName;
        string strEmLevel;
        private DateTime em_st;
        myDatabaseEntities db = new myDatabaseEntities();

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDepartment();
        }

        public void LoadDepartment()
        {
            var ds = (from c in db.RFS_Department
                      select new
                      {
                          c.dep_id,
                          c.dep_name
                      }).ToList();
            cbDepartment.DataSource = ds;
            cbDepartment.DisplayMember = "dep_name";
            cbDepartment.ValueMember = "dep_id";
        }


        public void LoadData()
        {
            var ds = (from c in db.ViewEmployee
                      select new
                      {
                          c.em_id,
                          c.em_name_th,
                          c.em_name_eng,
                          c.em_position,
                          c.dep_name,
                          c.em_level,
                          c.em_start,

                      }).ToList();
            if (ds.Count > 0)
            {
                this.GridView.DataSource = ds;
            }
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textEmployeeID.Text = GridView.SelectedRows[0].Cells[0].Value + string.Empty;
            textThaiName.Text = GridView.SelectedRows[0].Cells[1].Value + string.Empty;
            textEnglishName.Text = GridView.SelectedRows[0].Cells[2].Value + string.Empty;
            cbDepartment.Text = GridView.SelectedRows[0].Cells[3].Value + string.Empty;
            cbPosition.Text = GridView.SelectedRows[0].Cells[4].Value + string.Empty;
            cbLevel.Text = GridView.SelectedRows[0].Cells[5].Value + string.Empty;
            dateStartDate.Text = Convert.ToString(GridView.SelectedRows[0].Cells[6].Value + string.Empty);


        }

        private void GridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(GridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            strEmployeeID = this.textEmployeeID.Text;
            strEmployeeT = this.textThaiName.Text;
            strEmployeeE = this.textEnglishName.Text;
            strEmPosition = this.cbPosition.Text;
            strDepName = this.cbDepartment.Text;
            strEmLevel = this.cbLevel.Text;
            em_st = DateTime.Parse(dateStartDate.Text);

            var ds = (from c in db.RFS_Employee //เอาค่าไปใส่ ds
                      where c.em_id == strEmployeeID
                      select c).FirstOrDefault();


            if (textEmployeeID.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && textEmployeeID.Text != "")
            {
                db.RFS_Employee.Add(new RFS_Employee()
                {
                    em_id = strEmployeeID,
                    em_name_eng = strEmployeeE,
                    em_name_th = strEmployeeT,
                    dep_id = cbDepartment.SelectedValue.ToString(),
                    em_position = strEmPosition,
                    em_level = strEmLevel,
                    em_start = em_st,


                });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();

            }
            else
            {
                try//ดักerror
                {
                    ds.em_name_th = strEmployeeT;
                    ds.em_name_eng = strEmployeeE;
                    ds.em_position = strEmPosition;
                    ds.dep_id = cbDepartment.SelectedValue.ToString();
                    ds.em_level = strEmLevel;
                    ds.em_start = em_st;
                }
                catch (Exception)
                {

                }

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            strEmployeeID = textEmployeeID.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strEmployeeID), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Employee //เอาค่าไปใส่ ds
                           where c.em_id == strEmployeeID
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Employee.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }

        private void butExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;
                ws.Cells[1, 1] = "Employee ID";
                ws.Cells[1, 2] = "Thai Name";
                ws.Cells[1, 3] = "English Name";
                ws.Cells[1, 4] = "Department";
                ws.Cells[1, 5] = "Position";
                ws.Cells[1, 6] = "Level";
                ws.Cells[1, 7] = "Start Date";

                for (int i = 0; i < GridView.Rows.Count; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        ws.Cells[i + 2, j + 1] = "'" + GridView.Rows[i].Cells[j].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                string text = ex + "";
            }
        }

    }
}
