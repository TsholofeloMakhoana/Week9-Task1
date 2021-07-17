using System;

namespace Cal.Logic
{
    public class CalculatorMessage
    {
        /// <summary>
        /// The Method to perform calculator functionality
        /// </summary>
        public static void ConsoleCalculatorMessage()
        {
            //List of action to perform
            Console.WriteLine("*************Enter the action to be performed*************");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Square \n");
            Console.WriteLine("**********************************************************");

            //Calling Perform Action methods, which contains the logic for each action
            var result = CalculatorAction.PerformAction();

            //Output the result of the above result
            Console.WriteLine("The result is {0}", result);

            //Add new line for readable results
            Console.WriteLine();
        }
    }
}
