using System;


namespace HW.Task2
{
    internal class Tasks
    {
        public static void Main(string[] args)
        {
            ExecuteTask1();
            ExecuteTask2();
            ExecuteTask3();
            ExecuteTask4();
        }

        public static void ExecuteTask1()
        {
            var number = 20 + 5;
            Console.Write($"Enter number: {number}");
        }

        public static void ExecuteTask2()
        {
            Console.WriteLine("Enter a number of days: ");
            string input = Console.ReadLine();
            int days = int.Parse(input);

            int years = days / 365;
            int remainingDays = days % 365;
            int months = remainingDays / 30;
            int remainingDaysAfterMonths = remainingDays % 30;

            Console.WriteLine($"{days} days are equivalent to:");
            Console.WriteLine($"{years} years");
            Console.WriteLine($"{months} months");
            Console.WriteLine($"{remainingDaysAfterMonths} days");
        }

        public static void ExecuteTask3()
        {
            Console.WriteLine("Write number ");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int result = n + n * 2;
            Console.WriteLine($"result {n}");
        }

        public static void ExecuteTask4()
        {
            int integer1 = -34;
            int integer2 = 4;
            string text1 = " Hello ";
            char text2 = 'R';
            double decimalNumber = 23.093433222;
            long largeInteger = 40000;
            bool booleanValue = true;
            float smallDecimal = 0;
        }
    }


}
