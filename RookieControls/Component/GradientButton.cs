using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rookie.Component
{
    public class GradientButton : Button
    {
        public int CornerRadius { get; set; } = 16;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = GetRoundRectangle(rect, CornerRadius))
            using (var brush = new LinearGradientBrush(rect, Color.LightSkyBlue, Color.SteelBlue, LinearGradientMode.Vertical))
            using (var pen = new Pen(this.Enabled ? Color.SteelBlue : Color.Gray, 1))
            {
                // 填充渐变圆角背景
                pevent.Graphics.FillPath(brush, path);

                // 绘制边框
                pevent.Graphics.DrawPath(pen, path);

                // 绘制文本
                TextRenderer.DrawText(
                    pevent.Graphics,
                    this.Text,
                    this.Font,
                    rect,
                    this.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
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
