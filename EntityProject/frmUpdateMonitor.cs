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
    public partial class frmUpdateMonitor : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        string imgLoc = "";
        byte[] img = null;
        Boolean chkImage = false;
        public frmUpdateMonitor()
        {
            InitializeComponent();
        }
        public string _strAsset { get; set; }

        private void frmUpdateMonitor_Load(object sender, EventArgs e)
        {
            
            StringEmpty();
            LoadType_m();
            LoadSupplier();
            LoadStatus();
            GetData();
            LoadImage();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConvertImage();
            try
            {
                var ds = (from c in db.RFS_Asset_monitor
                          where c.asset_list_m == _strAsset
                          select c).FirstOrDefault();
                //Chk ServiceTag
                /*var stg = (from c in db.RFS_Asset 
                           where c.service_tag == this.txtServiceTag.Text
                           select c).Count();*/
                if (ds != null)
                {
                    ds.monitor_id = this.txtMonitorId.Text;
                    //string Type = cbType.SelectedValue.ToString();
                    ds.model_id_m = this.cbModel.SelectedValue.ToString();
                    ds.status = this.txtRemark.Text;
                    ds.Activate_id = Convert.ToInt32(cbStatus.SelectedValue);
                    ds.sup_id = this.cbSupplier.SelectedValue.ToString();            
                    //ds.warranty_year = Convert.ToInt32(cbTime.Text);
                    ds.start_date = DateTime.Parse(dtStart.Text);
                    ds.end_date = DateTime.Parse(dtEnd.Text);
                    if (chkImage != true)
                    {
                        ds.img = img;
                    }

                }
                db.SaveChanges();
                MessageBox.Show("Pass");
            }
            catch (Exception)
            {
                
                return;
            }
          
        }
       
        public void GetData()
        {
            var ds = (from c in db.ViewAssetMonitor
                      where c.Asset_ID == _strAsset
                      select new
                      {
                          c.Asset_ID,
                          c.Monitor_ID,
                          c.Type,
                          c.Model,
                          c.Remark,
                          c.Supplier,
                          c.StartDate,
                          c.EndDate,
                          c.Status,
                          c.ModifiedBy,
                          c.UpdateTime
                      }).FirstOrDefault();
            if (ds != null)
            {
                this.txtAssetId.Text = ds.Asset_ID;
                this.txtMonitorId.Text = ds.Monitor_ID;
                this.cbType.Text = ds.Type;
                this.cbModel.Text = ds.Model;
                this.txtRemark.Text = ds.Remark;
                this.cbStatus.Text = ds.Status;
                this.cbSupplier.Text = ds.Supplier;
                this.dtStart.Text = ds.StartDate.ToString();
                this.dtEnd.Text = ds.EndDate.ToString();
            }
        }
        public void LoadType_m()
        {
            var ds = (from T in db.RFS_Type_monitor
                      select new
                      {
                          T.type_id_m,
                          T.type_name_m,
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

   
        public void LoadImage()
        {
           try
            {
                var first = db.RFS_Asset_monitor.FirstOrDefault(p => p.asset_list_m == _strAsset);
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

            }
        }


        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchModelByType_m();
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
