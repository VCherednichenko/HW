using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{

    public class Shop
    {
        public List<Customer> Customers { get; private set; } = new List<Customer>();
        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddCustomer(string firstName, string lastName, int age, char sex, bool hasDiscountCard, decimal personalDiscount = 0)
        {
            Customers.Add(new Customer(firstName, lastName, age, sex, hasDiscountCard, personalDiscount));
        }

        public void PrintCustomersInformation()
        {
            Console.WriteLine("Full Name | Age | Sex | Has Discount | Discount | Cart");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var customer in Customers)
            {
                Console.WriteLine(customer.GetCustomerInfo());
            }
        }
    }

}
