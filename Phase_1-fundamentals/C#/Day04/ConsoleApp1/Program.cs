namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car0 = new Car(101 , "BMW" , 25000);
            Car car1 = new Car(102 , "Porch", 30000);
            Car car2 = new Car(103 , "Mercedes-Benz", 25000);

            car0.DisplayInfo();
            car1.DisplayInfo();
            car2.DisplayInfo();

            Console.WriteLine($"Total Car is : {Car._TotalCars}");

        }
    }
}
