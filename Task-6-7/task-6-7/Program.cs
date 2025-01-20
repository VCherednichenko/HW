using System;


namespace Task_6_7.task_6_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            var annSiemens = new Customer
            {
                Name = "Ann Siemens",
                Products = new Product[]
                {
                    new Drink("Aperol", 9.99m, 0.75, true)
                }
            };

            var samBrooks = new Customer
            {
                Name = "Sam Brooks",
                Products = new Product[]
                {
                    new Meat("Chicken Nuggets", 4.99m)
                }
            };

            Shop.AddProduct(annSiemens.Products[0]);
            Shop.AddProduct(samBrooks.Products[0]);

            PrintCustomersInformation(new[] { annSiemens, samBrooks });

        }

        static void PrintCustomersInformation(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }

    }
}
