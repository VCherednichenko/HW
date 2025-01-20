
using System.Linq;


namespace Task_6_7.task_6_7
{
    public class Customer
    {
        public string Name { get; set; }
        public Product[] Products { get; set; }

        public override string ToString()
        {
            return $"Customer: {Name}, Products: {string.Join(", ", Products.Select(p => p.ToString()))}";
        }
    }

}
