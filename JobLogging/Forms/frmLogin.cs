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

            using (var bll = new JobLoggingModelContainer())
            {
                _loginUser = bll.Users.Include("Role").Include("Role.Permissions").SingleOrDefault(u => u.LoginName == txtLoginName.Text && u.Password == txtPassword.Text);
            }
            if (_loginUser == null)
            {
                XtraMessageBox.Show("用户名或密码错误！");
                txtLoginName.Focus();
            }
            else if (!_loginUser.IsActivate)
            {
                XtraMessageBox.Show("用户名无效！");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Properties.Settings.Default.LastUser = txtLoginName.Text;
                Settings.Default.Save();
                Close();
            }
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