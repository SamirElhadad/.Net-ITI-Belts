namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your Dog name: ");
            string dogName = Console.ReadLine();
            Dog myDog = new Dog(dogName);
            myDog.Eat();
            myDog.Bark();           
        }
        
    }
}
