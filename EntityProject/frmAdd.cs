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
    public partial class frmAdd : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string imgLoc = "";
        byte[] img = null;
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            StringEmpty();
            LoadType();
            LoadLocation();
            LoadMonitor();
            LoadStatus();
            LoadDepartment();
            LoadSupplier();
        }
        public void ConvertImage()
        {
            try
            {
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
            }
            catch (Exception)
            {
                img = null;
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
                var ds= (from T in db.RFS_Asset_monitor
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
                return;
            }
        }

        public void StringEmpty()
        {
            this.txtAssetId.Text = string.Empty;
            this.txtIP.Text = string.Empty;
            this.txtRemark.Text = string.Empty;
            this.txtServiceTag.Text = string.Empty;
            this.txtSpec.Text = string.Empty;
            this.cbDepart.Text = string.Empty;
            this.cbLocation.Text = string.Empty;
            this.cbModel.Text = string.Empty;
            this.cbMonitor.Text = string.Empty;
            this.cbStatus.Text = string.Empty;
            this.cbType.Text = string.Empty;
            this.cbUser.Text = string.Empty;
        }

        public void InsertChkStatusMonitor()
        {
            var ds = (from c in db.RFS_Asset_monitor
                      where c.asset_list_m == cbMonitor.Text
                      select c).FirstOrDefault();
            if (ds != null)
            {
                ds.check_status = "1";
            }
            db.SaveChanges();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConvertImage();
            try
            {
                string strAssetId = this.txtAssetId.Text;
                string strServiceTag = this.txtServiceTag.Text;
                string strModel = this.cbModel.SelectedValue.ToString();
                string strSpec = this.txtSpec.Text;
                string strLocation = this.cbLocation.SelectedValue.ToString();
                string strIP = this.txtIP.Text;
                string strRemark = this.txtRemark.Text;
                string strStatus = this.cbStatus.SelectedValue.ToString();
                string strMonitor;
                if (chkMonitor.Checked == true)
                {
                    strMonitor = this.cbMonitor.SelectedValue.ToString();
                }
                else
                {
                    strMonitor = null;
                }
                string strUser = this.cbUser.SelectedValue.ToString();
                string strSupplier = this.cbSupplier.SelectedValue.ToString();
                DateTime strWarrantyStart = DateTime.Parse(dtStart.Text);
                DateTime strWarrantyEnd = DateTime.Parse(dtEnd.Text);
                var ds = (from c in db.RFS_Asset
                          where c.asset_list == strAssetId
                                ||
                                c.service_tag == strServiceTag
                          select c).FirstOrDefault();

                var mon = (from c in db.RFS_Asset_monitor
                           where c.asset_list_m == strAssetId
                           select c).Count();

                if (ds != null || mon > 0)
                {
                    MessageBox.Show(string.Format("Asset Id {0} Exists in table.", strAssetId +
                                                  "Service Tag {0} Exists in table.", strServiceTag));
                }
                else
                {
                    db.RFS_Asset.Add(new RFS_Asset()
                    {
                        asset_list = strAssetId,
                        service_tag = strServiceTag,
                        model_id = strModel,
                        processor = strSpec,
                        ip = strIP,
                        dep_id_2 = strLocation,
                        status = strRemark,
                        asset_list_m = strMonitor,
                        em_id = strUser,
                        sup_id = strSupplier,
                        start_date = strWarrantyStart,
                        end_date = strWarrantyEnd,
                        img = img
                    });
                    InsertChkStatusMonitor();
                    db.SaveChanges();
                    MessageBox.Show("Pass");
                    ChkMonitor();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("IsNotNULL");
                return;
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

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            ChkMonitor();
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
    }
}
