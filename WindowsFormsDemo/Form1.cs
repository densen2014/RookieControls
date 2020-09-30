using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Color> pColors = new List<Color>() { Color.Red, Color.Blue, Color.Yellow };
        List<Point> posPoint = new List<Point>() { new Point(20, 20), new Point(40, 30) };

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

       

        private List<Circle> Circles = new List<Circle>();
        private Circle circle = new Circle();

        private void roundButton2_Click(object sender, EventArgs e)
        {
            _ = AsyncBreakfast.Program.Main();

        }
    }
    public class Circle
    {
        public int Radii { get; set; }
        public Size Size { get; set; }
        public Point Location { get; set; }
    }

}

public static class util
{

    #region 设置GDI高质量模式抗锯齿
    /// <summary>
    /// 设置GDI高质量模式抗锯齿
    /// </summary>
    /// <param name="g">Graphics</param>
    public static void SetGDIHigh(this Graphics g)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        g.CompositingQuality = CompositingQuality.HighQuality;
    }
    #endregion

}


