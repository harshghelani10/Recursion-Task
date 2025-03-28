using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Calculate
{
    class Program
    {
        static long Power(int x, int y)
        {
            if (y == 0) 
                return 1;
            return x * Power(x, y - 1); 
        }
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} raised to the power of {y} is {Power(x, y)}");

        }
    }
}
