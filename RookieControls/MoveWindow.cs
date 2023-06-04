// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using System;
using System.Drawing;
using System.Windows.Forms;

namespace AME.win.Util
{
    public class MoveWindow:Form 
    {
        #region "移动窗体"

        public void CtrlAddHandler(Control ctrl)
        {
            ctrl.MouseDown += lbTitle_MouseDown;
            ctrl.MouseMove += lbTitle_MouseMove;
            ctrl.MouseUp += lbTitle_MouseUp;
        }


        /// <summary>
        /// 重写WndProc方法,实现窗体移动和禁止双击最大化
        /// </summary>
        /// <param name="m">Windows 消息</param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case 0x84:
                    //鼠标点任意位置后可以拖动窗体
                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == 0x1)
                    {
                        m.Result = new IntPtr(0x2);
                    }
                    break;
                case 0xa3:
                    //禁止双击最大化
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }


        Point pointStart;
        private void lbTitle_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pointStart.X = e.X;
            pointStart.Y = e.Y;
        }


        private void lbTitle_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pointStart.X > 0)
                this.Location = new Point(this.Location.X + e.Location.X - pointStart.X, this.Location.Y + e.Location.Y - pointStart.Y);
        }


        private void lbTitle_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pointStart = new Point();
        }



        #endregion

    }
}
