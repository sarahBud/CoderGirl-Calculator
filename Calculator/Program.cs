using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            
            Console.Write("Enter a number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            

            Console.Write("Enter another number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            

            Console.Write("Do you want to add, subtract, multiply or divide?: ");
            string selection = Console.ReadLine();

            int result = (firstNumber - secondNumber);

            if (selection == "add")
            {
                result = (firstNumber + secondNumber);
            }

            if (selection == "subract")
            {
                result = (firstNumber - secondNumber);
            }

            if (selection == "multiply")
            {
                result = (firstNumber * secondNumber);

            }

            if (selection == "divide")
            {
                result = (firstNumber / secondNumber);
            }


            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
