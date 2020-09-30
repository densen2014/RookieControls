using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridViewHiDpi1.HiDpi();

            for (int i = 0; i < 10; i++)
            {
                dataGridViewHiDpi1.Rows.Add(i.ToString());
            }

        }
    }
}
