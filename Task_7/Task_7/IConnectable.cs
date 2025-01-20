using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Task_7
{
    public interface IConnectable
    {
        bool IsConnected { get; }
        void Connect();
        void Disconnect();
    }

}
