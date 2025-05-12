// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rookie.Component
{
    public class GradientPanel : Panel
    {
        public int CornerRadius { get; set; } = 16;

        // 普通状态颜色
        public Color GradientColor1 { get; set; } = Color.White;
        public Color GradientColor2 { get; set; } = Color.LightGreen;

        // 悬停状态颜色
        public Color HoverGradientColor1 { get; set; } = Color.LightYellow;
        public Color HoverGradientColor2 { get; set; } = Color.YellowGreen;

        private bool isHover = false;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHover = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHover = false;
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = this.ClientRectangle;

            Color color1 = isHover ? HoverGradientColor1 : GradientColor1;
            Color color2 = isHover ? HoverGradientColor2 : GradientColor2;

            using (GraphicsPath path = GetRoundRectangle(rect, CornerRadius))
            using (var brush = new LinearGradientBrush(rect, color1, color2, LinearGradientMode.Horizontal))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = GetRoundRectangle(this.ClientRectangle, CornerRadius))
            using (var pen = new Pen(Color.LightGreen, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundRectangle(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}

