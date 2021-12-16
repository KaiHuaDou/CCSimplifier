using System;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace CCSimplifier
{
    public partial class CCSimplifier : Form
    {
        public CCSimplifier()
        {
            InitializeComponent();
        }

        ResourceManager rsMgr = Properties.Resources.ResourceManager;

        private void GoSimplifier_MouseEnter(object sender, EventArgs e)
        {
            object image = rsMgr.GetObject("Option2");
            GoSimplifier.Image = (Image)image;
        }

        private void GoSimplifier_MouseLeave(object sender, EventArgs e)
        {
            object image = rsMgr.GetObject("Option");
            GoSimplifier.Image = (Image)image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            Application.Exit();
        }

        private void GoSimplifier_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Program.RunSimplifier));
            t.Start();
            this.Close();
        }
    }
}