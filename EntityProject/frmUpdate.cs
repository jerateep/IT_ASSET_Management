using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class frmUpdate : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string imgLoc = "";
        byte[] img = null;
        Boolean chkImage = false;
        public frmUpdate()
        {
            InitializeComponent();
        }

        public string _strAsset { get; set; }
        
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            StringEmpty();
            LoadType();
            LoadLocation();
            LoadMonitor();
            LoadStatus();
            LoadDepartment();
            LoadSupplier();
            LoadSoftware();
            GetData();
            SearchSoftwareByAsset();
            LoadImage();
        }
        public void GetData()
        {
            var ds = (from c in db.ViewAllData
                      where c.AssetID == _strAsset
                      select new
                      {
                          c.AssetID,
                          c.Service_Tag,
                          c.Type,
                          c.Model,
                          c.Spec,
                          c.Department,
                          c.User,
                          c.Level,
                          c.Location,
                          c.Monitor,
                          c.IP,
                          c.Remark,
                          c.Supplier,
                          //c.Warranty,
                          c.StartDate,
                          c.EndDate,
                          c.ModifiedBy,
                          c.UpdateTime,
                          c.Status
                      }).FirstOrDefault();
            if (ds != null)
            {
                this.txtAssetId.Text = ds.AssetID;
                this.txtServiceTag.Text = ds.Service_Tag;
                this.cbType.Text = ds.Type;
                this.cbModel.Text = ds.Model;
                this.txtSpec.Text = ds.Spec;
                this.cbLocation.Text = ds.Location;
                this.txtIP.Text = ds.IP;
                this.txtRemark.Text = ds.Remark;
                this.cbStatus.Text = ds.Status;
                this.cbMonitor.Text = ds.Monitor;
                this.lblMonitor.Text = ds.Monitor;
                this.cbDepart.Text = ds.Department;
                this.cbUser.Text = ds.User;
                this.cbSupplier.Text = ds.Supplier;
                //this.cbTime.Text = ds.Warranty.ToString();
                this.dtStart.Text = ds.StartDate.ToString();
                this.dtEnd.Text = ds.EndDate.ToString();
            }
        }

        public void LoadImage()
        {
            try
            {
                var first = db.RFS_Asset.FirstOrDefault(p => p.asset_list == _strAsset);
                if (first != null)
                {
                    using (var ms = new MemoryStream(first.img))
                    {
                        using (var image = Image.FromStream(ms))
                        {
                            picAsset.Image = (Image)image.Clone();
                            chkImage = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                //picAsset.Image = null;
            }

        }

        public void ConvertImage()
        {
            try
            {
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                chkImage = false;
            }
            catch (Exception)
            {
                //return;
            }
        }

        public void ChkMonitor()
        {
            if (chkMonitor.Checked == true)
            {
                cbMonitor.Enabled = true;
            }
            else
            {
                cbMonitor.Enabled = false;
            }
        }

        public void LoadSoftware()
        {
            var ds = (from T in db.RFS_Software
                      select new
                      {
                          T.software_id,
                          T.software_name
                      }
                      ).ToList();
            cbSoftware.DataSource = ds;
            cbSoftware.DisplayMember = "software_name";
            cbSoftware.ValueMember = "software_id";
        }

        public void LoadSupplier()
        {
            var ds = (from T in db.RFS_Supplier
                      select new
                      {
                          T.sup_id,
                          T.sup_name
                      }
                      ).ToList();
            cbSupplier.DataSource = ds;
            cbSupplier.DisplayMember = "sup_name";
            cbSupplier.ValueMember = "sup_id";
        }

        public void LoadDepartment()
        {
            var ds = (from T in db.RFS_Department
                      select new
                      {
                          T.dep_id,
                          T.dep_name
                      }
                      ).ToList();
            cbDepart.DataSource = ds;
            cbDepart.DisplayMember = "dep_name";
            cbDepart.ValueMember = "dep_id";
        }

        public void LoadLocation()
        {
            var ds = (from T in db.RFS_Department_2
                      select new
                      {
                          T.dep_id_2,
                          T.dep_name_2
                      }
                      ).ToList();
            cbLocation.DataSource = ds;
            cbLocation.DisplayMember = "dep_name_2";
            cbLocation.ValueMember = "dep_id_2";
        }

        public void LoadType()
        {
            var ds = (from T in db.RFS_Type
                      select new
                      {
                          T.type_id,
                          T.type_name
                      }
                      ).ToList();
            cbType.DataSource = ds;
            cbType.DisplayMember = "type_name";
            cbType.ValueMember = "type_id";
        }

        public void LoadStatus()
        {
            var ds = (from T in db.RFS_Activate
                      select new
                      {
                          T.Activate_id,
                          T.Activate_name
                      }
          ).ToList();
            cbStatus.DataSource = ds;
            cbStatus.DisplayMember = "Activate_name";
            cbStatus.ValueMember = "Activate_id";
        }

        public void LoadMonitor()
        {
            try
            {
                var ds = (from T in db.RFS_Asset_monitor
                          where T.check_status == "0"
                          select new
                          {
                              T.asset_list_m,
                              T.check_status,
                          }
                          ).ToList();
                cbMonitor.DataSource = ds;
                cbMonitor.DisplayMember = "asset_list_m";
                cbMonitor.ValueMember = "asset_list_m";
            }
            catch (Exception)
            {
                return;
            }
        }

        public void SearchEmployeeByDepart()
        {
            try
            {
                var ds = (from T in db.RFS_Employee
                          where T.dep_id == "" + cbDepart.SelectedValue + ""
                          select new
                          {
                              T.em_id,
                              T.em_name_th
                          }
                          ).ToList();
                cbUser.DataSource = ds;
                cbUser.DisplayMember = "em_name_th";
                cbUser.ValueMember = "em_id";
            }
            catch (Exception)
            {
                return;
            }
        }

        public void SearchModelByType()
        {
            try
            {
                var ds = (from T in db.RFS_Model_Asset
                          where T.type_id == "" + cbType.SelectedValue + ""
                          select new
                          {
                              T.model_id,
                              T.model_name,
                              T.type_id
                          }
                          ).ToList();
                cbModel.DataSource = ds;
                cbModel.DisplayMember = "model_name";
                cbModel.ValueMember = "model_id";
            }
            catch (Exception)
            {

            }
        }

        public void SearchSoftwareByAsset()
        {
            try
            {
                var ds = (from T in db.ViewSoftware
                          where T.AssetId == _strAsset
                          select new
                          {
                              T.SoftwareName,
                              T.Detail
                          }
                          ).ToList();
                if (ds.Count > 0)
                {
                    //this.GridSoftwate.AutoGenerateColumns = false;
                    //this.GridSoftwate.AllowUserToAddRows = false;
                    this.GridSoftwate.DataSource = ds;
                }
            }
            catch (Exception)
            {

            }
        }

        public void StringEmpty()
        {
            this.txtAssetId.Text = string.Empty;
            this.txtIP.Text = string.Empty;
            this.txtRemark.Text = string.Empty;
            this.txtServiceTag.Text = string.Empty;
            this.txtSpec.Text = string.Empty;
            this.txtDetail.Text = string.Empty;
            this.cbDepart.Text = string.Empty;
            this.cbLocation.Text = string.Empty;
            this.cbModel.Text = string.Empty;
            this.cbMonitor.Text = string.Empty;
            this.cbStatus.Text = string.Empty;
            this.cbType.Text = string.Empty;
            this.cbUser.Text = string.Empty;
            this.cbSoftware.Text = string.Empty;
        }

        public void InsertChkStatusMonitor()
        {
            var ds = (from c in db.RFS_Asset_monitor
                      where c.asset_list_m == cbMonitor.Text
                      select c).FirstOrDefault();
            if (ds != null)
            {
                //ds.asset_list = this.txtAssetId.Text;
                ds.check_status = "1";
            }
            db.SaveChanges();
            if (lblMonitor.Text != "")
            {
                var dsa = (from c in db.RFS_Asset_monitor
                           where c.asset_list_m == lblMonitor.Text
                           select c).FirstOrDefault();
                if (dsa != null)
                {
                    //ds.asset_list = this.txtAssetId.Text;
                    dsa.check_status = "0";
                }
                db.SaveChanges();
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchModelByType();
        }

        private void cbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchEmployeeByDepart();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConvertImage();
            try
            {
                var ds = (from c in db.RFS_Asset
                          where c.asset_list == _strAsset
                          select c).FirstOrDefault();
                //Chk ServiceTag
                /*var stg = (from c in db.RFS_Asset 
                           where c.service_tag == this.txtServiceTag.Text
                           select c).Count();*/
                if (ds != null)
                {
                    ds.service_tag = this.txtServiceTag.Text;
                    string Type = cbType.SelectedValue.ToString();
                    ds.model_id = this.cbModel.SelectedValue.ToString();
                    ds.processor = this.txtSpec.Text;
                    ds.dep_id_2 = this.cbLocation.SelectedValue.ToString();
                    ds.ip = this.txtIP.Text;
                    ds.status = this.txtRemark.Text;
                    ds.Activate_id = Convert.ToInt32(cbStatus.SelectedValue);
                    if (chkMonitor.Checked == true)
                    {
                        ds.asset_list_m = this.cbMonitor.SelectedValue.ToString();
                        InsertChkStatusMonitor();
                    }
                    else
                    {
                        if(lblMonitor.Text == "")
                        {
                            ds.asset_list_m = null;
                        }
                        else
                        {
                            ds.asset_list_m = lblMonitor.Text;
                        }

                    }
                    ds.em_id = this.cbUser.SelectedValue.ToString();
                    ds.sup_id = this.cbSupplier.SelectedValue.ToString();
                    //ds.warranty_year = Convert.ToInt32(cbTime.Text);
                    ds.start_date = DateTime.Parse(dtStart.Text);
                    ds.end_date = DateTime.Parse(dtEnd.Text);
                    if(chkImage != true)
                    {
                        ds.img = img;
                    }

                }
                db.SaveChanges();
                MessageBox.Show("Pass");
            }
            catch (Exception)
            {
                MessageBox.Show("Check ServiceTag Or Null");
                return;
            }
            LoadMonitor();
            GetData();
        }

        private void GridSoftwate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbSoftware.Text = GridSoftwate.SelectedRows[0].Cells[4].Value + string.Empty; ;
            txtDetail.Text = GridSoftwate.SelectedRows[0].Cells[5].Value + string.Empty; ;
        }

        private void GridSoftwate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(GridSoftwate.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG File (*.jpg)|*.jpg|GIF File (*.gif)|*.gif|All File (*.*)|*.*";
                dlg.Title = "Select Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picAsset.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG File (*.jpg)|*.jpg|GIF File (*.gif)|*.gif|All File (*.*)|*.*";
            save.FilterIndex = 4;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                picAsset.Image.Save(save.FileName);
            }

        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            try
            {
                string strSoftware = this.cbSoftware.SelectedValue.ToString();
                string strDetail = this.txtDetail.Text;
                var ds = (from c in db.RFS_Asset_Software
                          where c.asset_list == _strAsset
                                &&
                                c.software_id == strSoftware
                          select c).FirstOrDefault();
                if (ds == null)
                {
                    db.RFS_Asset_Software.Add(new RFS_Asset_Software()
                    {
                        asset_list = _strAsset,
                        software_id = strSoftware,
                        as_detail = this.txtDetail.Text
                    });
                    db.SaveChanges();
                    MessageBox.Show("Add New Software");
                }
                else
                {
                    ds.as_detail = this.txtDetail.Text;
                    db.SaveChanges();
                    MessageBox.Show("Update Software");
                }
                SearchSoftwareByAsset();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnDelSoftware_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Are you sure to delete {0}?", cbSoftware.Text), "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del = (from c in db.RFS_Asset_Software
                           where
                           c.asset_list == _strAsset
                           &&
                           c.software_id == cbSoftware.SelectedValue.ToString()
                           select c).FirstOrDefault();
                if (del != null)
                {
                    db.RFS_Asset_Software.Remove(del);
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
            }
            SearchSoftwareByAsset();
        }

        private void btnDelMonitor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Are you sure to delete {0}?", lblMonitor.Text), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var chkmon = (from c in db.RFS_Asset_monitor
                          where c.asset_list_m == lblMonitor.Text
                          select c).FirstOrDefault();

                if (chkmon != null)
                {
                    chkmon.check_status = "0";
                }
                db.SaveChanges();

                var ds = (from c in db.RFS_Asset
                          where c.asset_list == _strAsset
                          select c).FirstOrDefault();

                if (ds != null)
                {
                    ds.asset_list_m = null;
                }
                db.SaveChanges();
                MessageBox.Show(string.Format("Delete Successfully."));
                lblMonitor.Text = "";
                LoadMonitor();
                GetData();
            }
        }
    }
}
