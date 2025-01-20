

namespace Task_6_7.task_6_7
{
    public class Drink : Product
    {
        public bool IsAlcohol { get; set; }
        public double Volume { get; set; }

        public Drink(string name, decimal price, double volume, bool isAlcohol = false)
            : base(name, price, 30)
        {
            Category = "Drink";
            Volume = volume;
            IsAlcohol = isAlcohol;
        }

        public new string ToString()
        {
            return $"({Category}) {Name} {Price}, Exp. {ExpirationDate:dd.MM.yy}, Vol. - {Volume}, Alcohol - {(IsAlcohol ? "Y" : "N")}";
        }
    }

}
