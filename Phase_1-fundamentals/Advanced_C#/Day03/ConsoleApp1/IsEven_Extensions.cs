using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class IsEven_Extensions
    {
        public static bool IsEven(this int number) => number % 2 == 0;
    }
}
