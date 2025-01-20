

namespace Task_6_7.task_6_7
{
    public class Snacks : Product
    {
        public bool IsNoFat { get; set; }

        public Snacks(string name, decimal price, bool isNoFat = false)
            : base(name, price, 90)
        {
            Category = "Snacks";
            IsNoFat = isNoFat;
        }

        public new string ToString()
        {
            return $"({Category}) {Name} {Price}, Exp. {ExpirationDate:dd.MM.yy}, Fat - {!IsNoFat}";
        }
    }

}
