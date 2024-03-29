using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CCSimplifier;

public partial class Simplifier : Form
{
    public Simplifier( )
    {
        InitializeComponent( );
        CheckForIllegalCrossThreadCalls = false;
    }

    private double DeletedSize;

    private void CancelClick(object o, EventArgs e)
    {
        Program.flag = false;
        Application.Exit( );
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

    private void BrowseClick(object o, EventArgs e)
    {
        DialogResult dr = OpenExecute.ShowDialog( );
        string name = Path.GetFileNameWithoutExtension(OpenExecute.FileName);
        if (dr == DialogResult.OK)
        {
            PathBox.Text = OpenExecute.FileName;
            AppName.Text = DoName(name);
            Icon icon = GetIcon.GetProgramIcon(OpenExecute.FileName, false);
            AppIcon.Image = icon.ToBitmap( );
        }
        Text = DoName(name) + "精简";
    }

    private void Simplified_Click(object o, EventArgs e)
    {
        Thread t = new(Simplifing);
        t.Start( );
    }

    private void SetProgress(int percent, double size, string text, string fullText)
    {
        ProgressPercent.Text = (int) ((Progress.Value + percent) / (Progress.Maximum / 100.0)) + "%";
        Progress.Value += percent;
        ProgressText.Text = text;
        MoreInfo.Items.Add(fullText.Replace(new FileInfo(PathBox.Text).DirectoryName + "\\", ""));
        DeletedSize += size;
        Deleted.Text = "已精简" + (int) DeletedSize + "MB";
    }

    public static IList<FileInfo> GetFiles(string path)
    {
        List<FileInfo> files = new( );
        DirectoryInfo root = new(path);
        foreach (DirectoryInfo dirInfo in root.GetDirectories( ))
            files.AddRange(GetFiles(dirInfo.FullName));
        foreach (FileInfo fileIfo in root.GetFiles( ))
            files.Add(fileIfo);
        return files;
    }

    public static IList<DirectoryInfo> GetDirectory(string path)
    {
        List<DirectoryInfo> directories = new( );
        DirectoryInfo root = new(path);
        foreach (DirectoryInfo directoryInfo in root.GetDirectories( ))
        {
            directories.Add(directoryInfo);
            directories.AddRange(GetDirectory(directoryInfo.FullName));
        }
        return directories;
    }

    private void Simplifing( )
    {
        MoreInfo.Items.Clear( );
        Progress.Value = 0;
        DeletedSize = 0;
        RemoveMulLangs( );
        Progress.Value = Progress.Maximum;
        ProgressPercent.Text = "100%";
        ProgressText.Text = "精简完成";
    }

    private string[] GetLangsList( )
        => File.ReadAllText(Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName, "clean\\lang.txt")).Split('|');

    private void RemoveMulLangs( )
    {
        SetProgress(1, 0, "正在准备-删除多国语言包", "正在准备-删除多国语言包");
        IList<FileInfo> fileInfos = GetFiles(new FileInfo(PathBox.Text).DirectoryName);
        IList<DirectoryInfo> dirInfos = GetDirectory(new FileInfo(PathBox.Text).DirectoryName);
        string[] langs = GetLangsList( );
        foreach (FileInfo info in fileInfos)
        {
            foreach (string lang in langs)
            {
                if (info.FullName.Contains(lang))
                {
                    SetProgress(1, info.Length / 1048576.0, "正在删除-" + info.Name, "删除-" + info.FullName);
                    info.Delete( );
                }
            }
        }
        foreach (DirectoryInfo info in dirInfos)
        {
            foreach (string lang in langs)
            {
                if (info.FullName.Contains(lang) && lang != langs[langs.Length - 1])
                {
                    SetProgress(1, 0, "正在删除 - " + info.Name, "删除 - " + info.FullName);
                    try { info.Delete( ); } catch (Exception) { }
                }
            }
        }
    }

    private void ShowHideInfoClick(object o, EventArgs e)
        => MoreInfo.Visible = !MoreInfo.Visible;
}
