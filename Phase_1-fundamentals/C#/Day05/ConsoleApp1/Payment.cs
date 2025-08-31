using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Payment
    {
        public decimal Amount;
        public string Currency;

        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount} {Currency}");
        }
    }
}
