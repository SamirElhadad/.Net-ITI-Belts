namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment creditCardPayment = new CreditCardPayment
            {
                Amount = 100.00m,
                Currency = "USD",
                CardNumber = "1234-5678-9123-4567"
            };
            Payment processPayment = new PayPalPayment()
            {
                Amount = 100.00m,
                Currency = "USD",
                Email = "samirelhadad28@gmail.com"
            };
            creditCardPayment.ProcessPayment();
            processPayment.ProcessPayment();
        }
    }
}
