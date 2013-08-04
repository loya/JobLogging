namespace JobLogging.Forms
{
    partial class FrmStaff
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
                components.Dispose();}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit_Sort = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colRoleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_RoleID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIsActivate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSkin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.sharedImageCollection1 = new DevExpress.Utils.SharedImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit_Sort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_RoleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1.ImageSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataNavigator1);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(373, 467);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "员工管理";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.usersBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(13, 0);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(172, 24);
            this.dataNavigator1.TabIndex = 5;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.usersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_RoleID,
            this.repositoryItemSpinEdit_Sort});
            this.gridControl1.Size = new System.Drawing.Size(369, 443);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colName,
            this.colSort,
            this.colRoleID,
            this.colIsActivate,
            this.colSkin});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 28;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 42;
            // 
            // colName
            // 
            this.colName.Caption = "姓名";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colSort
            // 
            this.colSort.Caption = "排序";
            this.colSort.ColumnEdit = this.repositoryItemSpinEdit_Sort;
            this.colSort.FieldName = "Sort";
            this.colSort.Name = "colSort";
            this.colSort.Visible = true;
            this.colSort.VisibleIndex = 5;
            // 
            // repositoryItemSpinEdit_Sort
            // 
            this.repositoryItemSpinEdit_Sort.AutoHeight = false;
            this.repositoryItemSpinEdit_Sort.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit_Sort.Name = "repositoryItemSpinEdit_Sort";
            // 
            // colRoleID
            // 
            this.colRoleID.Caption = "角色";
            this.colRoleID.ColumnEdit = this.repositoryItemLookUpEdit_RoleID;
            this.colRoleID.FieldName = "RoleID";
            this.colRoleID.Name = "colRoleID";
            this.colRoleID.Visible = true;
            this.colRoleID.VisibleIndex = 3;
            this.colRoleID.Width = 95;
            // 
            // repositoryItemLookUpEdit_RoleID
            // 
            this.repositoryItemLookUpEdit_RoleID.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.repositoryItemLookUpEdit_RoleID.AppearanceDropDownHeader.Options.UseFont = true;
            this.repositoryItemLookUpEdit_RoleID.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repositoryItemLookUpEdit_RoleID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_RoleID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 5, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "角色", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit_RoleID.DataSource = this.roleBindingSource;
            this.repositoryItemLookUpEdit_RoleID.DisplayMember = "Name";
            this.repositoryItemLookUpEdit_RoleID.Name = "repositoryItemLookUpEdit_RoleID";
            this.repositoryItemLookUpEdit_RoleID.NullText = "";
            this.repositoryItemLookUpEdit_RoleID.PopupFormMinSize = new System.Drawing.Size(0, 10);
            this.repositoryItemLookUpEdit_RoleID.PopupWidth = 10;
            this.repositoryItemLookUpEdit_RoleID.ShowHeader = false;
            this.repositoryItemLookUpEdit_RoleID.ValueMember = "ID";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(JobLogging.JobloggingModel.Role);
            // 
            // colIsActivate
            // 
            this.colIsActivate.Caption = "激活";
            this.colIsActivate.FieldName = "IsActivate";
            this.colIsActivate.Name = "colIsActivate";
            this.colIsActivate.Visible = true;
            this.colIsActivate.VisibleIndex = 4;
            this.colIsActivate.Width = 37;
            // 
            // colSkin
            // 
            this.colSkin.Caption = "皮肤";
            this.colSkin.FieldName = "Skin";
            this.colSkin.Name = "colSkin";
            this.colSkin.OptionsColumn.AllowEdit = false;
            this.colSkin.OptionsColumn.AllowFocus = false;
            this.colSkin.Visible = true;
            this.colSkin.VisibleIndex = 2;
            this.colSkin.Width = 63;
            // 
            // alertControl1
            // 
            this.alertControl1.AutoFormDelay = 3000;
            this.alertControl1.ShowPinButton = false;
            // 
            // sharedImageCollection1
            // 
            // 
            // 
            // 
            this.sharedImageCollection1.ImageSource.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("sharedImageCollection1.ImageSource.ImageStream")));
            this.sharedImageCollection1.ImageSource.Images.SetKeyName(0, "show_32x32.png");
            this.sharedImageCollection1.ParentControl = this;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 467);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmStaff";
            this.Tag = "StaffForm";
            this.Text = "员工管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStaff_FormClosing);
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit_Sort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_RoleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSkin;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleID;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActivate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_RoleID;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSort;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit_Sort;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.Utils.SharedImageCollection sharedImageCollection1;


    }
}