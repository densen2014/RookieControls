// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Rookie.Component
{
    [Description("数字输入框")]
    public partial class InputNumber : UserControl
    {
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public Rookie.Component.RoundButton UpButton;
        public Rookie.Component.RoundButton DownButton;

        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            UpButton = new Rookie.Component.RoundButton();
            DownButton = new Rookie.Component.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown1)).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            numericUpDown1.Location = new System.Drawing.Point(27, 7);
            numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(54, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Tag = "Size(119, 35)";
            numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += new System.EventHandler(numericUpDown1_ValueChanged);
            // 
            // UpButton
            // 
            UpButton.BorderWidth = 2;
            UpButton.DistanceToBorder = 4;
            UpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            UpButton.IconColor2 = System.Drawing.Color.Red;
            UpButton.IsShowIcon = false;
            UpButton.Location = new System.Drawing.Point(75, 2);
            UpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            UpButton.Name = "UpButton";
            UpButton.Size = new System.Drawing.Size(30, 31);
            UpButton.TabIndex = 2;
            UpButton.Tag = "Size(55, 55)";
            UpButton.Text = "➕";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += new System.EventHandler(UpButton_Click);
            // 
            // DownButton
            // 
            DownButton.BorderWidth = 2;
            DownButton.DistanceToBorder = 4;
            DownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DownButton.IconColor2 = System.Drawing.Color.Red;
            DownButton.IsShowIcon = false;
            DownButton.Location = new System.Drawing.Point(2, 2);
            DownButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            DownButton.Name = "DownButton";
            DownButton.Size = new System.Drawing.Size(30, 31);
            DownButton.TabIndex = 3;
            DownButton.Tag = "Size(55, 55)";
            DownButton.Text = "➖";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += new System.EventHandler(DownButton_Click);
            // 
            // InputNumber
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(DownButton);
            Controls.Add(UpButton);
            Controls.Add(numericUpDown1);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "InputNumber";
            Size = new System.Drawing.Size(107, 34);
            ((System.ComponentModel.ISupportInitialize)(numericUpDown1)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        public InputNumber()
        {
            InitializeComponent();
            numericUpDown1.Controls.RemoveAt(0);
        }

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

        private int _value;

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
