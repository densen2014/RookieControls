// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using System;
using System.Runtime.InteropServices;
public class NativeMethods
{
    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int GetDpiForWindow(IntPtr hWnd);
    public static float GetDisplayScaleFactor(IntPtr windowHandle)
    {
        try
        {
            return (GetDpiForWindow(windowHandle) / 96f);
        }
        catch
        {
            // Or fallback to GDI solutions above
            return 1;
        }

    }

}
