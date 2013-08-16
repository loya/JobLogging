using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JobLogging.JobLoggingModel;

namespace JobLogging.Forms
{
    public partial class frmNewPassword : DevExpress.XtraEditors.XtraForm
    {
        private readonly User _user;

        public frmNewPassword(User user)
        {
            InitializeComponent();
            _user = user;
            txtNewPassword.Focus();}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (var context=new JobLoggingModelContainer())
            {
                context.Users.Attach(_user);
                _user.Password = txtNewPassword.Text;
                context.SaveChanges();
            }
            Close();
        }
    }}