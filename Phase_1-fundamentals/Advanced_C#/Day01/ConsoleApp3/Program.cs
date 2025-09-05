namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] data = { 42, "100" , "20" , "Hello", "World!", 3.14, true };

            int sumNumbers = 0;
            int SumParsed = 0;

            foreach (var item in data)
            {
                if (item is int number)
                {
                    Console.WriteLine($"Integer found: {number}");
                    sumNumbers += number;
                }
                else if (item is string str)
                {
                    Console.WriteLine($"String found: {str}");

                    if (int.TryParse(str, out int parsed))
                    {
                        Console.WriteLine($"Parsed to int: {parsed}");
                        SumParsed += parsed;
                    }
                }
                else
                {
                    dynamic dyn = item; 
                    Console.WriteLine($"Other type found: {dyn}");
                }
            }   

            Console.WriteLine("\n=== Results ===");
            Console.WriteLine($"Sum of integers: {sumNumbers}");
            Console.WriteLine($"Sum of parsed strings: {SumParsed}");
            Console.WriteLine($"Grand Total: {sumNumbers + SumParsed}");
        }
    }
}
