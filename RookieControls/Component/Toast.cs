// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rookie.Component
{
    // 警告框的行为（显示，停留，退出）
    public enum AlertFormAction
    {
        Start,
        Wait,
        Close
    }
    //不同类型的警告框
    public enum AlertType
    {
        Info,
        Success,
        Warning,
        Error
    }
    //显示时间
    public enum AlertDuration
    {
        Short,
        Long,
        NeverHide
    }

    public partial class Toast : Form
    {
        public Toast()
        {
            InitializeComponent();
        }
        public Toast(string message, AlertType type, Form form = null, AlertDuration duration = AlertDuration.Short)
        {
            InitializeComponent();
            Show(message, type, duration);
            form?.Activate();
        }

        private int x, y;
        private AlertFormAction action;
        private AlertDuration duration = AlertDuration.Short;

        //时钟控制窗口背景渐入和淡出
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case AlertFormAction.Start:
                    timer1.Interval = 50;//警告显示的时间
                    Opacity += 0.1;
                    if (Opacity == 1.0)
                    {
                        action = AlertFormAction.Wait;
                    }
                    break;
                case AlertFormAction.Wait:
                    timer1.Interval = duration == AlertDuration.Short ? 5000 : (duration == AlertDuration.Long ? 1000 * 20 : 9999999);//警告框停留时间
                    action = AlertFormAction.Close;
                    break;
                case AlertFormAction.Close:
                    timer1.Interval = 50;//警告退出的时间
                    Opacity -= 0.1;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
                default:
                    break;
            }
        }

        //Bitmap bitmap = IconChar.BatteryEmpty.ToBitmap(16, Color.Black);

        // 设置警告框主题
        private void SetAlertTheme(AlertType type)
        {
            //var icons = Enum.GetValues(typeof(IconChar))
            //    .OfType<IconChar>()
            //    .Skip(1)
            //    .Take(10)
            //    .ToArray();

            switch (type)
            {
                case AlertType.Info:
                    pictureBox1.Image = IconChar.Info.ToBitmap(Color.White);
                    BackColor = Color.RoyalBlue;
                    break;
                case AlertType.Success:
                    pictureBox1.Image = IconChar.AlignLeft.ToBitmap(Color.White);  //Properties.Resources.success;
                    BackColor = Color.SeaGreen;
                    break;
                case AlertType.Warning:
                    pictureBox1.Image = IconChar.AlignCenter.ToBitmap(Color.White);  //Properties.Resources.warning;
                    BackColor = Color.DarkOrange;
                    break;
                case AlertType.Error:
                    pictureBox1.Image = IconChar.CalendarMinus.ToBitmap(Color.White); //Properties.Resources.error;
                    BackColor = Color.DarkRed;
                    break;
                default:
                    break;
            }
        }

        //当有多个消息的时候，消息框会重叠在一起；多个消息时，需要将消息窗口按一定的规则排列，这里我们设置每个消息窗口间隔一定的距离

        public void Show(string message, AlertType type, AlertDuration duration = AlertDuration.Short)
        {
            this.duration = duration;

            // 设置窗口启始位置
            StartPosition = FormStartPosition.Manual;

            // 设置程序每个打开的消息窗口的位置，超过10个就不做处理，这个可以根据自己的需求设定
            string fname;
            for (int i = 1; i < 20; i++)
            {
                fname = "alert" + i.ToString();
                Toast alert = (Toast)Application.OpenForms[fname];
                if (alert == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;
                }
            }

            labelContent.Text = message;
            Opacity = 0.0;
            SetAlertTheme(type);
            Show();

            action = AlertFormAction.Start;
            //启动时钟
            timer1.Start();

            // 注销鼠标事件
            MouseLeave += new System.EventHandler(AlertMessageForm_MouseLeave);
            MouseMove += new System.Windows.Forms.MouseEventHandler(AlertMessageForm_MouseMove);

        }

        //鼠标悬停警告框处理
        private void AlertMessageForm_MouseMove(object sender, MouseEventArgs e)
        {
            Opacity = 1.0;
            timer1.Interval = int.MaxValue;//警告框停留时间
            action = AlertFormAction.Close;
        }

        private void AlertMessageForm_MouseLeave(object sender, EventArgs e)
        {
            Opacity = 1.0;
            timer1.Interval = 3000;//警告框停留时间
            action = AlertFormAction.Close;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // 注销鼠标事件
            MouseLeave -= new System.EventHandler(AlertMessageForm_MouseLeave);
            MouseMove -= new System.Windows.Forms.MouseEventHandler(AlertMessageForm_MouseMove);

            timer1.Interval = 50;//警告关闭的时间
            Opacity -= 0.1;
            if (Opacity == 0.0)
            {
                Close();
            }
        }

    }
}

