using System;
using System.IO;
using System.Collections.Generic;

namespace GroceryStore.Core.Helpers
{
    public static class CollectionHelper
    {
        private static readonly string BasePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\HW\HW\GroseryStore\Resources"));
        private static readonly string CustomersPath = Path.Combine(BasePath, "customers.json");
        private static readonly string ProductsPath = Path.Combine(BasePath, "products.json");

        public static void AddCustomer<T>(this ICollection<T> collection, T item) where T : class
        {
            collection.Add(item);
            var items = JsonHelper.GetData<List<T>>(CustomersPath) ?? new List<T>();
            items.Add(item);
            JsonHelper.SetData(CustomersPath, items);
        }

        public static void AddProduct<T>(this ICollection<T> collection, T item) where T : class
        {
            collection.Add(item);
            var items = JsonHelper.GetData<List<T>>(ProductsPath) ?? new List<T>();
            items.Add(item);
            JsonHelper.SetData(ProductsPath, items);
        }

        public static IEnumerable<T> GetInitialCustomers<T>() where T : class
        {
            return JsonHelper.GetData<List<T>>(CustomersPath) ?? new List<T>();
        }

        public static IEnumerable<T> GetInitialProducts<T>() where T : class
        {
            return JsonHelper.GetData<List<T>>(ProductsPath) ?? new List<T>();
        }
    }
}
