

namespace Task_6_7.task_6_7
{
    public static class Shop
    {
        private static Product[] Products = new Product[100];
        private static int productCount = 0;

        public static void AddProduct(Product product)
        {
            if (productCount < Products.Length)
            {
                Products[productCount++] = product;
            }
        }
    }

}
