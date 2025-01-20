using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace GroceryStore.Constants
{
    public enum ProductCategories
    {
        [Description("Fruits & Vegetables")]
        FruitsAndVegetables = 1,

        [Description("Meat")]
        Meat = 2,

        [Description("Fish")]
        Fish = 3,

        [Description("Snacks")]
        Snacks = 4,

        [Description("Drinks")]
        Drinks = 5
    }
}
