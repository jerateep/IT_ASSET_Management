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
    public partial class frmLogin : Form
    {
        myDatabaseEntities db = new myDatabaseEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Login();
            }
        }

        public void Login()
        {
            var ds = (from l in db.RFS_Login
                      where l.username == txtUserName.Text
                      &&
                      l.password == txtPassword.Text
                      select l).FirstOrDefault();
            if (ds != null)
            {
                var frmMain = new frmMain();
              
                frmMain._UserName = ds.name;
                frmMain._Permission = Convert.ToInt32(ds.permission);
              
                frmMain.Show();
          
                this.Hide();
            }
            else
            {
                MessageBox.Show("Can not access the system.", "Notifications");
                txtPassword.Clear();
            }
        }
    }
}
