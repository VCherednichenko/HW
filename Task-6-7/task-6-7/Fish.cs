

namespace Task_6_7.task_6_7
{
    public class Fish : Product
    {
        public enum FishTypes { Sea, Freshwater, Ocean }
        public FishTypes FishType { get; set; }

        public Fish(string name, decimal price, FishTypes fishType)
            : base(name, price, 1)
        {
            Category = "Fish";
            FishType = fishType;
        }

        public new string ToString()
        {
            return $"({Category}) {Name} {Price}, Exp. {ExpirationDate:dd.MM.yy}, {FishType}";
        }
    }

}
