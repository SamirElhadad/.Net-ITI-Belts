using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Device
    {
        
        public readonly string SerialNumber;

        public Device(string serialNumber)
        {
            SerialNumber = serialNumber;
        }
        public virtual void TurnOn()
        {
            Console.WriteLine($"Device {SerialNumber} is turning on...");
        }
    }
}
