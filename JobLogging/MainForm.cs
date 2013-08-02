using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JobLogging.Forms;
using JobLogging.JobloggingModel;

namespace JobLogging
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            if (GlobalParams.modelContainer.Roles.SingleOrDefault(t => t.Name == "管理员") == null)
            {
                var role=new Role { Name  = "技术员"};
                GlobalParams.modelContainer.Roles.AddObject(new Role { Name = "管理员" });
                GlobalParams.modelContainer.Roles.AddObject(role);
                GlobalParams.modelContainer.Users.AddObject(new User
                    {
                        Name = "小王",
                        IsActivate = true,
                        IsEngineer = true,
                        JobCount = 0,
                        Role = role,
                        Sort = 0
                    });
                GlobalParams.modelContainer.Users.AddObject(new User
                {
                    Name = "小张",
                    IsActivate = true,
                    IsEngineer = true,
                    JobCount = 0,
                    Role = role,
                    Sort = 0
                });
                GlobalParams.modelContainer.SaveChanges();
            }
        }

        private void btnShowStaffForm_Click(object sender, EventArgs e)
        {

        }

        private void btnShowStaffForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //foreach (var mdiChild in this.MdiChildren)
            //{
            //    if (mdiChild is StaffForm){
            //        this.ActivateMdiChild(mdiChild);
            //        return;}
            //}
            OpenMdiForm<FrmStaff>( "员工管理");

        }

        private void OpenMdiForm<T>(string caption) where T:Form
        {
            var form = (Form)Activator.CreateInstance(typeof(T));
            var doc = documentManager1.View.Documents.FirstOrDefault(t => t.Caption == caption);
            if (doc != null)
            {
                tabbedView1.Controller.Activate(doc);
                return;
            }
            form.MdiParent = this;
            form.Text = caption;
            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var frm = new FrmJobLogging { MdiParent = this };
            frm.Show();
            //if (GlobalParams.modelContainer.DatabaseExists())
            //{
            //    //if (!GlobalParams.modelContainer.Database.CompatibleWithModel(true))
            //    //{
            //    //    GlobalParams.modelContainer.Database.Delete();
            //    //    initDataBase();
            //    //}
            //}
            //else
            //{
            //    initDataBase();
            //}
        }

        private void btnShowFrmJobLogging_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenMdiForm<FrmJobLogging>( "派工记录");
        }
        //private void initDataBase()
        //{
        //    GlobalParams.modelContainer.CreateDatabase();
        //    GlobalParams.modelContainer.Roles.AddObject(new JobloggingModel.Role { Name = "管理员" });
        //    GlobalParams.modelContainer.Roles.AddObject(new JobloggingModel.Role { Name = "员工" });
        //    GlobalParams.modelContainer.SaveChanges();
        //}
    }
}
