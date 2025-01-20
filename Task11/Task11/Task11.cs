using System;
using System.Collections.Generic;
using System.Linq;


namespace Task11.Task11
{
    internal class Task11
    {
        static void Main(string[] args)
        {

            PrintEvenNumbers();
            FindPositiveNumbersInRange();
            DisplayNumbersAndSquares();
            DisplayNumberFrequency();
            FindCitiesWithPattern('A', 'M');
            DisplayTopRecords(3);
            DisplaySortedCities();
            DisplayDistinctSortedItems();
        }

        static void PrintEvenNumbers()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.Write("The numbers which produce the remainder 0 after divided by 2 are: ");
            Console.WriteLine(string.Join(" ", evenNumbers));
        }

        static void FindPositiveNumbersInRange()
        {
            List<int> numbers = new List<int> { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var result = from num in numbers
                         where num > 0
                         where num <= 11
                         select num;

            Console.Write("The positive numbers within the range of 1 to 11 are: ");
            Console.WriteLine(string.Join(" ", result));
        }

        static void DisplayNumbersAndSquares()
        {
            int[] numbers = new int[] { 9, 8, 6, 5 };

            var result = from num in numbers
                         select new
                         {
                             Number = num,
                             SqrNo = num * num
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"{{ Number = {item.Number}, SqrNo = {item.SqrNo} }}");
            }
        }

        static void DisplayNumberFrequency()
        {
            int[] numbers = new int[] { 5, 9, 5, 9, 5, 1 };

            var result = from num in numbers
                         group num by num into freq
                         select new
                         {
                             Number = freq.Key,
                             Frequency = freq.Count()
                         };

            Console.WriteLine("The number and the Frequency are :");

            var formattedOutput = from item in result
                                  select $"Number {item.Number} appears {item.Frequency} time{(item.Frequency > 1 ? "s" : "")}";

            Console.WriteLine(string.Join("\n", formattedOutput));
        }
        static void FindCitiesWithPattern(char startChar, char endChar)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                           "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var result = from city in cities
                         where city.StartsWith(startChar.ToString()) &&
                               city.EndsWith(endChar.ToString())
                         select city;

            Console.WriteLine($"The city starting with {startChar} and ending with {endChar} is : {string.Join(", ", result)}");
        }

        static void DisplayTopRecords(int n)
        {
            int[] numbers = { 5, 7, 13, 24, 6, 9, 8, 7 };

            var result = (from num in numbers
                          orderby num descending
                          select num).Take(n);

            Console.WriteLine($"The top {n} records from the list are : {string.Join(", ", result)}");
        }

        static void DisplaySortedCities()
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                           "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var result = from city in cities
                         orderby city.Length, city
                         select city;

            Console.WriteLine("Here is the arranged list :");
            Console.WriteLine(string.Join("\n", result));
        }
        static void DisplayDistinctSortedItems()
        {
            string[] items = { "Biscuit", "Brade", "Butter", "Honey", "Biscuit", "Butter" };

            var result = from item in items.Distinct()
                         orderby item
                         select item;

            Console.WriteLine("The distinct sorted items are:");
            Console.WriteLine(string.Join("\n", result));
        }

    }

    
}
