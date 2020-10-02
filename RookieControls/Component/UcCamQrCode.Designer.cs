namespace AME.win.Util
{
    partial class UcCamQrCode
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
            this.components = new System.ComponentModel.Container();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.btnScreenDecode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxReadAndStop = new System.Windows.Forms.CheckBox();
            this.timerRepeat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 12;
            this.listBoxResult.Location = new System.Drawing.Point(346, 129);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(221, 184);
            this.listBoxResult.TabIndex = 13;
            // 
            // btnScreenDecode
            // 
            this.btnScreenDecode.Location = new System.Drawing.Point(468, 27);
            this.btnScreenDecode.Name = "btnScreenDecode";
            this.btnScreenDecode.Size = new System.Drawing.Size(99, 33);
            this.btnScreenDecode.TabIndex = 12;
            this.btnScreenDecode.Text = "屏幕扫码";
            this.btnScreenDecode.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(346, 66);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(116, 28);
            this.btnDecode.TabIndex = 11;
            this.btnDecode.Text = "识别开/关";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(18, 291);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(308, 21);
            this.txtResult.TabIndex = 10;
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(346, 100);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(221, 20);
            this.cboCamera.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(346, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 33);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "摄像头扫码";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelStatus.Location = new System.Drawing.Point(146, 12);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 12);
            this.labelStatus.TabIndex = 14;
            // 
            // checkBoxReadAndStop
            // 
            this.checkBoxReadAndStop.AutoSize = true;
            this.checkBoxReadAndStop.Location = new System.Drawing.Point(478, 73);
            this.checkBoxReadAndStop.Name = "checkBoxReadAndStop";
            this.checkBoxReadAndStop.Size = new System.Drawing.Size(84, 16);
            this.checkBoxReadAndStop.TabIndex = 15;
            this.checkBoxReadAndStop.Text = "识别后停止";
            this.checkBoxReadAndStop.UseVisualStyleBackColor = true;
            // 
            // timerRepeat
            // 
            this.timerRepeat.Interval = 1000;
            // 
            // UcCamQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxReadAndStop);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnScreenDecode);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "UcCamQrCode";
            this.Size = new System.Drawing.Size(585, 339);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxResult;
        public System.Windows.Forms.Button btnScreenDecode;
        public System.Windows.Forms.Button btnDecode;
        public System.Windows.Forms.TextBox txtResult;
        public System.Windows.Forms.ComboBox cboCamera;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxReadAndStop;
        public System.Windows.Forms.Timer timerRepeat;
    }
}
