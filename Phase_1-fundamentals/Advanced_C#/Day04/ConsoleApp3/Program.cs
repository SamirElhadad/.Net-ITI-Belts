namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var logger = new FileLogger("log.txt"))
            {
                logger.LogMessage("First log message");
                logger.LogMessage("Second log message");
                logger.LogMessage("Third log message");
            }

            Console.WriteLine("Logs written to file.");
        }
    }
}
