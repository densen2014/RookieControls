using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class TextBoxWithPlaceholder : TextBox
{
    private const int EM_SETCUEBANNER = 0x1501;

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

    private string placeholder = string.Empty;
    public string Placeholder
    {
        get { return placeholder; }
        set
        {
            placeholder = value;
            SendMessage(Handle, EM_SETCUEBANNER, 0, Placeholder);
        }
    }


    //private void Form1_Load(object sender, EventArgs e)
    //{
    //    textBox1.Text = "此处是一些提示内容...";
    //    textBox1.LostFocus += TextBox1_LostFocus;
    //    textBox1.GotFocus += TextBox1_GotFocus;
    //}

    //private void TextBox1_GotFocus(object sender, EventArgs e)
    //{
    //    textBox1.Text = "";
    //}

    //private void TextBox1_LostFocus(object sender, EventArgs e)
    //{
    //    if (string.IsNullOrWhiteSpace(textBox1.Text))
    //        textBox1.Text = "此处是一些提示内容...";
    //}
}