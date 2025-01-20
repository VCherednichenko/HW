using System;

namespace HW.Task1
{
    internal class Tasks
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSelect a task to run:");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Work Status Evaluator");
                Console.WriteLine("3. Even/Odd Checker");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunCalculator();
                        break;
                    case "2":
                        RunWorkEvaluator();
                        break;
                    case "3":
                        RunEvenOddChecker();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void RunCalculator()
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

        private static void RunWorkEvaluator()
        {
            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            EvaluateUserInput(number);
        }

        private static void EvaluateUserInput(double number)
        {
            bool isWorking = false;
            bool isParty = false;
            if (number < 50 || number != 37 || number != 32)
            {
                Console.WriteLine("Working");
                isWorking = true;
            }

            if (number == 0 || number == 15)
            {
                Console.WriteLine("Party working!");
                isParty = true;
            }

            if (!isWorking && !isParty)
            {
                Console.WriteLine("Does not work");
            }
        }

        private static void RunEvenOddChecker()
        {
            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            CheckEvenOrOdd(number);
        }

        private static void CheckEvenOrOdd(double number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
