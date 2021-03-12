using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rookie.Component
{
    public partial class DataGridViewHiDpi : DataGridView
    {
        #region --属性--

        /// <summary>
        /// 获取或设置按钮主体颜色渐变方向
        /// </summary>
        [Browsable(true), DefaultValue(1), Description("DPI放大率,0=自动")]
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
            //HiDpi();
        }
        public void HiDpi()
        {
            DpiRate = DpiRate==0? NativeMethods.GetDisplayScaleFactor(this.Handle): DpiRate;
            this.ColumnHeadersHeight = (int)(this.ColumnHeadersHeight * DpiRate);
            this.RowHeadersWidth = (int)(this.RowHeadersWidth * DpiRate);
            this.RowTemplate.Height = (int)(this.RowTemplate.Height * DpiRate);
            
         }

        #endregion

        private void Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

    }
}
