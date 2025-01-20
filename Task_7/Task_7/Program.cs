using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Task_7
{
    class Program
    {
        static void Main()
        {
            Printer printer = new Printer("PRN-2023-001")
            {
                Brand = "Epson",
                Price = 299.99m
            };

            printer.PowerOn();
            printer.LoadPaper(100);
            printer.Connect();

            if (printer.IsConnected && printer.PaperCount > 0)
            {
                printer.Print("Test Document");
            }

            Console.WriteLine($"Device Info: {printer.GetDeviceInfo()}");
            Console.WriteLine($"Paper remaining: {printer.PaperCount}");

            printer.PowerOff();
        }
    }

}
