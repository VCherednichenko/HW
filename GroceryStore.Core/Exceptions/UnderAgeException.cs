using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Exceptions
{
    public class UnderAgeException : Exception
    {
        public UnderAgeException(string customerFullName, IEnumerable<string> productNames)
            : base($"Customer {customerFullName} is unable to buy the following products: {string.Join(", ", productNames)} according to age restrictions")
        {
        }
    }
}
