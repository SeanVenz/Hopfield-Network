using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        Hopfield hopfield = new Hopfield();
        int[] values = new int[9];

        private void button82_Click(object sender, EventArgs e)
        {
            //every time the calculate button is clicked, we check the color of each button and 
            //change the values in the array
            values[0] = button1.BackColor == Color.Black ? 1 : -1;
            values[1] = button2.BackColor == Color.Black ? 1 : -1;
            values[2] = button3.BackColor == Color.Black ? 1 : -1;
            values[3] = button4.BackColor == Color.Black ? 1 : -1;
            values[4] = button5.BackColor == Color.Black ? 1 : -1;
            values[5] = button6.BackColor == Color.Black ? 1 : -1;
            values[6] = button7.BackColor == Color.Black ? 1 : -1;
            values[7] = button8.BackColor == Color.Black ? 1 : -1;
            values[8] = button9.BackColor == Color.Black ? 1 : -1;

            //show input value on textbox
            label4.Text = hopfield.showInput(values);

            //store in int result the multiplication of matrices
            int[] result = hopfield.asyncMultiplication(values);

            //show result on textbox3
            label5.Text = hopfield.showOutput(result);

            //calculate threshold for each value
            int[] threshold = hopfield.calculateThreshold(result);

            //show threshold on textbox4
            label6.Text = hopfield.printThreshold(result);
            
            //group button10 to button18
            Button[] btns = { button10, button11, button12,
                            button13, button14, button15,
                            button16, button17, button18 };

            //loop through the buttons with their corresponding output[] values
            for (int i = 0; i < 9; i++)
            {
                btns[i].BackColor = (threshold[i] > 0) ? Color.Black : Color.White;
            }
        }

        /// <summary>
        /// Resets all the inputted and outputted values
        /// </summary>
        private void button19_Click(object sender, EventArgs e)
        {
            //group button1 to button18
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9,
                                button10, button11, button12, button13, button14, button15, button16, button17, button18 };

            for (int i = 0; i < 18; i++)
            {
                buttons[i].BackColor = Color.White;
                for (int j = 0; j < 9; j++)
                {
                    values[j] = -1;
                    label4.Text = "Neuron Inputs";
                    label5.Text = "Output";
                    label6.Text = "Threshold";
                }
            }
        }

        /// <summary>
        /// Changes the color of the button when clicked, 
        /// depending on its precedent color
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = (button1.BackColor == Color.White) ? Color.Black : Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = (button2.BackColor == Color.White) ? Color.Black : Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = (button3.BackColor == Color.White) ? Color.Black : Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = (button4.BackColor == Color.White) ? Color.Black : Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = (button5.BackColor == Color.White) ? Color.Black : Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = (button6.BackColor == Color.White) ? Color.Black : Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = (button7.BackColor == Color.White) ? Color.Black : Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = (button8.BackColor == Color.White) ? Color.Black : Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = (button9.BackColor == Color.White) ? Color.Black : Color.White;
        }
    }
}
