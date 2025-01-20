using System;


namespace Task9.Task9
{
    public class Task9
    {
        static void Main(string[] args)
        {
            GenericArray<string> stringArray = new GenericArray<string>();
            stringArray.Add("Hello");
            stringArray.Add("World");

            GenericArray<int> intArray = new GenericArray<int>();
            intArray.Add(42);
            intArray.Add(100);

            Console.WriteLine(stringArray.GetElement(0)); 
            Console.WriteLine(intArray.Count());
        }
    }


    public class GenericArray<T>
    {
        private T[] items;
        private int count;

        public GenericArray(int capacity = 4)
        {
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    return true;
                }
            }
            return false;
        }

        public T GetElement(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return items[index];
        }

        public int Count()
        {
            return count;
        }
    }


}
