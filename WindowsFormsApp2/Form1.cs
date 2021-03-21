using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Encoder = System.Drawing.Imaging.Encoder;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        class TaiJiTu
        {
            private Encoder myEncoder;
            private EncoderParameter myEncoderParameter;
            private EncoderParameters myEncoderParameters;

            public Bitmap makeTaiji()
            {
                int imgWidth = 400;                 //图象尺寸
                int eyeRadius = imgWidth / 20;      //鱼眼半径
                int headDiameter = imgWidth / 2;    //鱼头直径

                Bitmap image = new Bitmap(imgWidth, imgWidth);
                image.SetResolution(300, 300);

                Graphics graphics = Graphics.FromImage(image);

                //设置图像质量
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                //底色填充为白色
                Brush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, new Rectangle(0, 0, imgWidth, imgWidth));

                Brush blue = new SolidBrush(Color.Blue);//定义蓝色笔刷
                Brush red = new SolidBrush(Color.Red);//定义红色笔刷

                //整个圆形填充蓝色
                graphics.FillPie(blue, 0, 0, imgWidth, imgWidth, 0, 360);

                //定义右边的路径（红色部分）
                GraphicsPath redPath = new GraphicsPath();//初始化路径
                redPath.AddArc(0, 0, imgWidth, imgWidth, 0, -180);
                redPath.AddArc(0, headDiameter / 2, headDiameter, headDiameter, 0, -180);
                redPath.AddArc(headDiameter, headDiameter / 2, headDiameter, headDiameter, 0, 180);

                //填充右边部分
                graphics.FillPath(red, redPath);

                //填充红色眼睛
                graphics.FillPie(red, new Rectangle(headDiameter / 2 - eyeRadius, headDiameter - eyeRadius, eyeRadius * 2, eyeRadius * 2), 0, 360);
                //填充蓝色眼睛
                graphics.FillPie(blue, new Rectangle(headDiameter + headDiameter / 2 - eyeRadius, headDiameter - eyeRadius, eyeRadius * 2, eyeRadius * 2), 0, 360);

                graphics.Dispose();

                //写入到Response输出流中去，普通质量
                //image.Save(Response.OutputStream, ImageFormat.Jpeg);


                //修改图片保存质量
                ImageCodecInfo myImageCodecInfo = GetEncoder(ImageFormat.Jpeg);
                myEncoder = Encoder.Quality;
                myEncoderParameters = new EncoderParameters(1);
                //图片质量等级
                myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                myEncoderParameters.Param[0] = myEncoderParameter;

                //使用指定参数输出
                //image.Save(Response.OutputStream, myImageCodecInfo, myEncoderParameters);
                return image;
            }
            private static ImageCodecInfo GetEncoder(ImageFormat format)
            {
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

                foreach (ImageCodecInfo codec in codecs)
                {
                    if (codec.FormatID == format.Guid)
                    {
                        return codec;
                    }
                }
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var x = new TaiJiTu();
            this.BackgroundImage = x.makeTaiji();
        }
    }
}
