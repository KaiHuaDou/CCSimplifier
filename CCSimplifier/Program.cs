using System;
using System.Windows.Forms;

namespace CCSimplifier;

public static class Program
{
    public static CCSimplifier app;
    public static Simplifier window;
    public static bool flag = true;

    [STAThread]
    public static void Main( )
    {
        Application.EnableVisualStyles( );
        Application.SetCompatibleTextRenderingDefault(false);
        app = new CCSimplifier( );
        Application.Run(app);
    }
    public static void RunSimplifier( )
        => Application.Run(new Simplifier( ));
}
