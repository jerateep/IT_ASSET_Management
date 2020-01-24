using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
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
        string initLDAPPath = "dc="", dc="";
        string initLDAPServer = "";
        string initShortDomainName = "";
        string strErrMsg;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Ldap(txtUserName.Text, txtPassword.Text);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Ldap(txtUserName.Text, txtPassword.Text);
            }
        }

        public void Login()
        {

            var ds = (from l in db.RFS_Login
                      where l.username == txtUserName.Text
                      select l).FirstOrDefault();
            if (ds != null)
            {
                var frmMain = new frmMain();
                frmMain._UserName = txtUserName.Text;
                frmMain._Permission = Convert.ToInt32(ds.permission);
                frmMain.Show();
                this.Hide();
            }
            else
            {
                var frmMain = new frmMain();
                frmMain._UserName = txtUserName.Text;
                frmMain._Permission = 2;
                frmMain.Show();
                this.Hide();
            }
        }

        public void Ldap(string User, string Pwd)
        {
            string DomainAndUsername = "";
            string strCommu;
            bool flgLogin = false;
            strCommu = ("LDAP://"
                        + (initLDAPServer + ("/" + initLDAPPath)));
            DomainAndUsername = (initShortDomainName + ("\\" + User));
            DirectoryEntry entry = new DirectoryEntry(strCommu, DomainAndUsername, Pwd);
            object obj;
            try
            {
                obj = entry.NativeObject;
                DirectorySearcher search = new DirectorySearcher(entry);
                SearchResult result;
                search.Filter = ("(SAMAccountName="
                            + (User + ")"));
                search.PropertiesToLoad.Add("cn");
                result = search.FindOne();
                if ((result == null))
                {
                    flgLogin = false;
                    strErrMsg = "Please check user/password";
                }
                else
                {
                    flgLogin = true;
                }
            }
            catch (Exception ex)
            {
                flgLogin = false;
                strErrMsg = "Please check user/password";
            }
            if ((flgLogin == true))
            {
                Login();
            }
            else
            {
                MessageBox.Show(strErrMsg);
            }
        }
    }
}
