using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Febonnci
{
    class Program
    {
        // febonnaci

        static long Febennaci(int n)
        {
            if (n <= 1)
                return n;
            return Febennaci(n - 1) + Febennaci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numner:- ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Febonnaci number at {num} is {Febennaci(num)}");

        }
    }
}
