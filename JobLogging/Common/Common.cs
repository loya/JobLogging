using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

namespace JobLogging.Common
{
    public class Common
    {
        public bool CheckIP(string ipAddress)
        {
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(ipAddress);

            return reply.Status == IPStatus.Success;
        }


        #region ShowWindow

        #region Win32API函数
        /// <summary>
        /// 显示正常窗体
        /// </summary>
        private const int SW_SHOWNORMAL = 1;
        /// <summary>
        /// 还原窗体
        /// </summary>
        private const int SW_RESTORE = 9;

        /// <summary>
        /// 设置由不同线程产生的窗口的显示状态;
        /// 该函数设置由不同线程产生的窗口的显示状态;
        /// 如果函数原来可见，返回值为非零；如果函数原来被隐藏，返回值为零。
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="nCmdShow"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// 创建指定窗口的线程设置到前台，并且激活该窗口。
        /// 该函数将创建指定窗口的线程设置到前台，并且激活该窗口。
        /// 键盘输入转向该窗口，并为用户改各种可视的记号。系统给创建前台窗口的线程分配的权限稍高于其他线程。
        /// 如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零。
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// 判断指定窗体是否已经最小化
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);
        /// <summary>
        /// 判断指定窗体是否已经最大化
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern bool IsZoomed(IntPtr hWnd);

        /// <summary>
        /// 获取当前系统中被激活的窗体
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// 获取指定窗口的进程 ID 或线程 ID
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="ProcessId"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        #endregion Win32API函数

        /// <summary>
        /// 使指定窗体置于最前端显示
        /// </summary>
        /// <param name="winHandler"></param>
        public static void ShowFormTop(IntPtr winHandler)
        {
            IntPtr _handler = winHandler;
            SetForegroundWindow(_handler);
            if (IsIconic(_handler))
            {//最小化时恢复窗体到前端
                ShowWindowAsync(_handler, SW_RESTORE);
            }
            else
            {//隐藏时显示窗体
                ShowWindowAsync(_handler, SW_SHOWNORMAL);
            }
        }
    }
        #endregion
}
