namespace JobLogging
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::JobLogging.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.bBtnReLogin = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnShowUserManageForm = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnShowFrmJobLogging = new DevExpress.XtraBars.BarButtonItem();
            this.skinGalleryBarItem = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bBtnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem_StatusBar_UserInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem_ver = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.sbExit = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbonControl1.ApplicationCaption = "阿斯达科技派工记录";
            this.ribbonControl1.ApplicationIcon = global::JobLogging.Properties.Resources.ModelEditor_EditModel_48x48;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bBtnShowUserManageForm,
            this.bBtnShowFrmJobLogging,
            this.skinGalleryBarItem,
            this.bBtnReLogin,
            this.bBtnExit,
            this.barStaticItem1,
            this.bBtnChangePassword,
            this.barStaticItem_StatusBar_UserInfo,
            this.barStaticItem_ver});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(1014, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.bBtnReLogin);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.bBtnExit);
            this.ribbonControl1.TransparentEditors = true;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.bBtnReLogin, true);
            this.applicationMenu1.ItemLinks.Add(this.bBtnExit, true);
            this.applicationMenu1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText;
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // bBtnReLogin
            // 
            this.bBtnReLogin.Caption = "重新登录";
            this.bBtnReLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnReLogin.Glyph")));
            this.bBtnReLogin.Id = 5;
            this.bBtnReLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnReLogin.LargeGlyph")));
            this.bBtnReLogin.Name = "bBtnReLogin";
            this.bBtnReLogin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bBtnReLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnReLogin_ItemClick);
            // 
            // bBtnExit
            // 
            this.bBtnExit.Caption = "退出";
            this.bBtnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnExit.Glyph")));
            this.bBtnExit.Id = 6;
            this.bBtnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnExit.LargeGlyph")));
            this.bBtnExit.Name = "bBtnExit";
            this.bBtnExit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bBtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnExit_ItemClick);
            // 
            // bBtnShowUserManageForm
            // 
            this.bBtnShowUserManageForm.Caption = "用户角色\r\n管理\r\n";
            this.bBtnShowUserManageForm.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnShowUserManageForm.Glyph")));
            this.bBtnShowUserManageForm.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("bBtnShowUserManageForm.GlyphDisabled")));
            this.bBtnShowUserManageForm.Id = 1;
            this.bBtnShowUserManageForm.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnShowUserManageForm.LargeGlyph")));
            this.bBtnShowUserManageForm.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("bBtnShowUserManageForm.LargeGlyphDisabled")));
            this.bBtnShowUserManageForm.Name = "bBtnShowUserManageForm";
            this.bBtnShowUserManageForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnShowfrmUser_ItemClick);
            // 
            // bBtnShowFrmJobLogging
            // 
            this.bBtnShowFrmJobLogging.Caption = "派工记录";
            this.bBtnShowFrmJobLogging.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnShowFrmJobLogging.Glyph")));
            this.bBtnShowFrmJobLogging.Id = 2;
            this.bBtnShowFrmJobLogging.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBtnShowFrmJobLogging.LargeGlyph")));
            this.bBtnShowFrmJobLogging.Name = "bBtnShowFrmJobLogging";
            this.bBtnShowFrmJobLogging.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnShowFrmJobLogging_ItemClick);
            // 
            // skinGalleryBarItem
            // 
            this.skinGalleryBarItem.Caption = "ribbonGalleryBarItem2";
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Group2";
            this.skinGalleryBarItem.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.skinGalleryBarItem.Id = 4;
            this.skinGalleryBarItem.Name = "skinGalleryBarItem";
            this.skinGalleryBarItem.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.skinGalleryBarItem_GalleryItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "-";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bBtnChangePassword
            // 
            this.bBtnChangePassword.Caption = "修改登录\r\n密码";
            this.bBtnChangePassword.Id = 2;
            this.bBtnChangePassword.LargeGlyph = global::JobLogging.Properties.Resources.BO_Security;
            this.bBtnChangePassword.Name = "bBtnChangePassword";
            this.bBtnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnChangePassword_ItemClick);
            // 
            // barStaticItem_StatusBar_UserInfo
            // 
            this.barStaticItem_StatusBar_UserInfo.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barStaticItem_StatusBar_UserInfo.Glyph = global::JobLogging.Properties.Resources.jumplist_useronline;
            this.barStaticItem_StatusBar_UserInfo.Id = 3;
            this.barStaticItem_StatusBar_UserInfo.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.barStaticItem_StatusBar_UserInfo.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.barStaticItem_StatusBar_UserInfo.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem_StatusBar_UserInfo.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem_StatusBar_UserInfo.Name = "barStaticItem_StatusBar_UserInfo";
            this.barStaticItem_StatusBar_UserInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem_ver
            // 
            this.barStaticItem_ver.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem_ver.Id = 5;
            this.barStaticItem_ver.Name = "barStaticItem_ver";
            this.barStaticItem_ver.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "派工记录";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bBtnShowFrmJobLogging);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "系统设置";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnShowUserManageForm);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinGalleryBarItem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "外观选择";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem_StatusBar_UserInfo);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem_ver);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1014, 31);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.sbExit);
            this.popupControlContainer1.Location = new System.Drawing.Point(12, 170);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl1;
            this.popupControlContainer1.Size = new System.Drawing.Size(138, 30);
            this.popupControlContainer1.TabIndex = 3;
            this.popupControlContainer1.Visible = false;
            // 
            // sbExit
            // 
            this.sbExit.AllowFocus = false;
            this.sbExit.ImageIndex = 0;
            this.sbExit.ImageList = this.imageCollection1;
            this.sbExit.Location = new System.Drawing.Point(3, 3);
            this.sbExit.Name = "sbExit";
            this.sbExit.Size = new System.Drawing.Size(129, 23);
            this.sbExit.TabIndex = 1;
            this.sbExit.Text = "退出系统(&x)";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "阿斯达科技派工记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem bBtnShowUserManageForm;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem bBtnShowFrmJobLogging;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.RibbonGalleryBarItem skinGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bBtnReLogin;
        private DevExpress.XtraBars.BarButtonItem bBtnExit;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton sbExit;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarButtonItem bBtnChangePassword;
        private DevExpress.XtraBars.BarStaticItem barStaticItem_StatusBar_UserInfo;
        private DevExpress.XtraBars.BarStaticItem barStaticItem_ver;

        
    }
}

