using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Task10.Task10
{

    public class City
    {
        public int Population { get; set; }
        public double Area { get; set; }

        public override string ToString()
        {
            return $"Population: {Population}, Area: {Area}";
        }
    }

    internal class Task10
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int evenSum = SumEvenNumbers(numbers);
            List<string> words = new List<string>
            {
                "hello", "world", "programming", "code", "sharp",
                "tasks", "water", "phone", "music", "dance"
            };
            Console.WriteLine("\nEnter the length of words to search for:");
            if (int.TryParse(Console.ReadLine(), out int searchLength))
            {
                PrintWordsOfLength(words, searchLength);
            }

            // Task 2 LinkedList
            LinkedList<int> numbersLinkedList = new LinkedList<int>(new[] { 2, 4, 3, 2, 8, 2, 5, 1, 2 });
            int searchItem = 2;
            int insertItem = 10;

            var current = numbersLinkedList.First;
            while (current != null)
            {
                var next = current.Next;
                if (current.Value == searchItem)
                {
                    numbersLinkedList.AddAfter(current, insertItem);
                }
                current = next;
            }

            Console.WriteLine("Modified LinkedList:");
            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }

            // Task 2: Merge lists with common elements
            LinkedList<int> list1 = new LinkedList<int>(new[] { 1, 3, 4, 7, 12 });
            LinkedList<int> list2 = new LinkedList<int>(new[] { 1, 5, 7, 9 });
            var commonElements = list1.Intersect(list2).ToList();

            Console.WriteLine("\n\nCommon elements:");
            foreach (var num in commonElements)
            {
                Console.Write($"{num} ");
            }

            // Task 3: 
            Queue<int> queue = new Queue<int>();

            Console.WriteLine("Enter 6 numbers for the queue:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    queue.Enqueue(number);
                }
            }

            Console.WriteLine($"\nMax value (GetMaxValue): {GetMaxValue(queue)}");
            Console.WriteLine("Queue after GetMaxValue:");
            PrintQueue(queue);

            Console.WriteLine($"\nDeleted max value: {DeleteMaxValue(queue)}");
            Console.WriteLine("Queue after DeleteMaxValue:");
            PrintQueue(queue);

            Console.WriteLine($"\nNew max value (GetMaxValue): {GetMaxValue(queue)}");

            // Stack Task
            Stack<char> letters = new Stack<char>();

            Console.WriteLine("\nEnter three letters:");
            for (int i = 0; i < 3; i++)
            {
                letters.Push(Console.ReadLine()[0]);
            }

            Console.WriteLine("\nLetters in reverse order:");
            while (letters.Count > 0)
            {
                Console.Write(letters.Pop());
            }

            // task 3: dictionary

            // task 31
            Dictionary<string, int> peopleAge = new Dictionary<string, int>();
            peopleAge.Add("John", 25);
            peopleAge["Alice"] = 30;
            Console.WriteLine($"First entry: {peopleAge.First().Key} is {peopleAge.First().Value} years old");

            // task 32
            List<int> numbersList = new List<int> { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            List<string> wordsList = new List<string> { "apple", "zebra", "cat", "dog", "elephant", "fish", "bird", "horse", "iguana", "monkey" };
            var mergedDictionary = MergeSortedLists(numbers, words);

            Console.WriteLine("\nMerged Dictionary:");
            foreach (var item in mergedDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            // task 33
            
            Dictionary<string, City> cities = new Dictionary<string, City>
            {
                {"New York", new City { Population = 8400000, Area = 468.9 }},
                {"London", new City { Population = 9000000, Area = 1572 }},
                {"Tokyo", new City { Population = 37400000, Area = 2194 }},
                {"Paris", new City { Population = 2161000, Area = 105.4 }},
                {"Sydney", new City { Population = 5312000, Area = 1236 }}
            };

            Console.WriteLine("\nCities sorted by area:");
            var sortedByArea = cities.OrderBy(x => x.Value.Area);
            foreach (var city in sortedByArea)
            {
                Console.WriteLine($"{city.Key}: {city.Value}");
            }

            Console.WriteLine("\nCities sorted by population (descending):");
            var sortedByPopulation = cities.OrderByDescending(x => x.Value.Population);
            foreach (var city in sortedByPopulation)
            {
                Console.WriteLine($"{city.Key}: {city.Value}");
            }

            int totalPopulation = cities.Sum(x => x.Value.Population);
            Console.WriteLine($"\nTotal population of all cities: {totalPopulation}");



        }

        static Dictionary<int, string> MergeSortedLists(List<int> numbers, List<string> words)
        {
            numbers.Sort();
            words.Sort();
            words.Reverse();

            return numbers.Zip(words, (n, w) => new { Key = n, Value = w })
                         .ToDictionary(x => x.Key, x => x.Value);
        }

        static int SumEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n%2 == 0).Sum();
        }

        static void PrintWordsOfLength(List<string> words, int length)
        {
            var filteredWords = words.Where(n => n.Length == length);
            foreach (var word in filteredWords)
            {
                Console.WriteLine(word);
            }
        }

        static int GetMaxValue(Queue<int> queue)
        {
            if (queue.Count == 0) throw new InvalidOperationException("Queue is empty");

            Queue<int> tempQueue = new Queue<int>();
            int maxValue = queue.Peek();

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                if (current > maxValue)
                {
                    maxValue = current;
                }
                tempQueue.Enqueue(current);
            }

            while (tempQueue.Count > 0)
            {
                queue.Enqueue(tempQueue.Dequeue());
            }

            return maxValue;
        }


        static int DeleteMaxValue(Queue<int> queue)
        {
            if (queue.Count == 0) throw new InvalidOperationException("Queue is empty");

            Queue<int> tempQueue = new Queue<int>();
            int maxValue = queue.Peek();
            bool maxRemoved = false;

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                if (current > maxValue)
                {
                    maxValue = current;
                }
                tempQueue.Enqueue(current);
            }

            while (tempQueue.Count > 0)
            {
                int current = tempQueue.Dequeue();
                if (current == maxValue && !maxRemoved)
                {
                    maxRemoved = true;
                    continue;
                }
                queue.Enqueue(current);
            }

            return maxValue;
        }

        static void PrintQueue(Queue<int> queue)
        {
            Queue<int> tempQueue = new Queue<int>();
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.Write($"{current} ");
                tempQueue.Enqueue(current);
            }
            while (tempQueue.Count > 0)
            {
                queue.Enqueue(tempQueue.Dequeue());
            }
            Console.WriteLine();
        }
    }
}
