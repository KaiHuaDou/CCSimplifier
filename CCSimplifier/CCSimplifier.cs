using System;
using System.Drawing;
using System.Windows.Forms;

namespace CCSimplifier
{
    public partial class CCSimplifier : Form
    {
        public CCSimplifier()
        {
            InitializeComponent();
        }

        private void GoSimplifier_MouseEnter(object sender, EventArgs e)
        {
            GoSimplifier.Image = Image.FromFile(@"img\Option2.png");
        }

        private void GoSimplifier_MouseLeave(object sender, EventArgs e)
        {
            GoSimplifier.Image = Image.FromFile(@"img\Option.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            Application.Exit();
        }

        private void GoSimplifier_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}