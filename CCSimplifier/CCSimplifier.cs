using System;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace CCSimplifier;

public partial class CCSimplifier : Form
{
    public CCSimplifier( ) => InitializeComponent( );

    private readonly ResourceManager resMgr = Properties.Resources.ResourceManager;

    private void GoSimplifierMouseEnter(object o, EventArgs e)
        => GoSimplifier.Image = Image.FromStream(new MemoryStream((byte[]) resMgr.GetObject("Option2")));

    private void GoSimplifierMouseLeave(object o, EventArgs e)
        => GoSimplifier.Image = Image.FromStream(new MemoryStream((byte[]) resMgr.GetObject("Option")));

    private void ExitClick(object o, EventArgs e)
    {
        Program.flag = false;
        Application.Exit( );
    }

    private void GoSimplifierClick(object o, EventArgs e)
    {
        new Thread(new ThreadStart(Program.RunSimplifier)).Start( );
        Close( );
    }

    private void AboutButtonClick(object o, EventArgs e)
        => NativeMethods.ShellAbout(Handle, "CCSimplifier", "版本 1.3.0", Icon.Handle);
}
