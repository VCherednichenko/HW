using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Exceptions
{
    public class ExpiredProductException : Exception
    {
        public ExpiredProductException(string customerFullName, IEnumerable<string> productNames, DateTime expiryDate)
            : base($"Customer {customerFullName} is unable to buy the following products {string.Join(", ", productNames)} according to expiry date {expiryDate:d}")
        {
        }
    }
}
