using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.task6_1
{

    public class Client : Person
    {
        public bool IsVip { get; set; }

        public bool CanTakeLoan()
        {
            return true;
        }
    }



}
