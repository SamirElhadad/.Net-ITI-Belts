namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Phone("P123");
            p.TurnOn();

            Console.WriteLine();

            // SmartPhone
            SmartPhone sp = new SmartPhone("SM9856");
            sp.TurnOn();
            sp.MakeCall();
            sp.TakePhoto();

            Console.WriteLine();

            // Tablet
            Tablet t = new Tablet("T789");
            t.TurnOn();
        }
    }
}
