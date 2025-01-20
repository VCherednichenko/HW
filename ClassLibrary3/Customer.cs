using GroceryStore.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace GroceryStore.Models
{
    public class Customer
    {
        [JsonPropertyName("FirstName")]
        public string FirstName { get;  set; }

        [JsonPropertyName("LastName")]
        public string LastName { get;  set; }

        [JsonPropertyName("Age")]
        public int Age { get;  set; }

        [JsonPropertyName("Sex")]
        public char Sex { get;  set; }

        [JsonPropertyName("HasDiscountCard")]
        public bool HasDiscountCard { get;  set; }

        [JsonPropertyName("PersonalDiscount")]
        public decimal? PersonalDiscount
        {
            get => _personalDiscount ?? decimal.Zero;
            private set => _personalDiscount = value;
        }
        private decimal? _personalDiscount;



        public string FullName => $"{FirstName} {LastName}";
        public List<Product> Cart { get;  set; } = new List<Product>();

        public Customer() { }

        public Customer(string firstName, string lastName, int age, char sex, bool hasDiscountCard, decimal personalDiscount = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            HasDiscountCard = hasDiscountCard;
            PersonalDiscount = hasDiscountCard ? personalDiscount : 0;
        }

        public void AddToCart<T>(params T[] products) where T : Product
        {
            var underAgeProducts = new List<string>();
            var expiredProducts = new List<string>();

            foreach (var product in products)
            {
                if (Age < 18 && product.IsAlcohol)
                {
                    underAgeProducts.Add(product.Name);
                    continue;
                }

                if (product.ExpirationDate <= DateTime.Now)
                {
                    expiredProducts.Add(product.Name);
                    continue;
                }

                Cart.Add(product);
            }

            if (underAgeProducts.Any())
            {
                throw new UnderAgeException(FullName, underAgeProducts);
            }

            if (expiredProducts.Any())
            {
                throw new ExpiredProductException(FullName, expiredProducts, DateTime.Now);
            }
        }


        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void UpdateDiscountCard(bool hasDiscountCard, decimal personalDiscount = 0)
        {
            HasDiscountCard = hasDiscountCard;
            PersonalDiscount = hasDiscountCard ? personalDiscount : 0;
        }

        public string GetCustomerInfo()
        {
            var cartInfo = !Cart.Any() ? "EMPTY" : GetCartDetails();
            return $"{FullName} | {Age} | {Sex} | {(HasDiscountCard ? "Yes" : "No")} | {PersonalDiscount:P} | {cartInfo}";
        }

        private string GetCartDetails()
        {
            var groupedProducts = Cart
                .GroupBy(p => p)
                .Select(g => new
                {
                    Product = g.Key,
                    Amount = g.Count(),
                    TotalSum = g.Key.Price * g.Count()
                });

            var cartDetails = groupedProducts
                .Select(g => $"{g.Product.GetProductInfo()} - {g.Amount}x - ${g.TotalSum:F2}")
                .Aggregate((current, next) => current + "\n  " + next);

            var total = groupedProducts.Sum(g => g.TotalSum);
            var finalTotal = HasDiscountCard ? total * (1 - PersonalDiscount) : total;
            var discountInfo = HasDiscountCard ? $" - DISCOUNT - {PersonalDiscount:P} - ${finalTotal:F2}" : "";

            return $"{cartDetails}\n  TOTAL = ${total:F2}{discountInfo}";
        }
    }
}
