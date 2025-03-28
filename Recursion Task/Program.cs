using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Task
{
    class Program
    {
        //factorial
        static long Factorial(int n)
        { 
            if(n<=1) 
                return 1;
            return n*Factorial(n-1);
        }
        
              
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numner:- ");
            int  num = int.Parse(Console.ReadLine());
                        
                Console.WriteLine($"Factorial of {num} is {Factorial(num)} \n");  
            

        }
    }
}
