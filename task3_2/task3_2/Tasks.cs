using System;


namespace HW.Task1
{
    internal class Tasks
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an arithmetic operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            PerformArithmeticOperation(firstNumber, secondNumber, operation);
        }

        private static void PerformArithmeticOperation(double firstNumber, double secondNumber, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"Result: {result}");
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"Result: {result}");
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Result: {result}");
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Operation is not present in the list of allowed operations.");
                    break;
            }
        }

    }
}
