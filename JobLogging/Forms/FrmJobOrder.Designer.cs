namespace JobLogging.Forms
{
    partial class FrmJobOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJobOrder));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStaffs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AppointmentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.jobOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnGridViewRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnAddJobOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnDeleteJobOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnSaveJobOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnShowFindPanel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddJobOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveJobOrder = new DevExpress.XtraEditors.SimpleButton();
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ServiceTagTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ContactTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CreateByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StaffsTextEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.ModifyByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ModifyDateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ResultTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MemoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CreateDateDateEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForModifyBy = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForModifyDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStaffs = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForCustomerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMemo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreateBy = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContact = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForServiceTag = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppointment = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbStaffOut = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnNoDispatch = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit_StaffOut = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTagTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStaffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbStaffOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_StaffOut.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_StaffOut.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colStaffs
            // 
            this.colStaffs.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStaffs.AppearanceCell.Options.UseFont = true;
            this.colStaffs.Caption = "派工";
            this.colStaffs.FieldName = "Staffs";
            this.colStaffs.Name = "colStaffs";
            this.colStaffs.Visible = true;
            this.colStaffs.VisibleIndex = 3;
            // 
            // AppointmentDateEdit
            // 
            this.AppointmentDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Appointment", true));
            this.AppointmentDateEdit.EditValue = null;
            this.AppointmentDateEdit.Location = new System.Drawing.Point(500, 12);
            this.AppointmentDateEdit.MenuManager = this.ribbonControl1;
            this.AppointmentDateEdit.Name = "AppointmentDateEdit";
            this.AppointmentDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.AppointmentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AppointmentDateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.AppointmentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AppointmentDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.AppointmentDateEdit.Properties.Mask.EditMask = "";
            this.AppointmentDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AppointmentDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.AppointmentDateEdit.Size = new System.Drawing.Size(156, 20);
            this.AppointmentDateEdit.StyleController = this.dataLayoutControl1;
            this.AppointmentDateEdit.TabIndex = 22;
            this.AppointmentDateEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.AppointmentDateEdit_ParseEditValue);
            this.AppointmentDateEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AppointmentDateEdit_KeyUp);
            // 
            // jobOrderBindingSource
            // 
            this.jobOrderBindingSource.DataSource = typeof(JobLogging.JobLoggingModel.JobOrder);
            this.jobOrderBindingSource.Sort = "ID";
            this.jobOrderBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.jobOrderBindingSource_AddingNew);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbtnGridViewRefresh,
            this.bBtnAddJobOrder,
            this.bBtnDeleteJobOrder,
            this.bBtnSaveJobOrder,
            this.bBtnCancel,
            this.bBtnShowFindPanel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1066, 145);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // bbtnGridViewRefresh
            // 
            this.bbtnGridViewRefresh.Caption = "刷新";
            this.bbtnGridViewRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnGridViewRefresh.Glyph")));
            this.bbtnGridViewRefresh.Id = 1;
            this.bbtnGridViewRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnGridViewRefresh.LargeGlyph")));
            this.bbtnGridViewRefresh.Name = "bbtnGridViewRefresh";
            this.bbtnGridViewRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGridViewRefresh_ItemClick);
            // 
            // bBtnAddJobOrder
            // 
            this.bBtnAddJobOrder.Caption = "新增";
            this.bBtnAddJobOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnAddJobOrder.Glyph")));
            this.bBtnAddJobOrder.Id = 2;
            this.bBtnAddJobOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnAddJobOrder.LargeGlyph")));
            this.bBtnAddJobOrder.Name = "bBtnAddJobOrder";
            this.bBtnAddJobOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnAddJobOrder_ItemClick);
            // 
            // bBtnDeleteJobOrder
            // 
            this.bBtnDeleteJobOrder.Caption = "删除";
            this.bBtnDeleteJobOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnDeleteJobOrder.Glyph")));
            this.bBtnDeleteJobOrder.Id = 3;
            this.bBtnDeleteJobOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnDeleteJobOrder.LargeGlyph")));
            this.bBtnDeleteJobOrder.Name = "bBtnDeleteJobOrder";
            this.bBtnDeleteJobOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnDeleteJobOrder_ItemClick);
            // 
            // bBtnSaveJobOrder
            // 
            this.bBtnSaveJobOrder.Caption = "保存";
            this.bBtnSaveJobOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnSaveJobOrder.Glyph")));
            this.bBtnSaveJobOrder.Id = 4;
            this.bBtnSaveJobOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnSaveJobOrder.LargeGlyph")));
            this.bBtnSaveJobOrder.Name = "bBtnSaveJobOrder";
            this.bBtnSaveJobOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnSaveJobOrder_ItemClick);
            // 
            // bBtnCancel
            // 
            this.bBtnCancel.Caption = "取消";
            this.bBtnCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnCancel.Glyph")));
            this.bBtnCancel.Id = 5;
            this.bBtnCancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnCancel.LargeGlyph")));
            this.bBtnCancel.Name = "bBtnCancel";
            this.bBtnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnCancel_ItemClick);
            // 
            // bBtnShowFindPanel
            // 
            this.bBtnShowFindPanel.Caption = "查找";
            this.bBtnShowFindPanel.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnShowFindPanel.Glyph")));
            this.bBtnShowFindPanel.Id = 11;
            this.bBtnShowFindPanel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnShowFindPanel.LargeGlyph")));
            this.bBtnShowFindPanel.Name = "bBtnShowFindPanel";
            this.bBtnShowFindPanel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnShowFindPanel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "派工记录";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnGridViewRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnShowFindPanel);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnAddJobOrder, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnSaveJobOrder);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnDeleteJobOrder);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "编辑";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnCancel);
            this.dataLayoutControl1.Controls.Add(this.btnAddJobOrder);
            this.dataLayoutControl1.Controls.Add(this.btnSaveJobOrder);
            this.dataLayoutControl1.Controls.Add(this.DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ServiceTagTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustomerNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateByTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StaffsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IDSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyByTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyDateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ResultTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MemoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.AppointmentDateEdit);
            this.dataLayoutControl1.DataSource = this.jobOrderBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForModifyBy,
            this.ItemForModifyDate,
            this.ItemForCreateDate});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 145);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(374, 410, 250, 421);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1066, 129);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(980, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.StyleController = this.dataLayoutControl1;
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddJobOrder
            // 
            this.btnAddJobOrder.Location = new System.Drawing.Point(777, 89);
            this.btnAddJobOrder.Name = "btnAddJobOrder";
            this.btnAddJobOrder.Size = new System.Drawing.Size(97, 23);
            this.btnAddJobOrder.StyleController = this.dataLayoutControl1;
            this.btnAddJobOrder.TabIndex = 20;
            this.btnAddJobOrder.Text = "保存并新增(&N)";
            this.btnAddJobOrder.Click += new System.EventHandler(this.btnAddJobOrder_Click);
            // 
            // btnSaveJobOrder
            // 
            this.btnSaveJobOrder.Location = new System.Drawing.Point(888, 89);
            this.btnSaveJobOrder.Name = "btnSaveJobOrder";
            this.btnSaveJobOrder.Size = new System.Drawing.Size(78, 23);
            this.btnSaveJobOrder.StyleController = this.dataLayoutControl1;
            this.btnSaveJobOrder.TabIndex = 16;
            this.btnSaveJobOrder.Text = "保存(&S)";
            this.btnSaveJobOrder.Click += new System.EventHandler(this.btnSaveJobOrder_Click);
            // 
            // DateDateEdit
            // 
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Date", true));
            this.DateDateEdit.EditValue = new System.DateTime(2013, 8, 1, 0, 0, 0, 0);
            this.DateDateEdit.EnterMoveNextControl = true;
            this.DateDateEdit.Location = new System.Drawing.Point(280, 12);
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.DateDateEdit.Properties.DisplayFormat.FormatString = "f";
            this.DateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateDateEdit.Properties.Mask.EditMask = "f";
            this.DateDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.DateDateEdit.Size = new System.Drawing.Size(135, 20);
            this.DateDateEdit.StyleController = this.dataLayoutControl1;
            this.DateDateEdit.TabIndex = 5;
            // 
            // ServiceTagTextEdit
            // 
            this.ServiceTagTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "ServiceTag", true));
            this.ServiceTagTextEdit.EnterMoveNextControl = true;
            this.ServiceTagTextEdit.Location = new System.Drawing.Point(500, 36);
            this.ServiceTagTextEdit.Name = "ServiceTagTextEdit";
            this.ServiceTagTextEdit.Size = new System.Drawing.Size(156, 20);
            this.ServiceTagTextEdit.StyleController = this.dataLayoutControl1;
            this.ServiceTagTextEdit.TabIndex = 7;
            // 
            // CustomerNameTextEdit
            // 
            this.CustomerNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "CustomerName", true));
            this.CustomerNameTextEdit.EnterMoveNextControl = true;
            this.CustomerNameTextEdit.Location = new System.Drawing.Point(280, 36);
            this.CustomerNameTextEdit.Name = "CustomerNameTextEdit";
            this.CustomerNameTextEdit.Size = new System.Drawing.Size(135, 20);
            this.CustomerNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CustomerNameTextEdit.TabIndex = 8;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "不能为空";
            this.dxValidationProvider1.SetValidationRule(this.CustomerNameTextEdit, conditionValidationRule1);
            // 
            // ContactTextEdit
            // 
            this.ContactTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Contact", true));
            this.ContactTextEdit.EnterMoveNextControl = true;
            this.ContactTextEdit.Location = new System.Drawing.Point(63, 36);
            this.ContactTextEdit.Name = "ContactTextEdit";
            this.ContactTextEdit.Size = new System.Drawing.Size(132, 20);
            this.ContactTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactTextEdit.TabIndex = 9;
            // 
            // AddressTextEdit
            // 
            this.AddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Address", true));
            this.AddressTextEdit.EnterMoveNextControl = true;
            this.AddressTextEdit.Location = new System.Drawing.Point(741, 36);
            this.AddressTextEdit.Name = "AddressTextEdit";
            this.AddressTextEdit.Size = new System.Drawing.Size(313, 20);
            this.AddressTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressTextEdit.TabIndex = 10;
            // 
            // CreateByTextEdit
            // 
            this.CreateByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "CreateBy", true));
            this.CreateByTextEdit.Enabled = false;
            this.CreateByTextEdit.Location = new System.Drawing.Point(967, 12);
            this.CreateByTextEdit.Name = "CreateByTextEdit";
            this.CreateByTextEdit.Properties.AllowFocused = false;
            this.CreateByTextEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateByTextEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.CreateByTextEdit.Properties.ReadOnly = true;
            this.CreateByTextEdit.Size = new System.Drawing.Size(87, 20);
            this.CreateByTextEdit.StyleController = this.dataLayoutControl1;
            this.CreateByTextEdit.TabIndex = 14;
            this.CreateByTextEdit.TabStop = false;
            this.CreateByTextEdit.Tag = "";
            // 
            // StaffsTextEdit
            // 
            this.StaffsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Staffs", true));
            this.StaffsTextEdit.EnterMoveNextControl = true;
            this.StaffsTextEdit.Location = new System.Drawing.Point(741, 12);
            this.StaffsTextEdit.Name = "StaffsTextEdit";
            this.StaffsTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StaffsTextEdit.Properties.DataSource = this.userBindingSource;
            this.StaffsTextEdit.Properties.DisplayMember = "Name";
            this.StaffsTextEdit.Properties.ValueMember = "Name";
            this.StaffsTextEdit.Size = new System.Drawing.Size(141, 20);
            this.StaffsTextEdit.StyleController = this.dataLayoutControl1;
            this.StaffsTextEdit.TabIndex = 6;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals;
            compareAgainstControlValidationRule1.Control = this.AppointmentDateEdit;
            compareAgainstControlValidationRule1.ErrorText = "预约为空时派工不能为空！";
            this.dxValidationProvider1.SetValidationRule(this.StaffsTextEdit, compareAgainstControlValidationRule1);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(JobLogging.JobLoggingModel.User);
            // 
            // IDSpinEdit
            // 
            this.IDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "ID", true));
            this.IDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IDSpinEdit.Enabled = false;
            this.IDSpinEdit.Location = new System.Drawing.Point(63, 12);
            this.IDSpinEdit.Name = "IDSpinEdit";
            this.IDSpinEdit.Properties.AllowFocused = false;
            this.IDSpinEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDSpinEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.IDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.IDSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IDSpinEdit.Properties.ReadOnly = true;
            this.IDSpinEdit.Size = new System.Drawing.Size(132, 20);
            this.IDSpinEdit.StyleController = this.dataLayoutControl1;
            this.IDSpinEdit.TabIndex = 4;
            this.IDSpinEdit.Tag = "";
            this.IDSpinEdit.EditValueChanged += new System.EventHandler(this.IDSpinEdit_EditValueChanged);
            this.IDSpinEdit.TextChanged += new System.EventHandler(this.IDSpinEdit_TextChanged);
            // 
            // ModifyByTextEdit
            // 
            this.ModifyByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "ModifyBy", true));
            this.ModifyByTextEdit.Location = new System.Drawing.Point(80, 150);
            this.ModifyByTextEdit.Name = "ModifyByTextEdit";
            this.ModifyByTextEdit.Size = new System.Drawing.Size(974, 20);
            this.ModifyByTextEdit.StyleController = this.dataLayoutControl1;
            this.ModifyByTextEdit.TabIndex = 18;
            // 
            // ModifyDateTextEdit
            // 
            this.ModifyDateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "ModifyDate", true));
            this.ModifyDateTextEdit.Location = new System.Drawing.Point(80, 150);
            this.ModifyDateTextEdit.Name = "ModifyDateTextEdit";
            this.ModifyDateTextEdit.Size = new System.Drawing.Size(974, 20);
            this.ModifyDateTextEdit.StyleController = this.dataLayoutControl1;
            this.ModifyDateTextEdit.TabIndex = 19;
            // 
            // ResultTextEdit
            // 
            this.ResultTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Result", true));
            this.ResultTextEdit.EnterMoveNextControl = true;
            this.ResultTextEdit.Location = new System.Drawing.Point(407, 60);
            this.ResultTextEdit.Name = "ResultTextEdit";
            this.ResultTextEdit.Size = new System.Drawing.Size(249, 20);
            this.ResultTextEdit.StyleController = this.dataLayoutControl1;
            this.ResultTextEdit.TabIndex = 12;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Description", true));
            this.DescriptionTextEdit.EnterMoveNextControl = true;
            this.DescriptionTextEdit.Location = new System.Drawing.Point(63, 60);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(259, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 11;
            // 
            // MemoTextEdit
            // 
            this.MemoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "Memo", true));
            this.MemoTextEdit.EnterMoveNextControl = true;
            this.MemoTextEdit.Location = new System.Drawing.Point(741, 60);
            this.MemoTextEdit.Name = "MemoTextEdit";
            this.MemoTextEdit.Size = new System.Drawing.Size(313, 20);
            this.MemoTextEdit.StyleController = this.dataLayoutControl1;
            this.MemoTextEdit.TabIndex = 13;
            // 
            // CreateDateDateEdit
            // 
            this.CreateDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobOrderBindingSource, "CreateDate", true));
            this.CreateDateDateEdit.EditValue = new System.DateTime(2013, 8, 11, 0, 0, 0, 0);
            this.CreateDateDateEdit.Enabled = false;
            this.CreateDateDateEdit.Location = new System.Drawing.Point(948, 12);
            this.CreateDateDateEdit.Name = "CreateDateDateEdit";
            this.CreateDateDateEdit.Properties.AllowFocused = false;
            this.CreateDateDateEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateDateDateEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.CreateDateDateEdit.Properties.ReadOnly = true;
            this.CreateDateDateEdit.Size = new System.Drawing.Size(106, 20);
            this.CreateDateDateEdit.StyleController = this.dataLayoutControl1;
            this.CreateDateDateEdit.TabIndex = 15;
            this.CreateDateDateEdit.TabStop = false;
            // 
            // ItemForModifyBy
            // 
            this.ItemForModifyBy.Control = this.ModifyByTextEdit;
            this.ItemForModifyBy.CustomizationFormText = "Modify By";
            this.ItemForModifyBy.Location = new System.Drawing.Point(0, 138);
            this.ItemForModifyBy.Name = "ItemForModifyBy";
            this.ItemForModifyBy.Size = new System.Drawing.Size(1046, 24);
            this.ItemForModifyBy.Text = "Modify By";
            this.ItemForModifyBy.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForModifyBy.TextToControlDistance = 5;
            // 
            // ItemForModifyDate
            // 
            this.ItemForModifyDate.Control = this.ModifyDateTextEdit;
            this.ItemForModifyDate.CustomizationFormText = "Modify Date";
            this.ItemForModifyDate.Location = new System.Drawing.Point(0, 0);
            this.ItemForModifyDate.Name = "ItemForModifyDate";
            this.ItemForModifyDate.Size = new System.Drawing.Size(1046, 102);
            this.ItemForModifyDate.Text = "Modify Date";
            this.ItemForModifyDate.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForModifyDate.TextToControlDistance = 5;
            // 
            // ItemForCreateDate
            // 
            this.ItemForCreateDate.Control = this.CreateDateDateEdit;
            this.ItemForCreateDate.CustomizationFormText = "创建日期";
            this.ItemForCreateDate.Location = new System.Drawing.Point(885, 0);
            this.ItemForCreateDate.Name = "ItemForCreateDate";
            this.ItemForCreateDate.Size = new System.Drawing.Size(161, 24);
            this.ItemForCreateDate.Text = "创建日期";
            this.ItemForCreateDate.TextSize = new System.Drawing.Size(48, 14);
            this.ItemForCreateDate.TextToControlDistance = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1066, 129);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID,
            this.ItemForDescription,
            this.ItemForDate,
            this.ItemForStaffs,
            this.emptySpaceItem1,
            this.ItemForCustomerName,
            this.ItemForResult,
            this.ItemForMemo,
            this.ItemForAddress,
            this.ItemForCreateBy,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.ItemForContact,
            this.ItemForServiceTag});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1046, 109);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForID
            // 
            this.ItemForID.Control = this.IDSpinEdit;
            this.ItemForID.CustomizationFormText = "ID";
            this.ItemForID.Location = new System.Drawing.Point(0, 0);
            this.ItemForID.Name = "ItemForID";
            this.ItemForID.Size = new System.Drawing.Size(217, 24);
            this.ItemForID.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.ItemForID.Text = "ID";
            this.ItemForID.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.CustomizationFormText = "故障描述";
            this.ItemForDescription.Location = new System.Drawing.Point(0, 48);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(344, 24);
            this.ItemForDescription.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.ItemForDescription.Text = "故障描述";
            this.ItemForDescription.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.CustomizationFormText = "日期";
            this.ItemForDate.Location = new System.Drawing.Point(217, 0);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(220, 24);
            this.ItemForDate.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.ItemForDate.Text = "上门时间";
            this.ItemForDate.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForStaffs
            // 
            this.ItemForStaffs.Control = this.StaffsTextEdit;
            this.ItemForStaffs.CustomizationFormText = "技术员";
            this.ItemForStaffs.Location = new System.Drawing.Point(678, 0);
            this.ItemForStaffs.Name = "ItemForStaffs";
            this.ItemForStaffs.Size = new System.Drawing.Size(226, 24);
            this.ItemForStaffs.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.ItemForStaffs.Text = "派工";
            this.ItemForStaffs.TextSize = new System.Drawing.Size(48, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(760, 37);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForCustomerName
            // 
            this.ItemForCustomerName.Control = this.CustomerNameTextEdit;
            this.ItemForCustomerName.CustomizationFormText = "客户姓名";
            this.ItemForCustomerName.Location = new System.Drawing.Point(217, 24);
            this.ItemForCustomerName.Name = "ItemForCustomerName";
            this.ItemForCustomerName.Size = new System.Drawing.Size(220, 24);
            this.ItemForCustomerName.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.ItemForCustomerName.Text = "客户姓名";
            this.ItemForCustomerName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForResult
            // 
            this.ItemForResult.Control = this.ResultTextEdit;
            this.ItemForResult.CustomizationFormText = "处理结果";
            this.ItemForResult.Location = new System.Drawing.Point(344, 48);
            this.ItemForResult.Name = "ItemForResult";
            this.ItemForResult.Size = new System.Drawing.Size(334, 24);
            this.ItemForResult.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.ItemForResult.Text = "处理结果";
            this.ItemForResult.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForMemo
            // 
            this.ItemForMemo.Control = this.MemoTextEdit;
            this.ItemForMemo.CustomizationFormText = "备注";
            this.ItemForMemo.Location = new System.Drawing.Point(678, 48);
            this.ItemForMemo.Name = "ItemForMemo";
            this.ItemForMemo.Size = new System.Drawing.Size(368, 24);
            this.ItemForMemo.Text = "备注";
            this.ItemForMemo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.AddressTextEdit;
            this.ItemForAddress.CustomizationFormText = "地址";
            this.ItemForAddress.Location = new System.Drawing.Point(678, 24);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(368, 24);
            this.ItemForAddress.Text = "地址";
            this.ItemForAddress.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForCreateBy
            // 
            this.ItemForCreateBy.Control = this.CreateByTextEdit;
            this.ItemForCreateBy.CustomizationFormText = "创建";
            this.ItemForCreateBy.Location = new System.Drawing.Point(904, 0);
            this.ItemForCreateBy.Name = "ItemForCreateBy";
            this.ItemForCreateBy.Size = new System.Drawing.Size(142, 24);
            this.ItemForCreateBy.Text = "创建";
            this.ItemForCreateBy.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSaveJobOrder;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(871, 72);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(92, 37);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(92, 37);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(92, 37);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAddJobOrder;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(760, 72);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(111, 37);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(111, 37);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(111, 37);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCancel;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(963, 72);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(83, 37);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(83, 37);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(83, 37);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 5, 5);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.AppointmentDateEdit;
            this.layoutControlItem4.CustomizationFormText = "预约";
            this.layoutControlItem4.Location = new System.Drawing.Point(437, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(241, 24);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.layoutControlItem4.Text = "预约";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForContact
            // 
            this.ItemForContact.Control = this.ContactTextEdit;
            this.ItemForContact.CustomizationFormText = "联系方式";
            this.ItemForContact.Location = new System.Drawing.Point(0, 24);
            this.ItemForContact.Name = "ItemForContact";
            this.ItemForContact.Size = new System.Drawing.Size(217, 24);
            this.ItemForContact.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.ItemForContact.Text = "联系方式";
            this.ItemForContact.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForServiceTag
            // 
            this.ItemForServiceTag.Control = this.ServiceTagTextEdit;
            this.ItemForServiceTag.CustomizationFormText = "服务编号";
            this.ItemForServiceTag.Location = new System.Drawing.Point(437, 24);
            this.ItemForServiceTag.Name = "ItemForServiceTag";
            this.ItemForServiceTag.Size = new System.Drawing.Size(241, 24);
            this.ItemForServiceTag.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 30, 0, 0);
            this.ItemForServiceTag.Text = "服务编号";
            this.ItemForServiceTag.TextSize = new System.Drawing.Size(48, 14);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(912, 293);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = "Date DESC";
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(JobLogging.JobLoggingModel.JobOrder);
            this.entityInstantFeedbackSource1.KeyExpression = "ID";
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
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStaffs;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[Staffs]==null || [Staffs]==\'\'";
            styleFormatCondition1.Value1 = "";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupFormat = "[#image]{1} {2}";
            this.gridView1.GroupRowHeight = 28;
            this.gridView1.IndicatorWidth = 60;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowPreview = true;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridView1.PreviewFieldName = "Memo";
            this.gridView1.RowHeight = 28;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.AsyncCompleted += new System.EventHandler(this.gridView1_AsyncCompleted);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "上门时间";
            this.colDate.DisplayFormat.FormatString = "f";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colDate.Name = "colDate";
            this.colDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "共计：{0}")});
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colAppointment
            // 
            this.colAppointment.Caption = "预约";
            this.colAppointment.DisplayFormat.FormatString = "f";
            this.colAppointment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAppointment.FieldName = "Appointment";
            this.colAppointment.Name = "colAppointment";
            this.colAppointment.Visible = true;
            this.colAppointment.VisibleIndex = 2;
            // 
            // colServiceTag
            // 
            this.colServiceTag.Caption = "服务编号/快服";
            this.colServiceTag.FieldName = "ServiceTag";
            this.colServiceTag.Name = "colServiceTag";
            this.colServiceTag.Visible = true;
            this.colServiceTag.VisibleIndex = 4;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "用户姓名";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 5;
            // 
            // colContact
            // 
            this.colContact.Caption = "联系方式";
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 6;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "地址";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 7;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "问题描述";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            // 
            // colResult
            // 
            this.colResult.Caption = "处理结果";
            this.colResult.FieldName = "Result";
            this.colResult.Name = "colResult";
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 9;
            // 
            // colMemo
            // 
            this.colMemo.Caption = "备注";
            this.colMemo.FieldName = "Memo";
            this.colMemo.Name = "colMemo";
            // 
            // colCreateBy
            // 
            this.colCreateBy.Caption = "创建";
            this.colCreateBy.FieldName = "CreateBy";
            this.colCreateBy.Name = "colCreateBy";
            this.colCreateBy.OptionsColumn.AllowEdit = false;
            this.colCreateBy.Visible = true;
            this.colCreateBy.VisibleIndex = 10;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "创建时间";
            this.colCreateDate.DisplayFormat.FormatString = "d";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.AllowEdit = false;
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 11;
            // 
            // colModifyBy
            // 
            this.colModifyBy.Caption = "修改";
            this.colModifyBy.FieldName = "ModifyBy";
            this.colModifyBy.Name = "colModifyBy";
            this.colModifyBy.OptionsColumn.AllowEdit = false;
            this.colModifyBy.Visible = true;
            this.colModifyBy.VisibleIndex = 12;
            // 
            // colModifyDate
            // 
            this.colModifyDate.Caption = "修改时间";
            this.colModifyDate.DisplayFormat.FormatString = "d";
            this.colModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colModifyDate.FieldName = "ModifyDate";
            this.colModifyDate.Name = "colModifyDate";
            this.colModifyDate.OptionsColumn.AllowEdit = false;
            this.colModifyDate.Visible = true;
            this.colModifyDate.VisibleIndex = 13;
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "Date DESC";
            this.entityServerModeSource1.ElementType = typeof(JobLogging.JobLoggingModel.JobOrder);
            this.entityServerModeSource1.KeyExpression = "ID";
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            this.dxValidationProvider1.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider1_ValidationFailed);
            // 
            // alertControl1
            // 
            this.alertControl1.AutoFormDelay = 3000;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 274);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1066, 293);
            this.splitContainerControl1.SplitterPosition = 149;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.lbStaffOut);
            this.groupControl1.Controls.Add(this.btnNoDispatch);
            this.groupControl1.Controls.Add(this.dateEdit_StaffOut);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(149, 293);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "派工统计:";
            // 
            // lbStaffOut
            // 
            this.lbStaffOut.DisplayMember = "Staff";
            this.lbStaffOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStaffOut.ImageIndexMember = "imageIndex";
            this.lbStaffOut.ImageList = this.imageCollection1;
            this.lbStaffOut.Location = new System.Drawing.Point(2, 65);
            this.lbStaffOut.Name = "lbStaffOut";
            this.lbStaffOut.Size = new System.Drawing.Size(145, 226);
            this.lbStaffOut.TabIndex = 1;
            this.lbStaffOut.ValueMember = "ID";
            this.lbStaffOut.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbStaffOut_MouseDoubleClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("status_16x16.png", "images/tasks/status_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/status_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "status_16x16.png");
            // 
            // btnNoDispatch
            // 
            this.btnNoDispatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoDispatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoDispatch.Location = new System.Drawing.Point(2, 42);
            this.btnNoDispatch.Name = "btnNoDispatch";
            this.btnNoDispatch.Size = new System.Drawing.Size(145, 23);
            this.btnNoDispatch.TabIndex = 2;
            this.btnNoDispatch.Text = "未派工(0)";
            this.btnNoDispatch.Click += new System.EventHandler(this.btnNoDispatch_Click);
            // 
            // dateEdit_StaffOut
            // 
            this.dateEdit_StaffOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateEdit_StaffOut.EditValue = null;
            this.dateEdit_StaffOut.Location = new System.Drawing.Point(2, 22);
            this.dateEdit_StaffOut.MenuManager = this.ribbonControl1;
            this.dateEdit_StaffOut.Name = "dateEdit_StaffOut";
            this.dateEdit_StaffOut.Properties.AllowFocused = false;
            this.dateEdit_StaffOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_StaffOut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_StaffOut.Size = new System.Drawing.Size(145, 20);
            this.dateEdit_StaffOut.TabIndex = 3;
            this.dateEdit_StaffOut.EditValueChanged += new System.EventHandler(this.dateEdit_StaffOut_EditValueChanged);
            // 
            // FrmJobOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 567);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmJobOrder";
            this.Text = "派工记录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmJobOrder_FormClosing);
            this.Load += new System.EventHandler(this.FrmJobOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTagTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStaffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbStaffOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_StaffOut.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_StaffOut.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
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
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnSaveJobOrder;
        private DevExpress.XtraEditors.DateEdit DateDateEdit;
        private DevExpress.XtraEditors.TextEdit ServiceTagTextEdit;
        private DevExpress.XtraEditors.TextEdit CustomerNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ContactTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressTextEdit;
        private DevExpress.XtraEditors.TextEdit CreateByTextEdit;
        private DevExpress.XtraEditors.CheckedComboBoxEdit StaffsTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStaffs;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForResult;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateBy;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContact;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForServiceTag;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMemo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit IDSpinEdit;
        private System.Windows.Forms.BindingSource jobOrderBindingSource;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit ModifyByTextEdit;
        private DevExpress.XtraEditors.TextEdit ModifyDateTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyBy;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyDate;
        private DevExpress.XtraEditors.SimpleButton btnAddJobOrder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbtnGridViewRefresh;
        private DevExpress.XtraBars.BarButtonItem bBtnAddJobOrder;
        private DevExpress.XtraBars.BarButtonItem bBtnDeleteJobOrder;
        private DevExpress.XtraEditors.TextEdit ResultTextEdit;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit MemoTextEdit;
        private DevExpress.XtraBars.BarButtonItem bBtnSaveJobOrder;
        private DevExpress.XtraBars.BarButtonItem bBtnCancel;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.TextEdit CreateDateDateEdit;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ImageListBoxControl lbStaffOut;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.SimpleButton btnNoDispatch;
        private DevExpress.XtraBars.BarButtonItem bBtnShowFindPanel;
        private DevExpress.XtraEditors.DateEdit dateEdit_StaffOut;
        private DevExpress.XtraGrid.Columns.GridColumn colAppointment;
        private DevExpress.XtraEditors.DateEdit AppointmentDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      

    }
}