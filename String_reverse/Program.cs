using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_reverse
{
    class Program
    {
        static string ReverseString(string str)
        {
            if (str.Length == 0)
                return str;

            return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Reversed string: {ReverseString(input)}");
        }
    }
}