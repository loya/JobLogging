using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using JobLogging.JobLoggingModel;
using JobLogging.Properties;

namespace JobLogging.Forms
{
    public partial class frmLogin : XtraForm
    {
        private User _loginUser;
        public User LoginUser
        {
            get { return _loginUser; }
        }

        public frmLogin()
        {
            InitializeComponent();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginName.Focus();
            txtLoginName.Text = Settings.Default.LastUser;
            txtDataSource.Text = Settings.Default.DataSource;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            SplashScreenManager.Default.SetWaitFormDescription("登录中...");
            using (var context = new JobLoggingModelContainer())
            {
                _loginUser = context.Users.Include("Role").Include("Role.Permissions").SingleOrDefault(u => u.LoginName == txtLoginName.Text);

                if (_loginUser == null || _loginUser.Password != txtPassword.Text)
                {
                    XtraMessageBox.Show("用户名或密码错误！", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoginName.Focus();
                }
                else if (!_loginUser.IsActivate)
                {
                    XtraMessageBox.Show("用户名无效！", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Properties.Settings.Default.LastUser = txtLoginName.Text;
                    Settings.Default.Save();

                    //时间同步
                    var localTimeSync = new Common.LocalTimeSync(context);
                    if (!localTimeSync.CheckSyncTime())
                    {
                        SplashScreenManager.Default.SetWaitFormDescription("正在同步服务器时间...");
                        localTimeSync.SyncServerTime();
                    }
                    Close();

                }
            }
            SplashScreenManager.CloseForm();     
        }

        private void TextEdit_Enter(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }

        private void txtDataSource_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var dialogResult = new frmDbConfig().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtDataSource.Text = Settings.Default.DataSource;
            }
        }
    }
}