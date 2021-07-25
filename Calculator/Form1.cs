using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_1_Click(object sender, EventArgs e)
        {
            txt_Display.Text = "1";
            var bttn = sender as Button;
            Console.WriteLine(bttn.Name);
        }

        private void bttn_equals_Click(object sender, EventArgs e)
        {

        }

        private void bttn_minus_Click(object sender, EventArgs e)
        {

        }

        private void bttn_3_Click(object sender, EventArgs e)
        {

        }

        private void bttn_6_Click(object sender, EventArgs e)
        {

        }

        private void bttn_9_Click(object sender, EventArgs e)
        {

        }

        private void bttn_decimal_Click(object sender, EventArgs e)
        {

        }

        private void bttn_division_Click(object sender, EventArgs e)
        {

        }

        private void bttn_8_Click(object sender, EventArgs e)
        {

        }

        private void bttn_5_Click(object sender, EventArgs e)
        {

        }

        private void bttn_2_Click(object sender, EventArgs e)
        {

        }

        private void bttn_0_Click(object sender, EventArgs e)
        {

        }

        private void bttn_plus_Click(object sender, EventArgs e)
        {

        }

        private void bttn_4_Click(object sender, EventArgs e)
        {

        }

        private void bttn_7_Click(object sender, EventArgs e)
        {

        }

        private void bttn_x_Click(object sender, EventArgs e)
        {

        }

        private void bttn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
