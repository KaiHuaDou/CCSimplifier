using System;
using System.Threading;
using System.Windows.Forms;

namespace CCSimplifier
{
    public static class Program
    {
        public static CCSimplifier cs;
        public static Simplifier s;
        public static bool flag = true;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            cs = new CCSimplifier();
            Application.Run(cs);
        }
        public static void RunSimplifier()
        {
            s = new Simplifier();
            Application.Run(s);
        }
    }
}