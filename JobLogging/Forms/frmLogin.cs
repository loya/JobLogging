using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JobLogging.JobLoggingModel;

namespace JobLogging.Forms
{
    public partial class frmLogin : XtraForm
    {
        private User _loginUser;
        public User LoginUser
        {
            get { return _loginUser; }
        }

        public frmLogin()
        {
            InitializeComponent(); 
            InitDatabase();

        }
        private void InitDatabase()
        {
            using (var context = new JobLoggingModelContainer())
            {
                if (context.Roles.SingleOrDefault(t => t.Name == "管理员") == null)
                {
                    

                    //permissions
                    var root1 = new Permission { Name = "用户管理" };
                    //context.Permissions.Add(root1);
                    root1.ChildPermissions.Add(new Permission { Name = "新增用户" });
                    root1.ChildPermissions.Add(new Permission { Name = "修改用户" });
                    root1.ChildPermissions.Add(new Permission { Name = "删除用户" });

                    var root2 = new Permission { Name = "角色管理" };
                    //context.Permissions.Add(root2);
                    root2.ChildPermissions.Add(new Permission { Name = "新增角色" });
                    root2.ChildPermissions.Add(new Permission { Name = "修改角色" });
                    root2.ChildPermissions.Add(new Permission { Name = "删除角色" });

                    var root = new Permission {Name = "用户角色管理"};
                    context.Permissions.Add(root);
                    root.ChildPermissions.Add(root1);
                    root.ChildPermissions.Add(root2);
                    //role & user
                    var role = new Role { Name = "管理员" };
                    context.Roles.Add(role);
                    foreach (var permission in context.Permissions.Local)
                    {
                        role.Permissions.Add(permission);}
                    context.Roles.Add(new Role { Name = "技术员" });
                    context.Users.Add(new User
                    {
                        Name = "Admin",
                        LoginName = "admin",
                        Password = "",
                        IsActivate = true,
                        IsEngineer = true,
                        JobCount = 0,
                        Role = role,
                        Sort = 0
                    });
                    context.Users.Add(new User
                    {
                        Name = "小张",
                        LoginName = "xz",
                        Password = "",
                        IsActivate = true,
                        IsEngineer = true,
                        JobCount = 0,
                        Role = role,
                        Sort = 0
                    });


                    context.SaveChanges();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
			using (var bll = new JobLoggingModelContainer())
            {
                _loginUser = bll.Users.Include("Role").Include("Role.Permissions").SingleOrDefault(u => u.LoginName == txtLoginName.Text && u.Password == txtPassword.Text);
            }
            if (_loginUser == null)
            {
                XtraMessageBox.Show("用户名或密码错误！");
                txtLoginName.Focus();
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginName.Focus();
            txtLoginName.Text = "admin";
        }

        private void TextEdit_Enter(object sender, EventArgs e)
        {
            ((TextEdit) sender).SelectAll();
        }
    }
}