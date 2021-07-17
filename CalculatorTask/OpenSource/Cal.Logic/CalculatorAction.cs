using Cal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cal.Logic
{
    public class CalculatorAction
    {
        public static int PerformAction()
        {
            
            CalculatorModel mo = new CalculatorModel();
            try
            {
                int action = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter first input: ");
                mo.Number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second input: ");
                mo.Number2 = Convert.ToInt32(Console.ReadLine());


                switch (action) //Check which action to perform
                {
                    case 1: //if action is 1 , call the addition functionality
                        {
                            mo.Result = CalculatorEngine.Addition(mo.Number1, mo.Number2);
                            break;
                        }
                    case 2: //if action is 1 , call the Subtraction functionality
                        {
                            mo.Result = CalculatorEngine.Subtraction(mo.Number1, mo.Number2);
                            break;
                        }
                    case 3: //if action is 1 , call the Multiplication functionality
                        {
                            mo.Result = CalculatorEngine.Multiplication(mo.Number1, mo.Number2);
                            break;
                        }
                    case 4: //if action is 1 , call the Division functionality
                        {
                            mo.Result = CalculatorEngine.Division(mo.Number1, mo.Number2);
                            break;
                        }
                    case 5: //if action is 1 , call the Square functionality
                        {
                            double sqr = CalculatorEngine.Square(mo.Number1, mo.Number2);
                            Console.WriteLine("Square of {0} is: {1}", mo.Number1, sqr);
                            mo.Result = Convert.ToInt32(sqr);
                            break;
                        }
                }
                return mo.Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occured: " + ex.Message);
                return 0;
            }
        }   

    }
}
