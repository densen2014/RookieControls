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
    public partial class InputNumber : UserControl
    {
        public InputNumber()
        {
            InitializeComponent();

        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.DownButton();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.UpButton();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
