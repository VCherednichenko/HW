using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
        public bool HasDiscountCard { get; private set; }
        public decimal PersonalDiscount { get; private set; }
        public string FullName => $"{FirstName} {LastName}";
        public List<Product> Cart { get; private set; } = new List<Product>();

        public Customer(string firstName, string lastName, int age, char sex, bool hasDiscountCard, decimal personalDiscount = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            HasDiscountCard = hasDiscountCard;
            PersonalDiscount = hasDiscountCard ? personalDiscount : 0;
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

        public void AddToCart(params Product[] products)
        {
            Cart.AddRange(products);
        }

        public string GetCustomerInfo()
        {
            var cartInfo = Cart.Count == 0 ? "EMPTY" : GetCartDetails();
            return $"{FullName} | {Age} | {Sex} | {(HasDiscountCard ? "Yes" : "No")} | {PersonalDiscount:P} | {cartInfo}";
        }

        private string GetCartDetails()
        {
            var groupedProducts = Cart.GroupBy(p => p)
                .Select(g => new
                {
                    Product = g.Key,
                    Amount = g.Count(),
                    TotalSum = g.Key.Price * g.Count()
                })
                .ToList();

            var cartDetails = string.Join("\n  ", groupedProducts.Select(g =>
                $"{g.Product.GetProductInfo()} - {g.Amount}x - ${g.TotalSum:F2}"));

            var total = groupedProducts.Sum(g => g.TotalSum);
            var finalTotal = HasDiscountCard ? total * (1 - PersonalDiscount) : total;

            var discountInfo = HasDiscountCard ? $" - DISCOUNT - {PersonalDiscount:P} - ${finalTotal:F2}" : "";
            return $"{cartDetails}\n  TOTAL = ${total:F2}{discountInfo}";
        }
    }

}
