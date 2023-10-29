// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Rookie.Component
{
    [Description("Label中文属性,一个例子")]
    public partial class LabelCN : Label
    {
        private static Font defaultfont = new System.Drawing.Font("华文彩云", 13);
        #region --属性--

        /// <summary>
        /// 获取或设置控件的前景色.
        /// </summary>
        [Browsable(true), DefaultValue("Black"), Description("获取或设置控件的前景色"), Category("Appearance")]
        public Color 前景色 { get => ForeColor; set => ForeColor = value; }

        /// <summary>
        /// 设置或获取字体.
        /// </summary>
        [Browsable(true), DefaultValue(typeof(Font), "华文琥珀,16pt"), Description("用于显示控件中文本的字体。")]
        [Category("Appearance")]
        public Font 字体 { get => Font; set => Font = value; }

        /// <summary>
        /// 设置或获取文本.
        /// </summary>
        [Browsable(true), Description("设置或获取文本"), Category("外观")]
        public string 文本 { get => Text; set => Text = value; }

        [Browsable(false)] public override Font Font { get; set; }
        [Browsable(false)] public override string Text { get; set; }
        [Browsable(false)] public override Color ForeColor { get; set; }


        #endregion


        #region --构造函数--

        /// <summary>
        /// 构造函数
        /// </summary>
        public LabelCN()
        {
            //Text = 文本;
            //Font = 字体;
            //ForeColor = 前景色;
            Font = new System.Drawing.Font("幼圆", 13);
        }

        /// <summary>
        /// 控件绘制
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }

        /// <summary>
        /// 鼠标点击事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            MessageBox.Show(DateTime.Now.ToString("HH:mm:ss"));
        }

        #endregion



    }

}
