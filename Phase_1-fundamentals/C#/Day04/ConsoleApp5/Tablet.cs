using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Tablet : Device
    {
        public Tablet(string serialNumber) : base(serialNumber) { }

        public override void TurnOn()
        {
            Console.WriteLine($"Tablet {SerialNumber} is turning on...");
        }
        
    } 
}
