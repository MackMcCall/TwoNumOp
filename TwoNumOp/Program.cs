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
                Console.WriteLine("Invalid Input");
                return GetNumber();
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

        static bool TryGetOperation(string input, out OperationTypes? type)
        {
            type = null;
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            switch (input)
            {
                case ("add" or "addition" or "+"):
                    type = OperationTypes.Add;
                    return true;
                case ("subtract" or "subtraction" or "-"):
                    type = OperationTypes.Subtract;
                    return true;
                case ("multiply" or "multiplication" or "*" or "x"):
                    type = OperationTypes.Multiply;
                    return true;
                case ("divide" or "division" or "/"):
                    type = OperationTypes.Divide;
                    return true;
                default: return false;
            }
            //TODO figure this out more and try to incorporate it
        }
    }
}

