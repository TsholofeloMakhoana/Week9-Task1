using Cal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cal.Logic
{
    public class CalculatorEngine 
    {
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="input_1"></param>
        /// <param name="input_2"></param>
        /// <returns></returns>
        public static int Addition(int input_1, int input_2)
        {
            return input_1 + input_2;
        }
        /// <summary>
        /// Subtracting two numbers
        /// </summary>
        /// <param name="input_1"></param>
        /// <param name="input_2"></param>
        /// <returns></returns>
        public static int Subtraction(int input_1, int input_2)
        {
            return input_1 - input_2;
        }
        /// <summary>
        /// Multiplicating two numbers
        /// </summary>
        /// <param name="input_1"></param>
        /// <param name="input_2"></param>
        /// <returns></returns>
        public static int Multiplication(int input_1, int input_2)
        {
            return input_1 * input_2;
        }
        /// <summary>
        /// Multiplication two numbers
        /// </summary>
        /// <param name="input_1"></param>
        /// <param name="input_2"></param>
        /// <returns></returns>
        public static int Division(int input_1, int input_2)
        {
            return input_1 / input_2;
        }
        /// <summary>
        /// Square of two numbers
        /// </summary>
        /// <param name="input_1"></param>
        /// <param name="input_2"></param>
        /// <returns></returns>
        public static double Square(int input_1, int input_2)
        {
             
            double Sqr = Math.Pow(input_1, input_2);           
      
            return Sqr;
        }
    }
}
