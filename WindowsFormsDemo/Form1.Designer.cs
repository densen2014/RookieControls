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
            this.inputNumber1 = new Rookie.Component.InputNumber();
            this.roundButton4 = new Rookie.Component.RoundButton();
            this.roundButton2 = new Rookie.Component.RoundButton();
            this.roundButton1 = new Rookie.Component.RoundButton();
            this.dataGridViewHiDpi1 = new Rookie.Component.DataGridViewHiDpi();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundButtonToast消息提示框 = new Rookie.Component.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHiDpi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(20, 14);
            this.inputNumber1.Margin = new System.Windows.Forms.Padding(1);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(110, 39);
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
            this.roundButton4.Location = new System.Drawing.Point(778, 13);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(111, 113);
            this.roundButton4.TabIndex = 4;
            this.roundButton4.Text = "roundButton4";
            this.roundButton4.UseVisualStyleBackColor = true;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.DistanceToBorder = 4;
            this.roundButton2.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundButton2.IconColor2 = System.Drawing.Color.Red;
            this.roundButton2.IsShowIcon = false;
            this.roundButton2.Location = new System.Drawing.Point(792, 262);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(96, 67);
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
            this.roundButton1.Location = new System.Drawing.Point(786, 138);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(102, 105);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHiDpi1
            // 
            this.dataGridViewHiDpi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHiDpi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewHiDpi1.DpiRate = 0D;
            this.dataGridViewHiDpi1.Location = new System.Drawing.Point(75, 120);
            this.dataGridViewHiDpi1.Name = "dataGridViewHiDpi1";
            this.dataGridViewHiDpi1.RowTemplate.Height = 23;
            this.dataGridViewHiDpi1.Size = new System.Drawing.Size(542, 253);
            this.dataGridViewHiDpi1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(75, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(542, 219);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "默认DGV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "支持HiDpi的DGV";
            // 
            // roundButtonToast消息提示框
            // 
            this.roundButtonToast消息提示框.DistanceToBorder = 4;
            this.roundButtonToast消息提示框.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundButtonToast消息提示框.IconColor2 = System.Drawing.Color.Red;
            this.roundButtonToast消息提示框.IsShowIcon = false;
            this.roundButtonToast消息提示框.Location = new System.Drawing.Point(703, 345);
            this.roundButtonToast消息提示框.Name = "roundButtonToast消息提示框";
            this.roundButtonToast消息提示框.Size = new System.Drawing.Size(186, 98);
            this.roundButtonToast消息提示框.TabIndex = 2;
            this.roundButtonToast消息提示框.Text = "Toast消息提示框";
            this.roundButtonToast消息提示框.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewHiDpi1);
            this.Controls.Add(this.inputNumber1);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButtonToast消息提示框);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHiDpi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Rookie.Component.RoundButton roundButton1;
        private Rookie.Component.RoundButton roundButton2;
        private Rookie.Component.RoundButton roundButton4;
        private Rookie.Component.InputNumber inputNumber1;
        private Rookie.Component.DataGridViewHiDpi dataGridViewHiDpi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Rookie.Component.RoundButton roundButtonToast消息提示框;
    }
}

