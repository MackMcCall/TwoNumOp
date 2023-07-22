namespace TwoNumOp
{
    using System;
    public class Program
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
                Console.WriteLine("Invalid Input, Please Type a Number.");
                return GetNumber();
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("What is the first number you would like to use?");
            double num1 = GetNumber();

            Console.WriteLine("What is the second number you would like to use?");
            double num2 = GetNumber();

            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            var operation = Console.ReadLine();

            var isvalidinput = TryGetOperation(operation, out var operationType);

            switch (operationType)
            {
                case OperationTypes.Add:
                    Console.WriteLine(num1 + num2);
                    break;
                case OperationTypes.Subtract:
                    Console.WriteLine(num1 - num2);
                    break;
                case OperationTypes.Multiply:
                    Console.WriteLine(num1 * num2);
                    break;
                case OperationTypes.Divide:
                    Console.WriteLine(num1 / num2);
                    break;
            }
        }


        /// <summary>
        /// Refactor that evaluates input and returns true if input is a valid operation type and puts out that type, puts out null type when input is invalid.
        /// </summary>
        public static bool TryGetOperation(string? input, out OperationTypes? type)
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
            //TODO implement exponents, more test cases, maybe look into "zero", regex
        }
    }
}

