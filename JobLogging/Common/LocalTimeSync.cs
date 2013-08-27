using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JobLogging.Common
{
    /// <summary> 
    /// 设置本机时间 
    /// </summary> 
    public class LocalTimeSync
    {
        [DllImport("Kernel32.dll")]
        public static extern bool SetSystemTime(ref SystemTime sysTime);

        [DllImport("Kernel32.dll")]
        public static extern void GetSystemTime(ref SystemTime sysTime);

        [StructLayout(LayoutKind.Sequential)]
        public struct SystemTime
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMiliseconds;
        }

        readonly DbContext _context;
        /// <summary>
        /// Initializes a new instance of the LocalTimeSync class.
        /// </summary>
        public LocalTimeSync(DbContext context)
        {
            _context = context;
        }

        /// <summary> 
        /// 设置本机时间 
        /// </summary> 
        public void SyncTime(DateTime currentTime)
        {
            var sysTime = new SystemTime
            {
                wYear = Convert.ToUInt16(currentTime.Year),
                wMonth = Convert.ToUInt16(currentTime.Month),
                wDay = Convert.ToUInt16(currentTime.Day),
                wDayOfWeek = Convert.ToUInt16(currentTime.DayOfWeek),
                wMinute = Convert.ToUInt16(currentTime.Minute),
                wSecond = Convert.ToUInt16(currentTime.Second),
                wMiliseconds = Convert.ToUInt16(currentTime.Millisecond)
            };

            //处理北京时间 
            int nBeijingHour = currentTime.Hour - 8;
            if (nBeijingHour <= 0)
            {
                nBeijingHour = 24;
                sysTime.wDay = Convert.ToUInt16(currentTime.Day - 1);
                //sysTime.wDayOfWeek = Convert.ToUInt16(current.DayOfWeek - 1); 
            }
            else
            {
                sysTime.wDay = Convert.ToUInt16(currentTime.Day);
                sysTime.wDayOfWeek = Convert.ToUInt16(currentTime.DayOfWeek);
            }
            sysTime.wHour = Convert.ToUInt16(nBeijingHour);

            SetSystemTime(ref sysTime);//设置本机时间 
        }

        /// <summary>
        /// 检查时间是否同步
        /// </summary>
        /// <returns>true：同步，false:不同步</returns>
        public bool CheckSyncTime()
        {
            var serverDate = _context.Database.SqlQuery<DateTime>("SELECT GETDATE()").SingleOrDefault();


            //LocalTimeSync.SyncTime(dt); 

            //比较时间一致性 
            if ((DateTime.Now - serverDate).TotalMilliseconds > 50)
            {
                return false;
            }
            return true;
        }

        /// <summary> 
        /// 同步服务器时间 
        /// </summary> 
        public void SyncServerTime()
        {
            var serverDate = _context.Database.SqlQuery<DateTime>("SELECT GETDATE()").SingleOrDefault();


            //比较时间一致性 
            if ((DateTime.Now - serverDate).TotalMilliseconds > 50)
            {
                if (!IsAdmin())
                {
                    var result = RunWorkerInstance("SyncTime");
                    if (false == result)
                    {
                        MessageBox.Show("时间同步失败，请以管理员身份运行！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                        
                    }

                }
                SyncTime(serverDate);
            }
        }

        public bool IsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal p = new WindowsPrincipal(id);
            return p.IsInRole(WindowsBuiltInRole.Administrator);
        }


        public bool RunWorkerInstance(String arg)
        {
            Process workProcess = new Process();
            workProcess.StartInfo.UseShellExecute = true;
            workProcess.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
            workProcess.StartInfo.FileName = Application.ExecutablePath;  // 当前这个exe的完整路径名和文件名  
            workProcess.StartInfo.Verb = "runas"; // 用admin权限启动新进程  
            workProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // 新进程用隐藏方式启动，避免生成窗口和cmd黑窗，让用户看起来就像是提升了当前窗体exe的权限一样。。。  
            workProcess.StartInfo.Arguments = arg;
            try
            {
                workProcess.Start();
                workProcess.WaitForExit();
                workProcess.Close();
                return true;
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                return false;
            }
        }

    }

}
