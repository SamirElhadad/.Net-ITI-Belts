using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PayPalPayment : Payment
    {

        public string Email;
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing PayPal Payment of {Amount} {Currency} using Email: {Email}");
        }

    }
}
