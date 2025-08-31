namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4);
            Vector v2 = new Vector(1, 2);

            Vector sum = v1 + v2;
            Vector sub = v1 - v2;

            Console.WriteLine($"v1 + v2 = {sum}");
            Console.WriteLine($"v1 - v2 = {sub}");

            Console.WriteLine($"v1 == v2 : {v1 == v2}");
            Console.WriteLine($"v1 != v2 : {v1 != v2}");
        }
    }
}
