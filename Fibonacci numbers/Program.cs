using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long fib;
            long a = 1;
            long b = 1;
            Console.WriteLine("Press space for next number!");
            for (; ; )
            {
                fib = a + b;
                Console.Write(fib + "   ");
                b = a;
                a = fib;
                Console.ReadKey();
            }
        }
    }
}
