using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rookie.Component
{
    public class GradientRainbowButton : Button
    {
        public int CornerRadius { get; set; } = 16;

        // 动画相关字段
        private Timer _timer;
        private int _hue = 0; // 色相值，0-359

        public GradientRainbowButton()
        {
            // 启动动画定时器
            _timer = new Timer();
            _timer.Interval = 30; // 每30ms刷新一次
            _timer.Tick += (s, e) =>
            {
                _hue = (_hue + 2) % 360;
                this.Invalidate();
            };
            _timer.Start();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = GetRoundRectangle(rect, CornerRadius))
            using (var brush = new LinearGradientBrush(
                rect,
                ColorFromHSV(_hue, 0.5, 1.0),
                ColorFromHSV((_hue + 60) % 360, 0.5, 1.0),
                LinearGradientMode.Vertical))
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

        // HSV转Color，便于做彩虹动画
        private Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            switch (hi)
            {
                case 0: return Color.FromArgb(255, v, t, p);
                case 1: return Color.FromArgb(255, q, v, p);
                case 2: return Color.FromArgb(255, p, v, t);
                case 3: return Color.FromArgb(255, p, q, v);
                case 4: return Color.FromArgb(255, t, p, v);
                default: return Color.FromArgb(255, v, p, q);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
            base.Dispose(disposing);
        }
    }
}
