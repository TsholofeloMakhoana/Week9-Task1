using Cal.Logic;
using System;

namespace Cal.ConsoleApp
{
    public class Program
    {

        static void Main(string[] args)
        {

       

            bool continuingUsingCalculator = true;
            int calculatorCount = 0;

            //While to add the history results
            while (continuingUsingCalculator)
            {
                //Calling method that contains the action to be performed
                CalculatorMessage.ConsoleCalculatorMessage();
                                
                Console.Write("Please press any key or enter to continuing or 0 to end the calculation: ");
                
                string answer = Console.ReadLine();
                Console.WriteLine();

                //If the answer is Yes, the loop will ask to perform another calculation
                if (answer != "0")
                {
                    calculatorCount++;
                }
                else
                {
                    //If answer is no, the application will close
                    continuingUsingCalculator = false;
                    Console.WriteLine("Thank you for using my calculator.");
                }
            }

            Console.ReadLine();
        }
    }
}
