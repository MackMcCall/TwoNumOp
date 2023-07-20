namespace TwoNumOp
{
    using System;
    internal class Program
    {
        static double GetNumber()
        {
            Console.WriteLine("Enter a number: ");
            if (double.TryParse(Console.ReadLine(), out var number))
            {
                return number;
            }
            else
            {
                return 0;
            }
        }


        private static void Main(string[] args)
        {
            Console.WriteLine("What is the first number you would like to use?");
            double num1 = GetNumber();

            Console.WriteLine("What is the second number you would like to use?");
            double num2 = GetNumber();

            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            string operation = (Console.ReadLine());

            switch (operation)
            {
                case ("add" or "addition" or "+"):
                    Console.WriteLine(num1 + num2);
                    break;
                case ("subtract" or "subtraction" or "-"):
                    Console.WriteLine(num1 - num2);
                    break;
                case ("multiply" or "multiplication" or "*" or "x"):
                    Console.WriteLine(num1 * num2);
                    break;
                case ("divide" or "division" or "/"):
                    Console.WriteLine(num1 / num2);
                    break;
            }
        }
    }
}

