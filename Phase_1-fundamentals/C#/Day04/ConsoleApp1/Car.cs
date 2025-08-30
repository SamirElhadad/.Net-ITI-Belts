using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public static int _TotalCars;
        public readonly int _ChassisNumber;
        public string Model { get; set; }
        public double Price { get; set; }

        public Car(int chassisNumber, string model, double price)
        {
            _ChassisNumber = chassisNumber;
            Model = model;
            Price = price;
            _TotalCars++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Chassis Number: {_ChassisNumber}, Model: {Model}, Price: {Price}");
        }
    }
}
