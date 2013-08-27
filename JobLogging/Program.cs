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
        private static void Main(String[] args)
        {
            if (args.Any() && args[0] == "SyncTime")
            {

                using (var context=new JobLoggingModel.JobLoggingModelContainer())
                {
                    var c =new Common.LocalTimeSync(context);
                    c.SyncServerTime();
                }
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //SplashScreenManager.ShowForm(typeof (SplashScreen1));
            
            var frm=new Forms.frmLogin();
            var dialogResult=frm.ShowDialog();
            if (dialogResult== DialogResult.Cancel)
            {
                return;
            }
            if (frm.LoginUser == null)
            {
                return;
            }
            GlobalParams.CurrentLoginUser = frm.LoginUser;

            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Cn");
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

        public static string ConnectionString()
        {
            var symmetricMethod =new  Common.SymmetricMethod();
            var dataSource = Properties.Settings.Default.DataSource;
            var userID = symmetricMethod.DecryptoData(Properties.Settings.Default.UserID);
            var password = symmetricMethod.DecryptoData(Properties.Settings.Default.Password);
            return  ConnectionString(dataSource, userID, password);
        }

        public static string ConnectionString(string dataSource,string userID, string password)
        {
            var result =
                "metadata=res://*/JobLoggingModel.JobLoggingModel.csdl|" +
                "res://*/JobLoggingModel.JobLoggingModel.ssdl|" + 
                "res://*/JobLoggingModel.JobLoggingModel.msl;" +
                "provider=System.Data.SqlClient;" +
                "provider connection string=\"" +
                string.Format("data source={0};initial catalog=JobLogging;user id={1};pwd={2};", dataSource, userID, password) +
                "multipleactiveresultsets=True;application name=EntityFramework\";";
            return result;
        }
    }
    
}
