namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputNumber1 = new Rookie.Component.InputNumber();
            this.dataGridViewHiDpi1 = new Rookie.Component.DataGridViewHiDpi();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundButton1 = new Rookie.Component.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHiDpi1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(576, 58);
            this.inputNumber1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.inputNumber1.Size = new System.Drawing.Size(125, 49);
            this.inputNumber1.Step = 1;
            this.inputNumber1.TabIndex = 0;
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
            this.dataGridViewHiDpi1.Location = new System.Drawing.Point(141, 164);
            this.dataGridViewHiDpi1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewHiDpi1.Name = "dataGridViewHiDpi1";
            this.dataGridViewHiDpi1.RowTemplate.Height = 23;
            this.dataGridViewHiDpi1.Size = new System.Drawing.Size(640, 350);
            this.dataGridViewHiDpi1.TabIndex = 1;
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
            // roundButton1
            // 
            this.roundButton1.DistanceToBorder = 4;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.IconColor2 = System.Drawing.Color.Red;
            this.roundButton1.Location = new System.Drawing.Point(761, 42);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(100, 100);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 597);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.dataGridViewHiDpi1);
            this.Controls.Add(this.inputNumber1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHiDpi1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Rookie.Component.InputNumber inputNumber1;
        private Rookie.Component.DataGridViewHiDpi dataGridViewHiDpi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Rookie.Component.RoundButton roundButton1;
    }
}