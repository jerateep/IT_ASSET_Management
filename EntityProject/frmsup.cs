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
    public partial class frmsup : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string strSupID;
        string strSupName;
        string strTel;
        string strFax;
        string strEmail;
        string strAdd;
        string strTex;
        public frmsup()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var ds = (from c in db.RFS_Supplier
                      select new
                      {
                          c.sup_id,
                          c.sup_name,
                          c.sup_tel,
                          c.sup_fax,
                          c.sup_mail,
                          c.sup_address,
                          c.sup_tex

                      }).ToList();
            if (ds.Count > 0)
            {
                dataGridSup.DataSource = ds;
            }
        }

        private void frmsup_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridSup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//ดักerror
            {
                txtSupID.Text = dataGridSup.CurrentRow.Cells[0].Value.ToString();
                txtSupName.Text = dataGridSup.CurrentRow.Cells[1].Value.ToString();
                txtTel.Text = dataGridSup.CurrentRow.Cells[2].Value.ToString();
                txtFax.Text = dataGridSup.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dataGridSup.CurrentRow.Cells[4].Value.ToString();
                txtAdd.Text = dataGridSup.CurrentRow.Cells[5].Value.ToString();
                txtTex.Text = dataGridSup.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            strSupID = this.txtSupID.Text;
            strSupName = this.txtSupName.Text;
            strTel = this.txtTel.Text;
            strFax = this.txtFax.Text;
            strEmail = this.txtEmail.Text;
            strAdd = this.txtAdd.Text;
            strTex = this.txtTex.Text;


            var ds = (from c in db.RFS_Supplier //เอาค่าไปใส่ ds
                      where c.sup_id == strSupID
                      select c).FirstOrDefault();


            if (txtSupID.Text == "")
            {
                MessageBox.Show("ห้ามว่าง");
            }
            if (ds == null && txtSupID.Text != "")
            {
                db.RFS_Supplier.Add(new RFS_Supplier()
                {
                    sup_id = strSupID,
                    sup_name = strSupName,
                    sup_tel = strTel,
                    sup_fax = strFax,
                    sup_mail = strEmail,
                    sup_address = strAdd,
                    sup_tex = strTex


                });

                db.SaveChanges();
                MessageBox.Show("pass");
                LoadData();

            }
            else
            {
                try//ดักerror
                {
                    ds.sup_name = strSupName;
                    ds.sup_tel = strTel;
                    ds.sup_fax = strFax;
                    ds.sup_mail = strEmail;
                    ds.sup_address = strAdd;
                    ds.sup_tex = strTex;
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
            strSupID = txtSupID.Text;
            if (MessageBox.Show(string.Format("Are you sure to delete{0}?", strSupID), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Supplier //เอาค่าไปใส่ ds
                           where c.sup_id == strSupID
                           select c).FirstOrDefault();

                if (del != null)
                {
                    db.RFS_Supplier.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                LoadData();
            }
        }

        private void dataGridSup_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridSup.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b,
                e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;
                ws.Cells[1, 1] = "Supplier ID";
                ws.Cells[1, 2] = "Name";
                ws.Cells[1, 3] = "Tel";
                ws.Cells[1, 4] = "Fax";
                ws.Cells[1, 5] = "E-mail";
                ws.Cells[1, 6] = "Address";
                ws.Cells[1, 7] = "Tex";
                for (int i = 0; i<dataGridSup.Rows.Count; i++)
                {
                    for (int j = 0; j < 7; j++ )
                    {
                        ws.Cells[i + 2, j + 1] = "'" + dataGridSup.Rows[i].Cells[j].Value;
                    }
                }
            }
            catch(Exception ex)
            {
                string text = ex + "";
            }
        }
    }
}
