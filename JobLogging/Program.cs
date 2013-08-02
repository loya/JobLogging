using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JobLogging.JobloggingModel;

namespace JobLogging
{
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    
    public class GlobalParams
    {
       public static JobloggingModelContainer modelContainer = new JobloggingModelContainer();
    }


}
