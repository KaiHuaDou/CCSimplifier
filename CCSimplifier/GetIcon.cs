using System.Drawing;
using System.Runtime.InteropServices;
using static CCSimplifier.NativeMethods;

namespace CCSimplifier;

public static class GetIcon
{
    public static Icon GetProgramIcon(string strPath, bool bSmall)
    {
        SHFILEINFO info = new( );
        int cbFileInfo = Marshal.SizeOf(info);
        SHGFI flags = bSmall ? SHGFI.Icon | SHGFI.SmallIcon | SHGFI.UseFileAttributes : SHGFI.Icon | SHGFI.LargeIcon | SHGFI.UseFileAttributes;
        SHGetFileInfo(strPath, 256, out info, (uint) cbFileInfo, flags);
        return Icon.FromHandle(info.hIcon);
    }
}
