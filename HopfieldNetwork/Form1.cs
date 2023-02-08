using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopfieldNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] values = new int[9];

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.White)
            {
                button1.BackColor = Color.Black;
                values[0] = 1;
            }
            else
            {
                button1.BackColor = Color.White;
                values[0] = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.White)
            {
                button2.BackColor = Color.Black;
                values[1] = 1;
            }
            else
            {
                button2.BackColor = Color.White;
                values[2] = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.White)
            {
                button3.BackColor = Color.Black;
                values[2] = 1;
            }
            else
            {
                button3.BackColor = Color.White;
                values[2] = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.White)
            {
                button4.BackColor = Color.Black;
                values[3] = 1;
            }
            else
            {
                button4.BackColor = Color.White;
                values[3] = -1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.White)
            {
                button5.BackColor = Color.Black;
                values[4] = 1;
            }
            else
            {
                button5.BackColor = Color.White;
                values[4] = -1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.White)
            {
                button6.BackColor = Color.Black;
                values[5] = 1;
            }
            else
            {
                button6.BackColor = Color.White;
                values[5] = -1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.White)
            {
                button7.BackColor = Color.Black;
                values[6] = 1;
            }
            else
            {
                button7.BackColor = Color.White;
                values[6] = -1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.White)
            {
                button8.BackColor = Color.Black;
                values[7] = 1;
            }
            else
            {
                button8.BackColor = Color.White;
                values[7] = -1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.White)
            {
                button9.BackColor = Color.Black;
                values[8] = 1;
            }
            else
            {
                button9.BackColor = Color.White;
                values[8] = -1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button82_Click(object sender, EventArgs e)
        {
            textBox2.Text = values[8].ToString();
        }
    }
}
