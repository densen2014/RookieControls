namespace Rookie.Component
{
    partial class InputNumber
    {
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.UpButton = new Rookie.Component.RoundButton();
            this.DownButton = new Rookie.Component.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown1.Location = new System.Drawing.Point(27, 7);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // UpButton
            // 
            this.UpButton.BorderWidth = 2;
            this.UpButton.DistanceToBorder = 4;
            this.UpButton.Font = new System.Drawing.Font("幼圆", 13F);
            this.UpButton.IconColor2 = System.Drawing.Color.Red;
            this.UpButton.IsShowIcon = false;
            this.UpButton.Location = new System.Drawing.Point(75, 2);
            this.UpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(28, 30);
            this.UpButton.TabIndex = 2;
            this.UpButton.Text = "+";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.BorderWidth = 2;
            this.DownButton.DistanceToBorder = 4;
            this.DownButton.Font = new System.Drawing.Font("幼圆", 13F);
            this.DownButton.IconColor2 = System.Drawing.Color.Red;
            this.DownButton.IsShowIcon = false;
            this.DownButton.Location = new System.Drawing.Point(2, 2);
            this.DownButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(28, 30);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "-";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // InputNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InputNumber";
            this.Size = new System.Drawing.Size(107, 34);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public Rookie.Component.RoundButton UpButton;
        public Rookie.Component.RoundButton DownButton;
    }
}
