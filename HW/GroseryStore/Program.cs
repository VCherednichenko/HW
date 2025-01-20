using GroceryStore.Models;
using System;

namespace HW.Task5
{
    class Program
    {
        static void Main(string[] args) {
      
            var shop = new Shop();

            var john = new Customer(
                firstName: "John",
                lastName: "Doe",
                age: 22,
                sex: 'M',
                hasDiscountCard: true,
                personalDiscount: 0.02m
            );

            var sam = new Customer(
                firstName: "Sam",
                lastName: "Brooks",
                age: 67,
                sex: 'F',
                hasDiscountCard: true,
                personalDiscount: 0.12m
            );

            var cola = new Product(
                name: "Coca-Cola",
                category: 5,
                price: 1.12m,
                expirationDate: DateTime.Now.AddDays(365),
                isAlcohol: false,
                volume: 0.5m
            );

            var chips = new Product(
                name: "Lay's Cheese",
                category: 4,
                price: 2.49m,
                expirationDate: DateTime.Now.AddDays(365),
                isNoFat: false
            );

            var aperol = new Product(
                name: "Aperol",
                category: 5,
                price: 9.99m,
                expirationDate: DateTime.Now.AddDays(365),
                isAlcohol: true,
                volume: 0.75m
            );

            shop.AddCustomer(john);
            shop.AddCustomer(sam);

            john.AddToCart(cola, aperol);
            sam.AddToCart(chips);

            shop.PrintCustomersInformation();
        }
    }
}
