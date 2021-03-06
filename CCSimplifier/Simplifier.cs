using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CCSimplifier
{
    public partial class Simplifier : Form
    {
        public Simplifier()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        double DeletedSize = 0;

        private void Cancel_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            Application.Exit();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string DoName(string name)
        {
            name = name.Replace("Adobe ", "");
            name = name.Replace("Adobe", "");
            name = name.Replace(" CS6", "");
            name = name.Replace(" CS5", "");
            name = name.Replace(" CC", "");
            name = name.Replace("CS6", "");
            name = name.Replace("CS5", "");
            name = name.Replace("CC", "");
            name = name.Replace("AfterFX", "After Effects");
            return name;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult dr = OpenExecute.ShowDialog();
            string name = Path.GetFileNameWithoutExtension(OpenExecute.FileName);
            if (dr == DialogResult.OK)
            {
                PathBox.Text = OpenExecute.FileName;
                AppName.Text = DoName(name);
                Icon icon = GetIcon.GetProgramIcon(OpenExecute.FileName, false);
                AppIcon.Image = icon.ToBitmap();
            }
            this.Text = DoName(name) + "精简";
        }

        private void Simplified_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Simplifing);
            t.Start();
        }

        private void SetProgress(int percent, double size, string text, string fullText)
        {
            ProgressPercent.Text = (int)((Progress.Value + percent) / (Progress.Maximum / 100.0)) + "%";
            Progress.Value += percent;
            ProgressText.Text = text;
            MoreInfo.Items.Add(fullText.Replace(new FileInfo(PathBox.Text).DirectoryName + "\\", ""));
            DeletedSize += size;
            Deleted.Text = "已精简" + (int)DeletedSize + "MB";
        }

        public static List<FileInfo> getFiles(string path)
        {
            List<FileInfo> lf = new List<FileInfo>();
            DirectoryInfo root = new DirectoryInfo(path);
            foreach (DirectoryInfo d in root.GetDirectories())
            {
                lf.AddRange(getFiles(d.FullName));
            }
            foreach (FileInfo f in root.GetFiles())
            {
                lf.Add(f);
            }
            return lf;
        }

        public static List<DirectoryInfo> getDirectory(string path)
        {
            List<DirectoryInfo> df = new List<DirectoryInfo>();
            DirectoryInfo root = new DirectoryInfo(path);
            foreach (DirectoryInfo d in root.GetDirectories())
            {
                df.Add(d);
                df.AddRange(getDirectory(d.FullName));
            }
            return df;
        }

        private void Simplifing()
        {
            MoreInfo.Items.Clear();
            Progress.Value = 0;
            DeletedSize = 0;
            RemoveMulLangs();
            Progress.Value = Progress.Maximum;
            ProgressPercent.Text = "100%";
            ProgressText.Text = "精简完成";
        }

        private string[] GetLangsList()
        {
            return File.ReadAllText("clean\\lang.txt").Split('|');
        }

        private void RemoveMulLangs()
        {
            SetProgress(1, 0, "正在准备-删除多国语言包", "正在准备-删除多国语言包");
            List<FileInfo> lfi = getFiles(new FileInfo(PathBox.Text).DirectoryName);
            List<DirectoryInfo> ldi = getDirectory(new FileInfo(PathBox.Text).DirectoryName);
            string[] langs = GetLangsList();
            foreach (FileInfo fi in lfi)
            {
                foreach (string s in langs)
                {
                    if (fi.FullName.Contains(s))
                    {
                        SetProgress(1, (double)(fi.Length / 1048576.0), "正在删除-" + fi.Name, "删除-" + fi.FullName);
                        fi.Delete();
                    }
                }
            }
            foreach (DirectoryInfo di in ldi)
            {
                foreach (string s in langs)
                {
                    if (di.FullName.Contains(s) && s != langs[langs.Length - 1])
                    {
                        SetProgress(1, 0, "正在删除-" + di.Name, "删除-" + di.FullName);
                        try
                        {
                            di.Delete();
                        }
                        catch(Exception){}
                    }
                }
            }
        }

        private void ShowHideInfo_Click(object sender, EventArgs e)
        {
            MoreInfo.Visible = !MoreInfo.Visible;
        }
    }
}