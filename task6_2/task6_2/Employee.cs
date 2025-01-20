using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.task6_1
{
    public abstract class Employee : Person
    {
        public bool IsEmployeeOfMonth { get; set; }

        public virtual void Quit()
        {
        }
    }

}
