using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Reverse_String
    {
        public static string ReverseText(this string text)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;
            return new string(text.Reverse().ToArray());
        }
    }
}
