using System;
using System.Windows.Forms;

namespace WinForms6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AutoScaleMode = AutoScaleMode.Dpi; //添加这句,要在'InitializeComponent();'上方
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = this.Width + "x" + this.Height + 启动环境();
        }
        public static string 启动环境()
        {
#if NET461
            return (".NET Framework 4.6.1");
#elif NET6_0
            return (".NET6");
#endif
        }


    }
}