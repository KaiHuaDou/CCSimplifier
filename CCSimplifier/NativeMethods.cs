using System;
using System.Runtime.InteropServices;

namespace CCSimplifier;
internal sealed class NativeMethods
{
    [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
    internal static extern int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

    [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
    internal static extern int SHGetFileInfo
    (
        string pszPath,
        uint dwFileAttributes,
        out SHFILEINFO psfi,
        uint cbfileInfo,
        SHGFI uFlags
    );

    [StructLayout(LayoutKind.Sequential)]
    internal struct SHFILEINFO
    {
        public SHFILEINFO( )
        {
            hIcon = IntPtr.Zero;
            iIcon = 0;
            dwAttributes = 0;
            szDisplayName = "";
            szTypeName = "";
        }
        public IntPtr hIcon;
        public int iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.LPStr, SizeConst = 80)]
        public string szTypeName;
    };

    internal enum SHGFI
    {
        SmallIcon = 0x00000001,
        LargeIcon = 0x00000000,
        Icon = 0x00000100,
        DisplayName = 0x00000200,
        Typename = 0x00000400,
        SysIconIndex = 0x00004000,
        UseFileAttributes = 0x00000010
    }
}
