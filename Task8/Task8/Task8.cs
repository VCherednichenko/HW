using System;


namespace Task8.Task8
{
    internal class Task8
    {
        static void Main(string[] args)
        {
            ExceptionsHandling.ShowArrayElement();
        }
    }
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {
        }
    }
    public class ExceptionsHandling
    {
        public static void ShowArrayElement()
        {
            try
            {
                var array = new int[] { 8, 7, 1, 4, 2 };
                Console.WriteLine("Input index of element in array:");
                var inputedValue = Console.ReadLine();

                var elementIndex = inputedValue.Equals(string.Empty) ? null : inputedValue;
                int parsedElementIndex = int.Parse(elementIndex);
                if (parsedElementIndex < 0)
                {
                    throw new NegativeNumberException("Index cannot be negative");
                    
                }

                int elementOfarrayByIndex = array[parsedElementIndex];

                Console.WriteLine($"Array element that has index {inputedValue} has value {elementOfarrayByIndex}");
            } 
            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"erorr msg: {ex.Message}");
                throw;
            }
        }
    }
}
