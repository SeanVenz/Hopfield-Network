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

        
        int[] invec = new int[9];
        int[] outvec = new int[9];
        
        readonly int[,] wtarr = new int[9, 9] { { 0, 0, 2, -2, -2, -2, 2, 0, 2 },   //1
                                                { 0, 0, 0, 0, 0, 0, 0, 2, 0 },      //2
                                                { 2, 0, 0, -2, -2, -2, 2, 0, 2 },   //3
                                                { 2, 0, -2, 0, 2, 2, -2, 0, -2 },   //4
                                                { 2, 0, -2, 2, 0, 2, -2, 0 ,-2 },   //5
                                                { 2, 0, -2, 2, 2, 0, -2, 0 ,-2 },   //6
                                                { 2, 0, 2, -2, -2, -2, 0, 0, 2 },   //7
                                                { 0, 2, 0, 0, 0, 0, 0, 0, 0 },      //8
                                                { 2, 0, 2, -2, -2, -2, 2, 0, 0 } }; //9

        public string showInput(int[] values)
        {
            string str = "Neuron Inputs" + " = { ";
            for (int i = 0; i < 9; i++)
            {
                str += values[i] + ", ";
                invec[i] = values[i];
                outvec[i] = values[i];
            }
            str += "}";
            return str;
        }
        
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
                if (temp > 0)
                {
                    outvec[i] = 1;
                }
                else
                {
                    outvec[i] = -1;
                }
                output[i] = temp;
                temp = 0;
            }
            return output;
        }

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

        public int[] calculateThreshold(int[] result)
        {
            int[] threshold = new int[9];
            for (int i = 0; i < 9; i++)
            {
                threshold[i] = (result[i] >= 0) ? 1 : -1;
            }
            return threshold;
        }
    }
}
