using System;


namespace Task_6_7.task_6_7
{
    public abstract class Product
    {
        protected Product(string name, decimal price, int expirationDays = 1)
        {
            Name = name;
            Price = price;
            ExpirationDays = expirationDays;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; protected set; }
        public int ExpirationDays { get; protected set; }
        public DateTime ExpirationDate => DateTime.Today.AddDays(ExpirationDays);

        public override string ToString()
        {
            return $"({Category}) {Name} {Price}, Exp. {ExpirationDate:dd.MM.yy}";
        }
    }

}
