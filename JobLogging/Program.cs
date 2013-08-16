using System;
using System.Linq;
using System.Windows.Forms;

namespace JobLogging
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //SplashScreenManager.ShowForm(typeof (SplashScreen1));
            
            var frm=new Forms.frmLogin();
            frm.ShowDialog();
            if (frm.LoginUser == null)
            {
                return;
            }
            GlobalParams.CurrentLoginUser = frm.LoginUser;
            Application.Run(new MainForm());
        }
    }

    public class GlobalParams
    {
        //public static JobLoggingModelContainer modelContainer = new JobLoggingModelContainer();
        public static JobLoggingModel.User CurrentLoginUser;

        public static bool HasPermission(string permissionName)
        {
            return CurrentLoginUser.Role.Permissions.Any(p => p.Name == permissionName);
        }
    }


}
