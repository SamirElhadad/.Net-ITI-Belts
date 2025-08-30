namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car(101 , "BMW" , 25000);
            Car car2 = new Car(102 , "Porch", 30000);
            Car car3 = new Car(103 , "Mercedes-Benz", 25000);

            car1.DisplayInfo();
            car2.DisplayInfo();
            car3.DisplayInfo();

            Console.WriteLine($"Total Car is : {Car.TotalCars}");

        }
    }
}
