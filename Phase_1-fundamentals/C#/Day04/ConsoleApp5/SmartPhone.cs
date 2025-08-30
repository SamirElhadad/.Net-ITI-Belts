using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class SmartPhone : Phone, ICall, ICamera
    {
        public SmartPhone(string serialNumber) : base(serialNumber)
        {
        }
        public void MakeCall()
        {
            Console.WriteLine("SmartPhone is making a call...");
        }

        public void TakePhoto()
        {
            Console.WriteLine("SmartPhone is taking a photo...");
        }

        public override void TurnOn()
        {
            Console.WriteLine($"SmartPhone {SerialNumber} is turning on...");
        }
    }
   
}
