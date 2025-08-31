using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CreditCardPayment : Payment
    {
        public string CardNumber;

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing Credit Card Payment of {Amount} {Currency} using Card Number: {CardNumber}");
        }
    }
}
