using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;


/// <summary>
/// 有占位文本的文本框
/// </summary>
public class TextBoxWithPlaceholder : TextBox
{
    private const int EM_SETCUEBANNER = 0x1501;

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

    private string placeholder = string.Empty;

    /// <summary>
    /// 占位文本
    /// </summary>
    [Browsable(true), DefaultValue(""), Description("占位文本")]
    [Category("Appearance")]
    public string Placeholder
    {
        get { return placeholder; }
        set
        {
            placeholder = value;
            SendMessage(Handle, EM_SETCUEBANNER, 0, Placeholder);
        }
    }

}