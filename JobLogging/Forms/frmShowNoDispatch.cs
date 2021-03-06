﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JobLogging.JobLoggingModel;

namespace JobLogging.Forms
{
    public partial class frmShowNoDispatch : XtraForm
    {
        private readonly JobLoggingModelContainer _context = new JobLoggingModelContainer();
      
        public frmShowNoDispatch(bool isAppointment=false)
        {
            InitializeComponent();
            repositoryItemCheckedComboBoxEdit_Staff.DataSource = _context.Users.Where(u => u.IsActivate && u.IsEngineer == true).ToList();
            if (isAppointment)
            {
                _context.JobOrders.Where(j => j.Appointment <= DateTime.Now && string.IsNullOrEmpty(j.Staffs)).Load();
                if (!_context.JobOrders.Local.Any())
                {
                    Close();
                    Dispose();
                }
            }
            else
            {
                _context.JobOrders.Where(j => string.IsNullOrEmpty(j.Staffs)).Load();
            }
            jobOrderBindingSource.DataSource = _context.JobOrders.Local.ToBindingList();
        }

        private void frmShowNoDispatch_Load(object sender, EventArgs e)
        {

            if (!GlobalParams.HasPermission("修改派工"))
            {
                gridView1.OptionsBehavior.Editable = false;
                btnOk.Enabled = false;
            }
            if (!GlobalParams.HasPermission("删除派工"))
            {
                btnDeleteSelected.Enabled = false;
            }

            gridView1.BestFitColumns();
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

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("请选择要删除的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if (XtraMessageBox.Show("确定要删除选择的记录吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            //    return;

            var ids = gridView1.GetSelectedRows().Select(rowHandle => gridView1.GetRowCellValue(rowHandle, colID)).ToList();
            var jobs = _context.JobOrders.Local.Where(j=>ids.Contains(j.ID));
            foreach (var jobOrder in jobs.ToList())
            {
                _context.JobOrders.Local.Remove(jobOrder);
            }
            
            
            //XtraMessageBox.Show("记录已删除！");
        }

        private void frmShowNoDispatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_context.ChangeTracker.Entries().Any(t => t.State != EntityState.Unchanged))
            {
                var dialogResult = XtraMessageBox.Show("修改的数据还未保存,是保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    btnOk.PerformClick();}
                else if (dialogResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void frmShowNoDispatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}