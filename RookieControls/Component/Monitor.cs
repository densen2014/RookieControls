
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Timers;
using System.Linq;

namespace Monitor
{
    /// <summary>
    /// 监测IPv4v6网速及流量的实例代码
    /// </summary>
    public class MonitorNetwork
    {
        public string UpSpeed { get; set; }
        public string DownSpeed { get; set; }
        public string AllTraffic { get; set; }
        private string NetCardDescription { get; set; }
        //建立连接时上传的数据量
        private long BaseTraffic { get; set; }
        private long OldUp { get; set; }
        private long OldDown { get; set; }
        private NetworkInterface networkInterface { get; set; }
        private Timer timer = new Timer() { Interval = 1000 };

        public void Close()
        {
            timer.Stop();
        }

        public MonitorNetwork(string netCardDescription)
        {
            timer.Elapsed += Timer_Elapsed;
            NetCardDescription = netCardDescription;
            timer.Interval = 1000;
        }

        /// <summary>
        /// 网卡列表
        /// </summary>
        /// <returns></returns>
        public List<string> NicList()
        {
            var nicslist =new List<string>();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var var in nics) nicslist.Add(var.Description); 
            return nicslist;
        }

        /// <summary>
        /// 启动
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            networkInterface = null;
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var var in nics)
            {
                if (var.Description.Contains(NetCardDescription))
                {
                    networkInterface = var;
                    break;
                }
            }
            if (networkInterface == null)
            {
                return false;
            }
            else
            {
                BaseTraffic = (networkInterface.GetIPv4Statistics().BytesSent +
                        networkInterface.GetIPv4Statistics().BytesReceived);
                OldUp = networkInterface.GetIPv4Statistics().BytesSent;
                OldDown = networkInterface.GetIPv4Statistics().BytesReceived;
                timer.Start();
                return true;
            }

        }

        private string[] units = new string[] { "KB/s", "MB/s", "GB/s" };

        private void CalcUpSpeed()
        {
            long nowValue = networkInterface.GetIPv4Statistics().BytesSent;
            int num = 0;
            double value = (nowValue - OldUp) / 1024.0;
            while (value > 1023)
            {
                value = (value / 1024.0);
                num++;
            }
            UpSpeed = value.ToString("0.0") + units[num];
            OldUp = nowValue;
        }

        private void CalcDownSpeed()
        {
            long nowValue = networkInterface.GetIPv4Statistics().BytesReceived;
            int num = 0;
            double value = (nowValue - OldDown) / 1024.0;
            while (value > 1023)
            {
                value = (value / 1024.0);
                num++;
            }
            DownSpeed = value.ToString("0.0") + units[num];
            OldDown = nowValue;
        }

        private string[] unitAlls = new string[] { "KB", "MB", "GB", "TB" };

        private void CalcAllTraffic()
        {
            long nowValue = OldDown + OldUp;
            int num = 0;
            double value = (nowValue - BaseTraffic) / 1024.0;
            while (value > 1023)
            {
                value = (value / 1024.0);
                num++;
            }
            AllTraffic = value.ToString("0.0") + unitAlls[num];
        }

        /// <summary>
        /// 计算速度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CalcUpSpeed();
            CalcDownSpeed();
            CalcAllTraffic();
        }
    }
}