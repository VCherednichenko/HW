

namespace Task_6_7.task_6_7
{
    public class FruitsAndVegetables : Product
    {
        public double Weight { get; set; }

        public FruitsAndVegetables(string name, decimal price, double weight)
            : base(name, price, 4)
        {
            Category = "FruitsAndVegetables";
            Weight = weight;
        }

        public new string ToString()
        {
            return $"({Category}) {Name} {Price}, Exp. {ExpirationDate:dd.MM.yy}, {Weight}kg";
        }
    }

}
