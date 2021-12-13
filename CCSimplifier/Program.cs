using System;
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
            while (flag)
            {
                cs = new CCSimplifier();
                s = new Simplifier();
                if(flag == true) Application.Run(cs);
                if (flag == true) Application.Run(s);
            }
        }
    }
}