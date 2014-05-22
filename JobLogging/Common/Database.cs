using System.Data.Entity;
using System.Linq;
using JobLogging.JobLoggingModel;

namespace JobLogging.Common
{
    public class Database
    {
        public void CreateDatabse(bool reBuild)
        {
            using (var context = new JobLoggingModelContainer())
            {
                if (reBuild)
                {
                    if (context.Database.Exists())
                    {
                        context.Database.Delete();
                        context.Database.Initialize(true);
                    }
                }
                if (context.Database.CreateIfNotExists())
                    ReInitRoleAndPermission();
            }

        }

        public void ReInitRoleAndPermission()
        {
            using (var context = new JobLoggingModelContainer())
            {
                foreach (var item in context.Roles)
                {
                    item.Permissions.Clear();
                }
                context.Permissions.Load();
                context.Permissions.Local.Clear();
                var root1 = new Permission { Name = "用户管理" };
                root1.ChildPermissions.Add(new Permission { Name = "新增用户" });
                root1.ChildPermissions.Add(new Permission { Name = "修改用户" });
                root1.ChildPermissions.Add(new Permission { Name = "删除用户" });

                var root2 = new Permission { Name = "角色管理" };
                root2.ChildPermissions.Add(new Permission { Name = "新增角色" });
                root2.ChildPermissions.Add(new Permission { Name = "修改角色" });
                root2.ChildPermissions.Add(new Permission { Name = "删除角色" });

                var root = new Permission { Name = "用户角色管理" };
                context.Permissions.Add(root);
                root.ChildPermissions.Add(root1);
                root.ChildPermissions.Add(root2);

                var permission = context.Permissions.Add(new Permission { Name="派工记录"});
                permission.ChildPermissions.Add(new Permission { Name = "新增派工" });
                permission.ChildPermissions.Add(new Permission { Name = "修改派工" });
                permission.ChildPermissions.Add(new Permission { Name = "删除派工" });
                permission.ChildPermissions.Add(new Permission { Name = "派工分配" });
                permission.ChildPermissions.Add(new Permission { Name = "设置值班" });
                //role & user
                var role = context.Roles.SingleOrDefault(t => t.Name == "管理员");
                if (role == null)
                {
                    role = new Role { Name = "管理员" };
                    context.Roles.Add(role);
                }
                else
                    role.Permissions.Clear();

                foreach (var item in context.Permissions.Local)
                {
                    role.Permissions.Add(item);
                }
                var role1 = context.Roles.SingleOrDefault(r => r.Name == "技术员");
                if (role1 == null)
                {
                    context.Roles.Add(new Role { Name = "技术员" });
                }

                var user = context.Users.SingleOrDefault(u => u.Name == "Admin");
                if (user == null)
                {
                    context.Users.Add(new User
                    {
                        Name = "Admin",
                        LoginName = "admin",
                        Password = "",
                        IsActivate = true,
                        IsEngineer = true,
                        Role = role,
                        Sort = 0
                    });
                }
                else
                    user.Role = role;
                context.SaveChanges();
            }
        }

    }
}
