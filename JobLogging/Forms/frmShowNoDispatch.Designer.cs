﻿namespace JobLogging.Forms
{
    partial class frmShowNoDispatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowNoDispatch));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.jobOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit_Date = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colAppointment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit_appointment = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colStaffs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckedComboBoxEdit_Staff = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.colServiceTag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btanCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteSelected = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Date.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_appointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_appointment.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.jobOrderBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckedComboBoxEdit_Staff,
            this.repositoryItemDateEdit_appointment,
            this.repositoryItemDateEdit_Date});
            this.gridControl1.Size = new System.Drawing.Size(1184, 524);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // jobOrderBindingSource
            // 
            this.jobOrderBindingSource.DataSource = typeof(JobLogging.JobLoggingModel.JobOrder);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.TopNewRow.Options.UseForeColor = true;
            this.gridView1.ColumnPanelRowHeight = 28;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDate,
            this.colAppointment,
            this.colStaffs,
            this.colServiceTag,
            this.colCustomerName,
            this.colContact,
            this.colAddress,
            this.colDescription,
            this.colResult,
            this.colMemo,
            this.colCreateBy,
            this.colCreateDate,
            this.colModifyBy,
            this.colModifyDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupFormat = "[#image]{1} {2}";
            this.gridView1.GroupRowHeight = 28;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsSelection.InvertSelection = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.RowHeight = 28;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colModifyDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colDate.AppearanceCell.Options.UseForeColor = true;
            this.colDate.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colDate.AppearanceHeader.Options.UseForeColor = true;
            this.colDate.Caption = "上门时间";
            this.colDate.ColumnEdit = this.repositoryItemDateEdit_Date;
            this.colDate.DisplayFormat.FormatString = "f";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // repositoryItemDateEdit_Date
            // 
            this.repositoryItemDateEdit_Date.AutoHeight = false;
            this.repositoryItemDateEdit_Date.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_Date.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemDateEdit_Date.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_Date.EditFormat.FormatString = "f";
            this.repositoryItemDateEdit_Date.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit_Date.Mask.EditMask = "f";
            this.repositoryItemDateEdit_Date.Name = "repositoryItemDateEdit_Date";
            // 
            // colAppointment
            // 
            this.colAppointment.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colAppointment.AppearanceCell.Options.UseForeColor = true;
            this.colAppointment.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colAppointment.AppearanceHeader.Options.UseForeColor = true;
            this.colAppointment.Caption = "预约";
            this.colAppointment.ColumnEdit = this.repositoryItemDateEdit_appointment;
            this.colAppointment.DisplayFormat.FormatString = "f";
            this.colAppointment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAppointment.FieldName = "Appointment";
            this.colAppointment.Name = "colAppointment";
            this.colAppointment.Visible = true;
            this.colAppointment.VisibleIndex = 2;
            // 
            // repositoryItemDateEdit_appointment
            // 
            this.repositoryItemDateEdit_appointment.AutoHeight = false;
            this.repositoryItemDateEdit_appointment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_appointment.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemDateEdit_appointment.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_appointment.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.repositoryItemDateEdit_appointment.DisplayFormat.FormatString = "f";
            this.repositoryItemDateEdit_appointment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit_appointment.EditFormat.FormatString = "f";
            this.repositoryItemDateEdit_appointment.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit_appointment.Mask.EditMask = "f";
            this.repositoryItemDateEdit_appointment.Name = "repositoryItemDateEdit_appointment";
            this.repositoryItemDateEdit_appointment.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colStaffs
            // 
            this.colStaffs.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colStaffs.AppearanceCell.Options.UseForeColor = true;
            this.colStaffs.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colStaffs.AppearanceHeader.Options.UseForeColor = true;
            this.colStaffs.Caption = "派工";
            this.colStaffs.ColumnEdit = this.repositoryItemCheckedComboBoxEdit_Staff;
            this.colStaffs.FieldName = "Staffs";
            this.colStaffs.Name = "colStaffs";
            this.colStaffs.Visible = true;
            this.colStaffs.VisibleIndex = 3;
            // 
            // repositoryItemCheckedComboBoxEdit_Staff
            // 
            this.repositoryItemCheckedComboBoxEdit_Staff.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit_Staff.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit_Staff.DisplayMember = "Name";
            this.repositoryItemCheckedComboBoxEdit_Staff.Name = "repositoryItemCheckedComboBoxEdit_Staff";
            this.repositoryItemCheckedComboBoxEdit_Staff.ValueMember = "Name";
            // 
            // colServiceTag
            // 
            this.colServiceTag.Caption = "服务编号/快服";
            this.colServiceTag.FieldName = "ServiceTag";
            this.colServiceTag.Name = "colServiceTag";
            this.colServiceTag.OptionsColumn.AllowEdit = false;
            this.colServiceTag.OptionsColumn.AllowFocus = false;
            this.colServiceTag.Visible = true;
            this.colServiceTag.VisibleIndex = 4;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "用户姓名";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.OptionsColumn.AllowFocus = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 5;
            // 
            // colContact
            // 
            this.colContact.Caption = "联系方式";
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.OptionsColumn.AllowEdit = false;
            this.colContact.OptionsColumn.AllowFocus = false;
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 6;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "地址";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 7;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "问题描述";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.AllowFocus = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            // 
            // colResult
            // 
            this.colResult.Caption = "处理结果";
            this.colResult.FieldName = "Result";
            this.colResult.Name = "colResult";
            this.colResult.OptionsColumn.AllowEdit = false;
            this.colResult.OptionsColumn.AllowFocus = false;
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 9;
            // 
            // colMemo
            // 
            this.colMemo.Caption = "备注";
            this.colMemo.FieldName = "Memo";
            this.colMemo.Name = "colMemo";
            this.colMemo.OptionsColumn.AllowEdit = false;
            this.colMemo.OptionsColumn.AllowFocus = false;
            this.colMemo.Visible = true;
            this.colMemo.VisibleIndex = 10;
            // 
            // colCreateBy
            // 
            this.colCreateBy.Caption = "创建";
            this.colCreateBy.FieldName = "CreateBy";
            this.colCreateBy.Name = "colCreateBy";
            this.colCreateBy.OptionsColumn.AllowEdit = false;
            this.colCreateBy.OptionsColumn.AllowFocus = false;
            this.colCreateBy.Visible = true;
            this.colCreateBy.VisibleIndex = 11;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "创建时间";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.AllowEdit = false;
            this.colCreateDate.OptionsColumn.AllowFocus = false;
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 12;
            // 
            // colModifyBy
            // 
            this.colModifyBy.Caption = "修改";
            this.colModifyBy.FieldName = "ModifyBy";
            this.colModifyBy.Name = "colModifyBy";
            this.colModifyBy.OptionsColumn.AllowEdit = false;
            this.colModifyBy.OptionsColumn.AllowFocus = false;
            // 
            // colModifyDate
            // 
            this.colModifyDate.Caption = "修改时间";
            this.colModifyDate.FieldName = "ModifyDate";
            this.colModifyDate.Name = "colModifyDate";
            this.colModifyDate.OptionsColumn.AllowEdit = false;
            this.colModifyDate.OptionsColumn.AllowFocus = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(935, 531);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "保 存";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btanCancel
            // 
            this.btanCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btanCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btanCancel.Location = new System.Drawing.Point(1097, 531);
            this.btanCancel.Name = "btanCancel";
            this.btanCancel.Size = new System.Drawing.Size(75, 23);
            this.btanCancel.TabIndex = 2;
            this.btanCancel.Text = "取消";
            this.btanCancel.Click += new System.EventHandler(this.btanCancel_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelected.Location = new System.Drawing.Point(1016, 531);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSelected.TabIndex = 3;
            this.btnDeleteSelected.Text = "删 选";
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // frmShowNoDispatch
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btanCancel;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btanCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmShowNoDispatch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "未派工列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShowNoDispatch_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShowNoDispatch_FormClosed);
            this.Load += new System.EventHandler(this.frmShowNoDispatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Date.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_appointment.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_appointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit_Staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffs;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTag;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraGrid.Columns.GridColumn colMemo;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDate;
        private System.Windows.Forms.BindingSource jobOrderBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btanCancel;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit_Staff;
        private DevExpress.XtraEditors.SimpleButton btnDeleteSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colAppointment;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_appointment;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_Date;
    }
}