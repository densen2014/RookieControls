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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DropDown网卡 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Status网速 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Button切换 = new System.Windows.Forms.ToolStripSplitButton();
            this.启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxWithPlaceholder1 = new TextBoxWithPlaceholder();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCN1 = new Rookie.Component.LabelCN();
            this.roundButton1 = new Rookie.Component.RoundButton();
            this.roundButton4 = new Rookie.Component.RoundButton();
            this.roundButton2 = new Rookie.Component.RoundButton();
            this.roundButtonToast消息提示框 = new Rookie.Component.RoundButton();
            this.roundButton3 = new Rookie.Component.RoundButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHiDpi1 = new Rookie.Component.DataGridViewHiDpi();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.inputNumber1 = new Rookie.Component.InputNumber();
            this.pictureBoxZoomMouseWheel1 = new Rookie.Component.PictureBoxZoomMouseWheel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHiDpi1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(16, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(428, 197);
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
            this.label1.Location = new System.Drawing.Point(264, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "默认DGV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "支持HiDpi的DGV";
            // 
            // iconButton4
            // 
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.iconButton4.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(242, 20);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(70, 43);
            this.iconButton4.TabIndex = 11;
            this.iconButton4.Text = "点我";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.iconButton3.IconColor = System.Drawing.Color.DarkOrange;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(166, 20);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(70, 43);
            this.iconButton3.TabIndex = 10;
            this.iconButton3.Text = "点我";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.iconButton2.IconColor = System.Drawing.Color.Red;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(90, 20);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(70, 43);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "点我";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(14, 20);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(70, 43);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "点我";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDown网卡,
            this.Status网速,
            this.Button切换});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1238, 23);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DropDown网卡
            // 
            this.DropDown网卡.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDown网卡.Image = ((System.Drawing.Image)(resources.GetObject("DropDown网卡.Image")));
            this.DropDown网卡.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDown网卡.Name = "DropDown网卡";
            this.DropDown网卡.Size = new System.Drawing.Size(45, 21);
            this.DropDown网卡.Text = "网卡";
            this.DropDown网卡.ToolTipText = "网卡";
            // 
            // Status网速
            // 
            this.Status网速.Name = "Status网速";
            this.Status网速.Size = new System.Drawing.Size(32, 18);
            this.Status网速.Text = "网速";
            // 
            // Button切换
            // 
            this.Button切换.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Button切换.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.启动ToolStripMenuItem1});
            this.Button切换.Image = ((System.Drawing.Image)(resources.GetObject("Button切换.Image")));
            this.Button切换.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button切换.Name = "Button切换";
            this.Button切换.Size = new System.Drawing.Size(48, 21);
            this.Button切换.Text = "停止";
            this.Button切换.ButtonClick += new System.EventHandler(this.Button切换_ButtonClick);
            // 
            // 启动ToolStripMenuItem
            // 
            this.启动ToolStripMenuItem.Name = "启动ToolStripMenuItem";
            this.启动ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.启动ToolStripMenuItem.Text = "继续";
            this.启动ToolStripMenuItem.Click += new System.EventHandler(this.启动ToolStripMenuItem_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.暂停ToolStripMenuItem.Text = "暂停";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click);
            // 
            // 启动ToolStripMenuItem1
            // 
            this.启动ToolStripMenuItem1.Name = "启动ToolStripMenuItem1";
            this.启动ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.启动ToolStripMenuItem1.Text = "启动";
            this.启动ToolStripMenuItem1.Click += new System.EventHandler(this.启动ToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButton4);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 81);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iconButton(FontAwesome)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWithPlaceholder1);
            this.groupBox2.Location = new System.Drawing.Point(376, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 81);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "有占位文本的文本框 TextBoxWithPlaceholder";
            // 
            // textBoxWithPlaceholder1
            // 
            this.textBoxWithPlaceholder1.Location = new System.Drawing.Point(30, 28);
            this.textBoxWithPlaceholder1.Name = "textBoxWithPlaceholder1";
            this.textBoxWithPlaceholder1.Placeholder = "输入用户名";
            this.textBoxWithPlaceholder1.Size = new System.Drawing.Size(148, 21);
            this.textBoxWithPlaceholder1.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCN1);
            this.groupBox3.Controls.Add(this.roundButton1);
            this.groupBox3.Controls.Add(this.roundButton4);
            this.groupBox3.Controls.Add(this.roundButton2);
            this.groupBox3.Controls.Add(this.roundButtonToast消息提示框);
            this.groupBox3.Controls.Add(this.roundButton3);
            this.groupBox3.Location = new System.Drawing.Point(489, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 488);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "圆形按钮 RoundButton";
            // 
            // labelCN1
            // 
            this.labelCN1.Location = new System.Drawing.Point(18, 394);
            this.labelCN1.Name = "labelCN1";
            this.labelCN1.Size = new System.Drawing.Size(256, 21);
            this.labelCN1.TabIndex = 13;
            this.labelCN1.Text = "labelCN";
            this.labelCN1.前景色 = System.Drawing.Color.DarkCyan;
            this.labelCN1.字体 = new System.Drawing.Font("幼圆", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCN1.文本 = "labelCN";
            // 
            // roundButton1
            // 
            this.roundButton1.DistanceToBorder = 4;
            this.roundButton1.Font = new System.Drawing.Font("Arial", 16F);
            this.roundButton1.IconColor2 = System.Drawing.Color.Red;
            this.roundButton1.Location = new System.Drawing.Point(33, 32);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(102, 105);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // roundButton4
            // 
            this.roundButton4.ButtonCenterColorEnd = System.Drawing.Color.Aqua;
            this.roundButton4.ButtonCenterColorStart = System.Drawing.Color.Violet;
            this.roundButton4.DistanceToBorder = 4;
            this.roundButton4.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.roundButton4.Font = new System.Drawing.Font("Arial", 16F);
            this.roundButton4.IconColor2 = System.Drawing.Color.Red;
            this.roundButton4.Location = new System.Drawing.Point(161, 28);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(102, 105);
            this.roundButton4.TabIndex = 4;
            this.roundButton4.Text = "roundButton4";
            this.roundButton4.UseVisualStyleBackColor = true;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.DistanceToBorder = 4;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundButton2.IconColor2 = System.Drawing.Color.Red;
            this.roundButton2.IsShowIcon = false;
            this.roundButton2.Location = new System.Drawing.Point(39, 160);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(96, 67);
            this.roundButton2.TabIndex = 2;
            this.roundButton2.Text = "早餐";
            this.roundButton2.UseVisualStyleBackColor = true;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButtonToast消息提示框
            // 
            this.roundButtonToast消息提示框.DistanceToBorder = 4;
            this.roundButtonToast消息提示框.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundButtonToast消息提示框.IconColor2 = System.Drawing.Color.Red;
            this.roundButtonToast消息提示框.IsShowIcon = false;
            this.roundButtonToast消息提示框.Location = new System.Drawing.Point(61, 261);
            this.roundButtonToast消息提示框.Name = "roundButtonToast消息提示框";
            this.roundButtonToast消息提示框.Size = new System.Drawing.Size(186, 98);
            this.roundButtonToast消息提示框.TabIndex = 2;
            this.roundButtonToast消息提示框.Text = "Toast消息提示框";
            this.roundButtonToast消息提示框.UseVisualStyleBackColor = true;
            // 
            // roundButton3
            // 
            this.roundButton3.BorderWidth = 2;
            this.roundButton3.ButtonCenterColorEnd = System.Drawing.Color.Orange;
            this.roundButton3.ButtonCenterColorStart = System.Drawing.Color.Gold;
            this.roundButton3.DistanceToBorder = 4;
            this.roundButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundButton3.IconColor2 = System.Drawing.Color.Red;
            this.roundButton3.IsRectangle = true;
            this.roundButton3.IsShowIcon = false;
            this.roundButton3.Location = new System.Drawing.Point(184, 160);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(79, 54);
            this.roundButton3.TabIndex = 12;
            this.roundButton3.Text = "查询";
            this.roundButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dataGridViewHiDpi1);
            this.groupBox4.Location = new System.Drawing.Point(12, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 488);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "支持HiDpi的DGV DataGridViewHiDpi";
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
            this.dataGridViewHiDpi1.Location = new System.Drawing.Point(16, 47);
            this.dataGridViewHiDpi1.Name = "dataGridViewHiDpi1";
            this.dataGridViewHiDpi1.RowTemplate.Height = 23;
            this.dataGridViewHiDpi1.Size = new System.Drawing.Size(428, 209);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.inputNumber1);
            this.groupBox5.Location = new System.Drawing.Point(661, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 77);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数字输入框 InputNumber";
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(30, 22);
            this.inputNumber1.Margin = new System.Windows.Forms.Padding(1);
            this.inputNumber1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.inputNumber1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(110, 39);
            this.inputNumber1.Step = 1;
            this.inputNumber1.TabIndex = 0;
            // 
            // pictureBoxZoomMouseWheel1
            // 
            this.pictureBoxZoomMouseWheel1.Border = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxZoomMouseWheel1.Location = new System.Drawing.Point(10, 32);
            this.pictureBoxZoomMouseWheel1.Name = "pictureBoxZoomMouseWheel1";
            this.pictureBoxZoomMouseWheel1.Picture = null;
            this.pictureBoxZoomMouseWheel1.PictureFilePath = "C:\\Users\\Alex\\Pictures\\20190815113423759.jpg";
            this.pictureBoxZoomMouseWheel1.Size = new System.Drawing.Size(402, 441);
            this.pictureBoxZoomMouseWheel1.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBoxZoomMouseWheel1);
            this.groupBox6.Location = new System.Drawing.Point(798, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(428, 488);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "图片框带滚轮放大 PictureBoxZoomMouseWheel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 639);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHiDpi1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Rookie.Component.RoundButton roundButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status网速;
        private System.Windows.Forms.ToolStripDropDownButton DropDown网卡;
        private System.Windows.Forms.ToolStripSplitButton Button切换;
        private TextBoxWithPlaceholder textBoxWithPlaceholder1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem1;
        private Rookie.Component.LabelCN labelCN1;
        private Rookie.Component.PictureBoxZoomMouseWheel pictureBoxZoomMouseWheel1;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

