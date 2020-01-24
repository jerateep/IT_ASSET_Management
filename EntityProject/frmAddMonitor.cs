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
    public partial class frmAddMonitor : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string imgLoc = "";
        byte[] img = null;
        public string _UserName { get; set; }
        public frmAddMonitor()
        {
            InitializeComponent();
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

        private void frmAddMonitor_Load(object sender, EventArgs e)
        {
            lblUser.Text = _UserName;
            StringEmpty();
            LoadType_m();
            LoadStatus();
            LoadSupplier();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            ConvertImage();
            try
            {
                string strAssetId = this.txtAssetId.Text;
                string strMonitorID = this.txtMonitorId.Text;
                string strType_m = this.cbType.SelectedValue.ToString();
                string strModel_m = this.cbModel.SelectedValue.ToString();
                string strRemark = this.txtRemark.Text;
                string strSupplier = this.cbSupplier.SelectedValue.ToString();
                int IntAC = Convert.ToInt32(cbStatus.SelectedValue);
                DateTime strWarrantyStart = DateTime.Parse(dtStart.Text);
                DateTime strWarrantyEnd = DateTime.Parse(dtEnd.Text);
                var ds = (from c in db.RFS_Asset_monitor
                          where c.asset_list_m == strAssetId
                                ||
                                c.monitor_id == strMonitorID
                          select c).FirstOrDefault();

                var chkAsset = (from c in db.RFS_Asset
                                where c.asset_list == strAssetId
                                select c).Count();

                if (ds != null || chkAsset > 0)
                {
                    MessageBox.Show(string.Format("Asset Id {0} Exists in table.", strAssetId +
                                                  "Service Tag {0} Exists in table.", strMonitorID));
                }
                else
                {
                    db.RFS_Asset_monitor.Add(new RFS_Asset_monitor()
                    {
                        asset_list_m = strAssetId,
                        monitor_id = strMonitorID,
                        model_id_m = strModel_m,
                        status = strRemark,
                        sup_id = strSupplier,
                        Activate_id = IntAC,
                        start_date = strWarrantyStart,
                        end_date = strWarrantyEnd,
                        check_status = "0",
                        user_insert = lblUser.Text,
                        user_update = lblUser.Text,
                        date_insert = DateTime.Now,
                        date_update = DateTime.Now,
                        img = img
                    });

                    db.SaveChanges();
                    MessageBox.Show("Pass");
                    this.Close();
                }
            }
            
            catch (Exception)
            {
                MessageBox.Show("IsNotNULL");
                return;
            }
        }
        
        public void LoadType_m()
        {
            var ds = (from T in db.RFS_Type_monitor
                      select new
                      {
                          T.type_id_m,
                          T.type_name_m
                      }
                      ).ToList();
            cbType.DataSource = ds;
            cbType.DisplayMember = "type_name_m";
            cbType.ValueMember = "type_id_m";
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
        public void SearchModelByType_m()
        {
            try
            {
                var ds = (from T in db.RFS_Model_Asset_m
                          where T.type_id_m == "" + cbType.SelectedValue + ""
                          select new
                          {
                              T.model_id_m,
                              T.model_name_m,
                              T.type_id_m
                          }
                          ).ToList();
                cbModel.DataSource = ds;
                cbModel.DisplayMember = "model_name_m";
                cbModel.ValueMember = "model_id_m";
            }
            catch (Exception)
            {
                return;
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchModelByType_m();
        }
        public void StringEmpty()
        {
            this.txtAssetId.Text = string.Empty;
            this.txtMonitorId.Text = string.Empty;
            this.cbType.Text = string.Empty;
            this.cbModel.Text = string.Empty;
            this.txtRemark.Text = string.Empty;
            this.cbStatus.Text = string.Empty;
            this.cbSupplier.Text = string.Empty;
            this.dtStart.Text = string.Empty;
            this.dtEnd.Text = string.Empty;
      
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
    }
}
