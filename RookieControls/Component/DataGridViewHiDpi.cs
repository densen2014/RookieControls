using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Rookie.Component
{
    public partial class DataGridViewHiDpi : DataGridView
    {
        #region --成员变量--

        bool isInit;//是否已初始化
        #endregion


        #region --属性--

        /// <summary>
        /// 获取或设置按钮主体颜色渐变方向
        /// </summary>
        [Browsable(true), DefaultValue(1), Description("DPI放大率")]
        [Category("Appearance")]
        public double DpiRate { get; set; }

        #endregion


        #region --构造函数--
        /// <summary>
        /// 构造函数
        /// </summary>
        public DataGridViewHiDpi()
        {
            // 控件风格
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);

            DpiRate = 1;
            isInit = true;

            InitializeComponent();

        }
        #endregion


        #region --重写部分事件--

        #region OnPaint事件

        /// <summary>
        /// 控件绘制
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            base.OnPaintBackground(pevent);

            if (isInit) return;
            this.ColumnHeadersHeight = (int)(this.ColumnHeadersHeight * DpiRate);
            this.RowHeadersWidth = (int)(this.RowHeadersWidth * DpiRate);
            this.RowTemplate.Height = (int)(this.RowTemplate.Height * DpiRate);
            isInit = true;
        }

        #endregion
        #endregion

    }
}