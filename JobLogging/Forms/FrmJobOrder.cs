﻿using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JobLogging.JobLoggingModel;

namespace JobLogging.Forms
{
    public partial class FrmJobOrder : XtraForm
    {
        public JobLoggingModelContainer Context { get; set; }
        int _focusedRowHandle;
        private JobOrder _newJobOrder;
        public FrmJobOrder()
        {
            InitializeComponent();

            dateEdit_StaffOut.DateTime = DateTime.Today;

            _InitDataBind();
            entityInstantFeedbackSource1.GetQueryable += entityInstantFeedbackSource1_GetQueryable;
            entityInstantFeedbackSource1.DismissQueryable += entityInstantFeedbackSource1_DismissQueryable;
        }
        private void _InitDataBind()
        {
            Context = new JobLoggingModelContainer();

            Context.Users.Where(u=>u.IsActivate && u.IsEngineer==true).Load();
            userBindingSource.DataSource = Context.Users.Local.ToBindingList();userBindingSource.Sort = "Sort desc";

            jobOrderBindingSource.DataSource = Context.JobOrders.Local.ToBindingList();
            //StaffsTextEdit.Properties.DataSource = Context.Users.OrderByDescending(t => t.Sort);jobOrderBindingSource.DataSource = Context.JobOrders;
            //This line of code is generated by Data Source Configuration Wizard
            //entityServerModeSource1.QueryableSource = Context.JobOrders.AsNoTracking();
        }

        private void FrmJobOrder_Load(object sender, EventArgs e)
        {
            InitUserRelated();
        }

        private void InitUserRelated()
        {
            bBtnDeleteJobOrder.Enabled = GlobalParams.HasPermission("删除派工");
            btnNoDispatch.Enabled = GlobalParams.HasPermission("派工分配");
        }

        // This event is generated by Data Source Configuration Wizard
        private void entityInstantFeedbackSource1_GetQueryable(object sender,
                                                               GetQueryableEventArgs e)
        {
            var c = new JobLoggingModelContainer();
            var query = Context.JobOrders.AsNoTracking();
            e.QueryableSource = c.JobOrders.AsNoTracking();
            e.Tag = c;
        }

        // This event is generated by Data Source Configuration Wizard
        private void entityInstantFeedbackSource1_DismissQueryable(object sender,
                                                                   GetQueryableEventArgs e)
        {

            // Dispose of the DataContext
            ((JobLoggingModelContainer)e.Tag).Dispose();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                //this.gridView1.IndicatorWidth = Convert.ToInt32(e.Info.DisplayText.Length * e.Info.Appearance.Font.SizeInPoints);
            }
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            //var id = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "ID"));
            //jobOrderBindingSource.DataSource = Context.JobOrders.Where(t => t.ID == id);
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //var id = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "ID"));
            ////jobOrderBindingSource.DataSource = Context.JobOrders.Local.Where(t => t.ID == id);
            //var et = Context.JobOrders.Find(id);
            //jobOrderBindingSource.Position = jobOrderBindingSource.IndexOf(et);
        }

        private bool _skipFocusedRowChangedEvent;
        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            //判断修改派工记录权限
            if (!GlobalParams.CurrentLoginUser.Role.Permissions.Any(p => p.Name == "修改派工"))
            {
                return;
            }
            if (_skipFocusedRowChangedEvent)
            {
                _skipFocusedRowChangedEvent = false;
                return;
            }

            if (jobOrderBindingSource.Current != null &&
                (Context.Entry(jobOrderBindingSource.Current).State == EntityState.Modified ||
                (Context.Entry(jobOrderBindingSource.Current).State == EntityState.Added)))
            {
                if (XtraMessageBox.Show("当前数据未保存，是否保存或取消修改？", "提示", MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)
                {
                    if (!dxValidationProvider1.Validate())
                    {
                        _skipFocusedRowChangedEvent = true;
                        gridView1.FocusedRowHandle = e.PrevFocusedRowHandle;
                        return;
                    }
                    //Context.SaveChanges();
                    //_focusedRowHandle = e.FocusedRowHandle;

                    //var job = Context.JobOrders.Find(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
                    //jobOrderBindingSource.Position = jobOrderBindingSource.IndexOf(job);
                    //entityInstantFeedbackSource1.Refresh();
                    //alertControl1.Show(this, "提示", "修改已保存");
                    btnSaveJobOrder.PerformClick();
                }
                else
                {
                    //todo 取消修改
                    var jobOrder = Context.JobOrders.Find(gridView1.GetRowCellValue(e.PrevFocusedRowHandle, "ID"));
                    if (jobOrder != null)
                    {
                    Context.Entry(jobOrder).Reload();
                    }
                    jobOrderBindingSource.CancelEdit();
                }
            }
            var job = Context.JobOrders.Find(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
            jobOrderBindingSource.Position = jobOrderBindingSource.IndexOf(job);

        }

        private void gridView1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
           
        }

        private void gridView1_AsyncCompleted(object sender, EventArgs e)
        {
            if (jobOrderBindingSource.Current != null && Context.Entry((JobOrder)jobOrderBindingSource.Current).State != EntityState.Added)
            {
                gridView1.FocusedRowHandle = _focusedRowHandle;
            }
            gridView1.SetRowExpanded(-1, true);
            gridView1.BestFitColumns();
            gridView1.Columns["Staffs"].Width = gridView1.CalcColumnBestWidth(gridView1.Columns["Staffs"]) + 5;

            StaffOutCountDataBind();
        }

