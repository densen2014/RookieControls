using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.Drawing.Imaging;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;
using System.Threading;

namespace AME.win.Util
{
    public partial class UcCamQrCode : UserControl
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public UcCamQrCode()
        {
            InitializeComponent();

            this.Load += UcCamQrCode_Load;
            //this.FormClosing += UcCamQrCode_Disposing;
            this.btnStart.Click += btnStart_Click;
            this.btnDecode.Click += btnDecode_Click;
            this.btnScreenDecode.Click += btnScreenDecode_Click;
            this.timer1.Tick += timer1_Tick;
            this.timerRepeat.Tick +=  timerRepeat_Tick;
        }

        public void UcCamQrCode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cboCamera.Items.Add(Device.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();


        }


        public void UcCamQrCode_Disposing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
                return;
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
            if (!timer1.Enabled) timer1.Start();
        }

        public void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelStatus.Text = labelStatus.Text == "识别中" ? " 识别中" : "识别中";
            try
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    if (txtResult.Text != result.ToString())
                        listBoxResult.Items.Insert(0, result.ToString());
                    txtResult.Text = result.ToString();
                    Messenger.Default.Send<string>(result.ToString(), "MessengerUcCamQrCode");
                    if (checkBoxReadAndStop.Checked)
                    {
                        timer1.Stop();
                        labelStatus.Text = "停止识别";
                    }
                    else
                    {
                        timer1.Stop();
                        labelStatus.Text = "暂停";
                        timerRepeat.Start();

                    }
                }

            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
            }

        }

        private void timerRepeat_Tick(object sender, EventArgs e)
        {
            timerRepeat.Stop();
            timer1.Start();
        }

        public void btnDecode_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                labelStatus.Text = "停止识别";
            }

        }

        public void btnScreenDecode_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
            pictureBox1.Image = 录屏();
            if (!timer1.Enabled) timer1.Start();
        }

        public Bitmap 录屏()
        {
            try

            {

                //Creating a Rectangle object which will  
                //capture our Current Screen
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

                //Creating a new Bitmap object
                Bitmap captureBitmap = new Bitmap(captureRectangle.Width, captureRectangle.Height, PixelFormat.Format32bppArgb);


                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                //Displaying the Successfull Result

                return captureBitmap;

            }

            catch (Exception ex)

            {

                return null;

            }


        }

    }
}
