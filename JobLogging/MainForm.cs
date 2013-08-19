﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using JobLogging.Forms;
using JobLogging.JobLoggingModel;

namespace JobLogging
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitSkins();
            tabbedView1.DocumentActivated += tabbedView1_DocumentActivated;
        }


        void tabbedView1_DocumentActivated(object sender, DocumentEventArgs e)
        {
            if (e.Document.Tag != null)
                ribbonControl1.SelectedPage = ribbonControl1.Pages[e.Document.Tag.ToString()];
        }


        void InitSkins()
        {
            SkinHelper.InitSkinGallery(skinGalleryBarItem, true);
            //UserLookAndFeel.Default.SetSkinStyle("Caramel");
            //defaultLookAndFeel1.LookAndFeel.SkinName = "焦糖";
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(GlobalParams.CurrentLoginUser.Skin);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bBtnShowFrmJobLogging.PerformClick();
            InitUserRelated();
        }

        private void InitUserRelated()
        {
            barStaticItem_StatusBar_UserInfo.Caption = string.Format("欢迎你：{0}    今天是：{1}",
                GlobalParams.CurrentLoginUser.Name,
                DateTime.Today.ToString("yyyy-MM-dd   dddd"));
            bBtnShowUserManageForm.Enabled = GlobalParams.HasPermission("用户角色管理");
        }

        private void bBtnShowfrmUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            OpenMdiForm<frmUsers>("用户角色管理", "系统设置");
            SplashScreenManager.CloseForm();
        }

        public void OpenMdiForm<T>(string caption, string ribbonPageCaption) where T : Form
        {
            var doc = documentManager1.View.Documents.FirstOrDefault(t => t.Caption == caption);
            if (doc != null)
            {
                tabbedView1.Controller.Activate(doc);
                return;
            }

            var form = (Form)Activator.CreateInstance(typeof(T));
            form.MdiParent = this;
            form.Text = caption;
            form.Show();
            doc = documentManager1.View.Documents.FirstOrDefault(t => t.Caption == caption);
           
            doc.Tag = ribbonPageCaption;
            ribbonControl1.SelectedPage = ribbonControl1.Pages[ribbonPageCaption];
        }


        private void bBtnShowFrmJobLogging_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMdiForm<FrmJobOrder>("派工记录", "派工记录");
        }

        private void skinGalleryBarItem_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            using (var context=new JobLoggingModelContainer())
            {
                context.Users.Attach(GlobalParams.CurrentLoginUser);
                GlobalParams.CurrentLoginUser.Skin = e.Item.Tag.ToString();
                context.SaveChanges();
            }
        }

        private void bBtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bBtnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmNewPassword(GlobalParams.CurrentLoginUser);
            if (frm.ShowDialog() == DialogResult.OK)
                new AlertControl().Show(this, "提示：", "密码已修改!");
        }

        private void bBtnReLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hide();
            var frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                return;
            }
            foreach (var document in documentManager1.View.Documents.ToList())
            {
                document.Form.Close();
            }
            if (documentManager1.View.Documents.Any())
            {
                Show();
                return;
            }
            GlobalParams.CurrentLoginUser = frm.LoginUser;
            InitUserRelated();
            Show();
            bBtnShowFrmJobLogging.PerformClick();
            frm.Dispose();
        }
    }
}