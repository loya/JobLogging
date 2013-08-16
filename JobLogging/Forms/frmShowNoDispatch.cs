using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JobLogging.Forms
{
    public partial class frmShowNoDispatch : XtraForm
    {
        private readonly JobLoggingModel.JobLoggingModelContainer _context = new JobLoggingModel.JobLoggingModelContainer();
        public frmShowNoDispatch()
        {
            InitializeComponent();
            repositoryItemCheckedComboBoxEdit_Staff.DataSource = _context.Users.ToList();
            jobOrderBindingSource.DataSource = _context.JobOrders.Where(j => string.IsNullOrEmpty(j.Staffs)).ToList();
        }

        private void frmShowNoDispatch_Load(object sender, EventArgs e)
        {
            
        }

        private void btanCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_context.ChangeTracker.Entries().Any(t => t.State != EntityState.Unchanged))
            {
                _context.SaveChanges();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }
    }
}