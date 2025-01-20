

namespace Task_6_7.task_6_7
{
    public class Meat : Product
    {
        public Meat(string name, decimal price)
            : base(name, price, 3)
        {
            Category = "Meat";
        }
    }

}
