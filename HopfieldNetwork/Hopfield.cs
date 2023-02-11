using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNetwork
{
    internal class Hopfield
    {
        /// <summary>
        /// THIS PROGRAM IS FOR A HOPFIELD NETWORK WITH LAYERS OF FULLY INTERCONNECTED NEURONS. 
        /// THE NETWORK SHOULD RECALL THE PATTERNS PLUS "+" AND MINUS "-" symbols CORRECTLY
        /// AND REMEMBER SOME PATTERNS THAT ARE NOT IN THE TRAINING SET BUT LOOKS LIKE THE
        /// PLUS "+" AND MINUS "-" SYMBOLS.
        /// </summary>
        readonly int[,] wtarr = new int[9, 9] { { 0, 0, 2, -2, -2, -2, 2, 0, 2 },   //1
                                                { 0, 0, 0, 0, 0, 0, 0, 2, 0 },      //2
                                                { 2, 0, 0, -2, -2, -2, 2, 0, 2 },   //3
                                                { 2, 0, -2, 0, 2, 2, -2, 0, -2 },   //4
                                                { 2, 0, -2, 2, 0, 2, -2, 0 ,-2 },   //5
                                                { 2, 0, -2, 2, 2, 0, -2, 0 ,-2 },   //6
                                                { 2, 0, 2, -2, -2, -2, 0, 0, 2 },   //7
                                                { 0, 2, 0, 0, 0, 0, 0, 0, 0 },      //8
                                                { 2, 0, 2, -2, -2, -2, 2, 0, 0 } }; //9

        /// <summary>
        /// shows the input of the user to the UI
        /// </summary>
        /// <param name="values">array of values inputted by the user</param>
        /// <returns>a string of values inputted by the user</returns>
        public string showInput(int[] values)
        {
            string str = "Neuron Inputs" + " = { ";
            for (int i = 0; i < 9; i++)
            {
                str += values[i] + ", ";
            }
            str += "}";
            return str;
        }

        /// <summary>
        /// Multiplies the input vector by the weight matrix
        /// </summary>
        /// <param name="values">array of values inputted by the user</param>
        /// <returns>an array of values of the input vecotr multiplied by the weight matrix</returns>
        public int[] asyncMultiplication(int[] values)
        {
            int temp = 0;
            int[] output = new int[9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    temp += wtarr[i, j] * values[j];
                }
                if (temp >= 0)
                {
                    values[i] = 1;
                }
                else
                {
                    values[i] = -1;
                }
                output[i] = temp;
                temp = 0;
            }
            return output;
        }

        /// <summary>
        /// Shows the output of the matrix multiplication to the UI
        /// </summary>
        /// <param name="result">array of results when input is multiplied to the weight vector</param>
        /// <returns>an array of result</returns>
        public string showOutput(int[] result)
        {
            string str = "Output" + " = { ";
            for (int i = 0; i < 9; i++)
            {
                str += result[i] + ", ";
            }
            str += "}";
            return str;
        }

        /// <summary>
        /// Calculates the threshold value of the output
        /// </summary>
        /// <param name="result">Result matrix</param>
        /// <returns>The threshold value of the result</returns>
        public int[] calculateThreshold(int[] result)
        {
            int[] threshold = new int[9];
            for (int i = 0; i < 9; i++)
            {
                threshold[i] = (result[i] >= 0) ? 1 : -1;
            }
            return threshold;
        }

        /// <summary>
        /// Prints the threshold result
        /// </summary>
        /// <param name="result">the threshold of the result matrix</param>
        /// <returns>string of the threshold</returns>
        public string printThreshold(int[] result)
        {
            int[] threshold = calculateThreshold(result);
            string str = "Threshold" + " = { ";
            foreach(int i in threshold)
            {
                str += i + ", ";
            }
            str += "}";
            return str;
        }
    }
}
