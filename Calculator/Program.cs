using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Calculator\r");
            Console.WriteLine("--------------------\n");

            while (!endApp)
            {
                string valueInput1 = "";
                string valueInput2 = "";
                double result = 0;

                Console.Write("Type a value, and then press Enter: ");
                valueInput1 = Console.ReadLine();

                double cleanValue1 = 0;
                while (!double.TryParse(valueInput1, out cleanValue1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    valueInput1 = Console.ReadLine();

                }
                Console.Write("Type another value, and then press Enter: ");
                valueInput2 = Console.ReadLine();

                double cleanValue2 = 0;
                while (!double.TryParse(valueInput2, out cleanValue2))
                {
                    Console.Write("This is not a valid input. Please enter an integer value: ");
                    valueInput2 = Console.ReadLine();

                }

                Console.WriteLine("Choose an operator from the following list: ");
                Console.WriteLine("\tA - Add");
                Console.WriteLine("\tS - Subtract");
                Console.WriteLine("\tM - Multiply");
                Console.WriteLine("\tD - divide");
                Console.WriteLine("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanValue1, cleanValue2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");

                    }
                    else Console.WriteLine("your result: {0:0.##}\n", result);

                }
                catch (Exception E)
                {
                    Console.WriteLine("Oops! There is an exception occurred trying to do the math.\n - Details: " + E.Message);

                }
                Console.WriteLine("-------------------------------\n");
                Console.WriteLine("Press 'v' and Enter to close the app, or press any other key and Enter to continue:");
                if (Console.ReadLine() == "v") endApp = true;

                Console.WriteLine("\n");

            }
            return;
        }
    }
}
