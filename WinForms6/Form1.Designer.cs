namespace WinForms6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridViewHiDpi1 = new Rookie.Component.DataGridViewHiDpi();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundButton1 = new Rookie.Component.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHiDpi1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(40, 35);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 200);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "拉拉拉";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHiDpi1
            // 
            this.dataGridViewHiDpi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHiDpi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewHiDpi1.DpiRate = 0D;
            this.dataGridViewHiDpi1.Location = new System.Drawing.Point(40, 278);
            this.dataGridViewHiDpi1.Name = "dataGridViewHiDpi1";
            this.dataGridViewHiDpi1.RowHeadersWidth = 72;
            this.dataGridViewHiDpi1.RowTemplate.Height = 36;
            this.dataGridViewHiDpi1.Size = new System.Drawing.Size(733, 530);
            this.dataGridViewHiDpi1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // roundButton1
            // 
            this.roundButton1.DistanceToBorder = 4;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.IconColor2 = System.Drawing.Color.Red;
            this.roundButton1.Location = new System.Drawing.Point(288, 62);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(140, 140);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 936);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.dataGridViewHiDpi1);
            this.Controls.Add(this.iconButton1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHiDpi1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Rookie.Component.DataGridViewHiDpi dataGridViewHiDpi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Rookie.Component.RoundButton roundButton1;
    }
}