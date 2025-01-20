using System;
using System.Collections.Generic;
using System.Linq;
using GroceryStore.Core.Helpers;

namespace GroceryStore.Models
{
    public class Shop
    {
        private HashSet<Customer> _customers;
        private HashSet<Product> _products;

        public Shop()
        {
            _customers = new HashSet<Customer>(CollectionHelper.GetInitialCustomers<Customer>());
            _products = new HashSet<Product>(CollectionHelper.GetInitialProducts<Product>());
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void UpdateCustomer(Customer updatedCustomer)
        {
            var existingCustomer = GetCustomer(updatedCustomer.FullName);
            if (existingCustomer != null)
            {
                _customers.Remove(existingCustomer);
                _customers.Add(updatedCustomer);
            }
        }

        public Customer GetCustomer(string fullName)
        {
            return _customers.FirstOrDefault(c => c.FullName == fullName);
        }

        public void PrintCustomersInformation()
        {
            Console.WriteLine("Full Name | Age | Sex | Has Discount | Discount | Cart");
            Console.WriteLine("-----------------------------------------------------");
            _customers.OrderBy(c => c.LastName)
                     .ThenBy(c => c.FirstName)
                     .Select(c => c.GetCustomerInfo())
                     .ToList()
                     .ForEach(Console.WriteLine);
        }
    }
}
