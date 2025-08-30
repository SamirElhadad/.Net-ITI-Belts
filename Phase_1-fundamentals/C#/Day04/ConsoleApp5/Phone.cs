using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Phone : Device
    {
        public Phone(string serialNumber) : base(serialNumber)
        {
        }
        public override void TurnOn()
        {
            Console.WriteLine($"Phone {SerialNumber} is booting up...");
        }
    }
    
}
