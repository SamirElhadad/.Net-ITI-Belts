using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class CountChar_Extensions
    {
        public static int CountCharacters(this string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            return text.Length;
        }
    }
}
