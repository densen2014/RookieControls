namespace WindowsFormsApp2
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.inputNumber1 = new Rookie.Component.InputNumber();
            this.roundButton4 = new Rookie.Component.RoundButton();
            this.roundButton3 = new Rookie.Component.RoundButton();
            this.roundButton2 = new Rookie.Component.RoundButton();
            this.roundButton1 = new Rookie.Component.RoundButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(142, 473);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(205, 68);
            this.inputNumber1.TabIndex = 0;
            // 
            // roundButton4
            // 
            this.roundButton4.ButtonCenterColorEnd = System.Drawing.Color.Aqua;
            this.roundButton4.ButtonCenterColorStart = System.Drawing.Color.Violet;
            this.roundButton4.DistanceToBorder = 4;
            this.roundButton4.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.roundButton4.Font = new System.Drawing.Font("Arial", 16F);
            this.roundButton4.IconColor2 = System.Drawing.Color.Red;
            this.roundButton4.Location = new System.Drawing.Point(904, 301);
            this.roundButton4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(471, 466);
            this.roundButton4.TabIndex = 4;
            this.roundButton4.Text = "roundButton4";
            this.roundButton4.UseVisualStyleBackColor = true;
            // 
            // roundButton3
            // 
            this.roundButton3.DistanceToBorder = 4;
            this.roundButton3.Font = new System.Drawing.Font("Arial", 16F);
            this.roundButton3.IconColor2 = System.Drawing.Color.Red;
            this.roundButton3.Location = new System.Drawing.Point(871, 21);
            this.roundButton3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(292, 268);
            this.roundButton3.TabIndex = 3;
            this.roundButton3.Text = "roundButton3";
            this.roundButton3.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.DistanceToBorder = 4;
            this.roundButton2.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundButton2.ForeColor = System.Drawing.Color.Green;
            this.roundButton2.IconColor2 = System.Drawing.Color.Red;
            this.roundButton2.IsShowIcon = false;
            this.roundButton2.Location = new System.Drawing.Point(422, 74);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(176, 118);
            this.roundButton2.TabIndex = 2;
            this.roundButton2.Text = "早餐";
            this.roundButton2.UseVisualStyleBackColor = true;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.DistanceToBorder = 4;
            this.roundButton1.Font = new System.Drawing.Font("Arial", 16F);
            this.roundButton1.IconColor2 = System.Drawing.Color.Red;
            this.roundButton1.Location = new System.Drawing.Point(73, 52);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(248, 236);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputNumber1);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Rookie.Component.RoundButton roundButton1;
        private Rookie.Component.RoundButton roundButton2;
        private Rookie.Component.RoundButton roundButton3;
        private Rookie.Component.RoundButton roundButton4;
        private Rookie.Component.InputNumber inputNumber1;
        private System.Windows.Forms.Button button1;
    }
}

