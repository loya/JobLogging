using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using JobLogging.JobLoggingModel;

namespace JobLogging.Forms
{
    public partial class frmAddPermission : DevExpress.XtraEditors.XtraForm
    {
        private readonly JobLoggingModelContainer _context;
        private readonly Permission _parentPermission;
        private readonly bool _isEdit;

        public frmAddPermission(JobLoggingModelContainer context,Permission parentPermission,bool isEdit=false)
        {
            InitializeComponent();
            _context = context;
            _parentPermission=parentPermission;
            _isEdit = isEdit;
        }


        private void frmAddPermission_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                chkRootNode.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPromissionName.Text == "")
            {
                txtPromissionName.ErrorText = "权限名称不能为空!";
                return;
            }
                
            if (_context.Permissions.Count(p => p.Name == txtPromissionName.Text) > 0)
            {
               //var err =new ErrorProvider();
               // err.SetError(txtPromissionName, "该权限已存在,请重新输入!");
               // err.SetIconAlignment(txtPromissionName, ErrorIconAlignment.MiddleLeft);
                txtPromissionName.ErrorText = "该权限已存在,请重新输入!";return;

            }

            if (_isEdit)
            {
                _parentPermission.Name = txtPromissionName.Text;}
            else
            {
                if (chkRootNode.Checked)
                {
                    _context.Permissions.Add(new Permission {Name = txtPromissionName.Text});
                }
                else
                {
                    _parentPermission.ChildPermissions.Add(new Permission {Name = txtPromissionName.Text});
                }
            }
            _context.SaveChanges();
            this.Close();
        }
    }
}