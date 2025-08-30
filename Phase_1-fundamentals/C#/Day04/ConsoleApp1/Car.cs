using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public static int TotalCars;
        public readonly int ChassisNumber;
        public string Model { get; set; }
        public double Price { get; set; }

        public Car(int chassisNumber, string model, double price)
        {
            ChassisNumber = chassisNumber;
            Model = model;
            Price = price;
            TotalCars++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Chassis Number: {ChassisNumber}, Model: {Model}, Price: {Price}");
        }
    }
}