        private void jobOrderBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new JobOrder { Date = DateTime.Today, CreateBy = GlobalParams.CurrentLoginUser.Name, CreateDate = DateTime.Now };
        }

        private void btnSaveJobOrder_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                return;
            }
            jobOrderBindingSource.EndEdit();
            if (Context.Entry(jobOrderBindingSource.Current).State != EntityState.Unchanged)
            {
                Context.SaveChanges();

                _focusedRowHandle = gridView1.FocusedRowHandle;
                gridView1.SelectRow(-1);
                gridView1.FocusedRowHandle = -1;
                entityInstantFeedbackSource1.Refresh();
                //entityServerModeSource1.Reload();
                alertControl1.Show(this, "提示", "数据已保存!");
            }
        }

        private void btnAddJobOrder_Click(object sender, EventArgs e)
        {
            //var job = new JobOrder {Date = DateTime.Now, CreateDate = DateTime.Now};
            //var t = (JobOrder)jobOrderBindingSource.AddNew();
            //t.Date = DateTime.Now;
            //t.CreateDate = DateTime.Now;
            if (jobOrderBindingSource.Current != null)
            {
                if (!dxValidationProvider1.Validate())
                {
                    return;
                }
                btnSaveJobOrder.PerformClick();
            }

            _newJobOrder = (JobOrder)jobOrderBindingSource.AddNew();

            // ServiceTagTextEdit.Focus();
            //StaffsTextEdit.ShowPopup();
            ServiceTagTextEdit.Focus();
        }

        private void btnGridViewRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            _InitDataBind();
            _focusedRowHandle = gridView1.FocusedRowHandle;
            gridView1.FocusedRowHandle = -1;
            entityInstantFeedbackSource1.Refresh();
            //userBindingSource.DataSource = null;
            //StaffsTextEdit.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            jobOrderBindingSource.CancelEdit();
        }

        private void bBtnDeleteJobOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.IsGroupRow(gridView1.FocusedRowHandle))
            {
                XtraMessageBox.Show("请选择要删除的记录");
                return;
            }
            if (XtraMessageBox.Show("确定要删除选择的记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            if (gridView1.GetSelectedRows().Count() > 1)
            {
                var sbID = new StringBuilder();
                foreach (var id in gridView1.GetSelectedRows())
                {
                    sbID.AppendFormat("{0},", gridView1.GetRowCellValue(id, "ID"));
                }
                string sql = string.Format("delete JobOrders where ID in ({0})", sbID.Remove(sbID.Length - 1, 1));
                Context.Database.ExecuteSqlCommand(sql);
            }
            else
            {
                jobOrderBindingSource.RemoveCurrent();
                Context.SaveChanges();
            }
            gridView1.FocusedRowHandle = -1;
            entityInstantFeedbackSource1.Refresh();
            alertControl1.Show(this, "提示", "记录已删除！");

        }

        private void dxValidationProvider1_ValidationFailed(object sender,
                                                            ValidationFailedEventArgs e)
        {
            e.InvalidControl.Focus();
        }

        private void StaffOutCountDataBind()
        {
            if (Context == null) return;
            lbStaffOut.DataSource = Context.Users.Local.Where(u => u.IsActivate && u.IsEngineer == true).OrderByDescending(u => u.Sort).Select(t => new
                     {
                         t.ID,
                         Staff = t.Name + " （" + Context.JobOrders.Count(j => j.Staffs != null && j.Staffs.Contains(t.Name) && j.Date == dateEdit_StaffOut.DateTime) + "）",
                         imageIndex = t.IsDuty == true ? 0 : -1
                     }).ToList();
            //var userName = Context.Users.Where(u => u.IsDuty == true).Select(u => u.Name).SingleOrDefault();
            //if (!string.IsNullOrEmpty(userName))
            //{
            //    ((ImageListBoxItem) lbStaffOut.image(lbStaffOut.FindString(userName))).ImageIndex = 0;
            //}

            btnNoDispatch.Text = string.Format("未派工（{0}）",
                Context.JobOrders.Count(j => j.Staffs == null || j.Staffs == ""));
        }

        private void bBtnShowFindPanel_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
        }

        private void btnNoDispatch_Click(object sender, EventArgs e)
        {
            if (new frmShowNoDispatch().ShowDialog() == DialogResult.OK)
            {
                bbtnGridViewRefresh.PerformClick();
            }
        }

        private void lbStaffOut_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(!GlobalParams.HasPermission("设置值班"))
                return;
            int index = lbStaffOut.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                var query = Context.Users.Local.Where(u => u.IsDuty == true);
                foreach (var user in query)
                {
                    user.IsDuty = false;
                }
                Context.Users.Find(lbStaffOut.SelectedValue).IsDuty = true;
                Context.SaveChanges();
                StaffOutCountDataBind();
                lbStaffOut.SetSelected(index, true);
            }

        }

        private void dateEdit_StaffOut_EditValueChanged(object sender, EventArgs e)
        {
            StaffOutCountDataBind();
        }



    }
}