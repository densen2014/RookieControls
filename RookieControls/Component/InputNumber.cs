using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rookie.Component
{
    [Description("数字输入框")]
    public partial class InputNumber : UserControl
    {
        /// <summary>
        /// 设置初始数值, 默认 0
        /// </summary>
        [Browsable(true), DefaultValue(0), Description("设置初始数值")]
        [Category("Data")]
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                numericUpDown1.Value = value;
            }
        }
        int _value;

        /// <summary>
        /// 设置步进数值, 默认 1
        /// <para>获取或设置单击向上或向下按钮时，数字显示框（也称作 up-down 控件）递增或递减的值。</para>
        /// </summary>
        [Browsable(true), DefaultValue(0), Description("设置步进数值")]
        [Category("Data")]
        public int Step
        {
            get => Convert.ToInt32(numericUpDown1.Increment);
            set => numericUpDown1.Increment = value;
        }

        /// <summary>
        /// 设置最大值, 默认 100
        /// </summary>
        [Browsable(true), DefaultValue(100), Description("设置最大值")]
        [Category("Data")]
        public decimal Maximum
        {
            get => numericUpDown1.Maximum;
            set => numericUpDown1.Maximum = value;
        }


        /// <summary>
        /// 设置最小值, 默认 0
        /// </summary>
        [Browsable(true), DefaultValue(0), Description("设置最小值")]
        [Category("Data")]
        public decimal Minimum
        {
            get => numericUpDown1.Minimum;
            set => numericUpDown1.Minimum = value;
        }

        /// <summary>
        /// 在以某种方式更改 Value 属性后发生。
        /// </summary>
        [Browsable(true), Description("在以某种方式更改 Value 属性后发生")]
        [Category("Action")]
        public event ValueChangedHandler ValueChanged;
        public delegate void ValueChangedHandler(int value);
        protected void OnValueChangedEvent(int value) => ValueChanged?.Invoke(value);

        /// <summary>
        /// 在 Down 后发生。
        /// </summary>
        [Browsable(true), Description("在 Down 后发生。")]
        [Category("Action")]
        public event ValueDownHandler ValueDown;
        public delegate void ValueDownHandler(int value);
        protected void OnValueDownEvent(int value) => ValueDown?.Invoke(value);

        /// <summary>
        /// 在 Up 后发生。
        /// </summary>
        [Browsable(true), Description("在 Up 后发生")]
        [Category("Action")] //操作
        //[Category("Behavior")] //行为类别
        public event ValueUpHandler ValueUp;
        public delegate void ValueUpHandler(int value);
        protected void OnValueUpEvent(int value) => ValueUp?.Invoke(value);

        public InputNumber()
        {
            InitializeComponent();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.DownButton();
            OnValueDownEvent(Value);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.UpButton();
            OnValueUpEvent(Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Value = Convert.ToInt32(numericUpDown1.Value);
            OnValueChangedEvent(Convert.ToInt32(numericUpDown1.Value));
        }
    }
}
