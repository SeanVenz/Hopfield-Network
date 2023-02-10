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

        /// <summary>
        /// THIS PROGRAM IS FOR A HOPFIELD NETWORK WITH LAYERS OF FULLY INTERCONNECTED NEURONS. 
        /// THE NETWORK SHOULD RECALL THE PATTERNS PLUS "+" AND MINUS "-" symbols CORRECTLY
        /// sakto ba ni dol remove lang dol if dele
        /// </summary>

        int[] values = { -1, -1, -1, -1, -1, -1, -1, -1, -1 }; 
        int[] output = new int[9];
        readonly int[,] wtarr = new int[9, 9] { { 0, 0, 2, -2, -2, -2, 2, 0, 2 },
                                                { 0, 0, 0, 0, 0, 0, 0, 2, 0 },
                                                { 2, 0, 0, -2, -2, -2, 2, 0, 2 },
                                                { 2, 0, -2, 0, 2, 2, -2, 0, -2 },
                                                { 2, 0, -2, 2, 0, 2, -2, 0 ,-2 },
                                                { 2, 0, -2, 2, 2, 0, -2, 0 ,-2 },
                                                { 2, 0, 2, -2, -2, -2, 0, 0, 2 },
                                                { 0, 2, 0, 0, 0, 0, 0, 0, 0 },
                                                { 2, 0, 2, -2, -2, -2, 2, 0, 0 } };


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
            //textBox2.Text = values[8].ToString();
            string newStr = "Neuron Inputs" + " = { ";
            for (int i = 0; i < 9; i++)
            {
                newStr += values[i] + ", ";
            }
            newStr += "}";
            textBox2.Text = newStr;
            int temp = 0;
            
            //multiplication and addition of weights and input values
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    temp += (values[j] * wtarr[i, j]);
                }
                output[i] = temp;
                temp = 0;
            }

            string newStr2 = "Output" + " = { ";
            for (int i = 0; i < 9; i++)
            {
                newStr2 += output[i] + ", ";
            }
            newStr2 += "}";
            textBox3.Text = newStr2;

            button10.BackColor = (output[0] > 0) ? Color.Black : Color.White;
            button11.BackColor = (output[1] > 0) ? Color.Black : Color.White;
            button12.BackColor = (output[2] > 0) ? Color.Black : Color.White;
            button13.BackColor = (output[3] > 0) ? Color.Black : Color.White;
            button14.BackColor = (output[4] > 0) ? Color.Black : Color.White;
            button15.BackColor = (output[5] > 0) ? Color.Black : Color.White;
            button16.BackColor = (output[6] > 0) ? Color.Black : Color.White;
            button17.BackColor = (output[7] > 0) ? Color.Black : Color.White;
            button18.BackColor = (output[8] > 0) ? Color.Black : Color.White;


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
