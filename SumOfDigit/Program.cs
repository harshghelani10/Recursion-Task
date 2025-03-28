using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigit
{
    class Program
    {
        static long SumOfDigit(int n)
        {
            if (n == 0) 
            return 0;
            return (n % 10) + SumOfDigit(n / 10);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number:-");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of digit of {num} is {SumOfDigit(Math.Abs(num))}");

        }
    }
}
