using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Task_7
{
    public abstract class ElectronicDevice
    {
        protected bool isPoweredOn;
        protected string serialNumber;

        public string Brand { get; set; }
        public abstract decimal Price { get; set; }

        protected ElectronicDevice(string serialNumber)
        {
            this.serialNumber = serialNumber;
        }

        public abstract void PowerOn();
        public abstract void PowerOff();

        public string GetDeviceInfo()
        {
            return $"{Brand} - S/N: {serialNumber}";
        }
    }

}
