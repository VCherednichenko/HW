using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Product
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public string GetProductInfo()
        {
            return $"({Category}) {Name} ${Price:F2}";
        }
    }

}
