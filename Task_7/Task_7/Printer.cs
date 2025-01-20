using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Task_7
{
    public class Printer : ElectronicDevice, IPrintable, IConnectable
    {
        private decimal price;
        private bool isConnected;

        public int PaperCount { get; set; }
        public bool IsConnected => isConnected;
        public override decimal Price
        {
            get => price;
            set => price = value;
        }

        public Printer(string serialNumber) : base(serialNumber) { }

        public override void PowerOn()
        {
            isPoweredOn = true;
            Console.WriteLine("Printer is warming up...");
        }

        public override void PowerOff()
        {
            isPoweredOn = false;
            Console.WriteLine("Printer is shutting down...");
        }

        public void Print(string content)
        {
            if (!isPoweredOn)
            {
                Console.WriteLine("Printer is off. Please turn it on first.");
                return;
            }

            if (PaperCount <= 0)
            {
                Console.WriteLine("No paper loaded!");
                return;
            }

            Console.WriteLine($"Printing: {content}");
            PaperCount--;
        }

        public void LoadPaper(int count)
        {
            PaperCount += count;
            Console.WriteLine($"Loaded {count} sheets. Total: {PaperCount}");
        }

        public void Connect()
        {
            isConnected = true;
            Console.WriteLine("Printer connected to network");
        }

        public void Disconnect()
        {
            isConnected = false;
            Console.WriteLine("Printer disconnected from network");
        }
    }

}
