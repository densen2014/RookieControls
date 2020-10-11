using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

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

    public partial class Toast : Form
    {
        public Toast()
        {
            InitializeComponent();
        }

        private int x, y;
        private AlertFormAction action;

        //时钟控制窗口背景渐入和淡出
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case AlertFormAction.Start:
                    timer1.Interval = 50;//警告显示的时间
                    this.Opacity += 0.1;
                    if (this.Opacity == 1.0)
                    {
                        action = AlertFormAction.Wait;
                    }
                    break;
                case AlertFormAction.Wait:
                    timer1.Interval = 3000;//警告框停留时间
                    action = AlertFormAction.Close;
                    break;
                case AlertFormAction.Close:
                    timer1.Interval = 50;//警告退出的时间
                    this.Opacity -= 0.1;
                    if (this.Opacity == 0.0)
                    {
                        this.Close();
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
                    this.pictureBox1.Image = IconChar.Info.ToBitmap(64, Color.White);
                    this.BackColor = Color.RoyalBlue;
                    break;
                case AlertType.Success:
                    this.pictureBox1.Image = IconChar.AlignLeft.ToBitmap(64, Color.White);  //Properties.Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case AlertType.Warning:
                    this.pictureBox1.Image = IconChar.AlignCenter.ToBitmap(64, Color.White);  //Properties.Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
                case AlertType.Error:
                    this.pictureBox1.Image = IconChar.CalendarMinus.ToBitmap(64, Color.White); //Properties.Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                default:
                    break;
            }
        }

        //当有多个消息的时候，消息框会重叠在一起；多个消息时，需要将消息窗口按一定的规则排列，这里我们设置每个消息窗口间隔一定的距离

        public void Show(string message, AlertType type)
        {
            // 设置窗口启始位置
            this.StartPosition = FormStartPosition.Manual;

            // 设置程序每个打开的消息窗口的位置，超过10个就不做处理，这个可以根据自己的需求设定
            string fname;
            for (int i = 1; i < 20; i++)
            {
                fname = "alert" + i.ToString();
                Toast alert = (Toast)Application.OpenForms[fname];
                if (alert == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(x, y);
                    break;
                }
            }

            labelContent.Text = message;
            this.Opacity = 0.0;
            SetAlertTheme(type);
            this.Show();

            action = AlertFormAction.Start;
            //启动时钟
            timer1.Start();

            // 注销鼠标事件
            this.MouseLeave += new System.EventHandler(this.AlertMessageForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AlertMessageForm_MouseMove);

        }

        //鼠标悬停警告框处理
        private void AlertMessageForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Opacity = 1.0;
            timer1.Interval = int.MaxValue;//警告框停留时间
            action = AlertFormAction.Close;
        }
 
        private void AlertMessageForm_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
            timer1.Interval = 3000;//警告框停留时间
            action = AlertFormAction.Close;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // 注销鼠标事件
            this.MouseLeave -= new System.EventHandler(this.AlertMessageForm_MouseLeave);
            this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.AlertMessageForm_MouseMove);

            timer1.Interval = 50;//警告关闭的时间
            this.Opacity -= 0.1;
            if (this.Opacity == 0.0)
            {
                this.Close();
            }
        }

    }
