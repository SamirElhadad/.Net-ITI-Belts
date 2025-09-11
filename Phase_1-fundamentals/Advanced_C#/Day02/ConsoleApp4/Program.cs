namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , string> country = new Dictionary<string , string>()
            {
                {"EG" , "Egypt" },
                {"KSA" , "Saudi Arabia" },
                {"USA" , "United States" },
                {"UK" , "United Kingdom" },
                {"UAE" , "United Arab Emirates" }
            };

            Console.Write($"Enter Code : ");
            string code = Console.ReadLine().ToUpper();

            if (country.ContainsKey(code))
            {
                Console.WriteLine($"Country Name Is : {country[code]}");
            }
            else
            {
                Console.WriteLine("Code Not Found");
            }
        }
    }
}
