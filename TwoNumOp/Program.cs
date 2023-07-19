namespace TwoNumOp
{
    using System;
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is the first number you would like to use?");
            // float num1 = Convert.ToInt32(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out var num1))
{
                Console.WriteLine($"You entered: {num1}");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }

            Console.WriteLine("What is the second number you would like to use?");
            float num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which you like to add, subtract, multiply, or divide?");
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

