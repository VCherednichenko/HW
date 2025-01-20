using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Product
    {
        public string Name { get;  set; }
        public int Category { get;  set; }
        public decimal Price { get;  set; }
        public DateTime ExpirationDate { get;  set; }
        public bool IsAlcohol { get;  set; }
        public decimal? Volume { get;  set; }
        public bool? IsNoFat { get;  set; }

        public Product() { }
        public Product(string name, int category, decimal price, DateTime expirationDate, bool isAlcohol, decimal volume)
        {
            Name = name;
            Category = category;
            Price = price;
            ExpirationDate = expirationDate;
            IsAlcohol = isAlcohol;
            Volume = volume;
        }

        public Product(string name, int category, decimal price, DateTime expirationDate, bool isNoFat)
        {
            Name = name;
            Category = category;
            Price = price;
            ExpirationDate = expirationDate;
            IsNoFat = isNoFat;
        }

        public string GetProductInfo()
        {
            var volumeInfo = Volume.HasValue ? $" {Volume}L" : "";
            var fatInfo = IsNoFat.HasValue ? (IsNoFat.Value ? " No Fat" : " Regular") : "";
            var alcoholInfo = IsAlcohol ? " [18+]" : "";

            return $"({Category}) {Name} ${Price:F2}{volumeInfo}{fatInfo}{alcoholInfo} Exp: {ExpirationDate:dd.MM.yy}";
        }
    }

}
