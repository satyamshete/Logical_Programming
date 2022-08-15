using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class FibonacciSeries
    {
        public FibonacciSeries()
        {
            Console.WriteLine("Enter Numbers to be print by Fibonacci Series");
            int input = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine("First " + input + " Numbers form Fibonacci Series are");
            for (int i = 1; i <= input; i++)
            {
                if (i == 1)
                {
                    Console.Write(a + " ");
                }
                else if (i == 2)
                {
                    Console.Write(b + " ");
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.Write(c + " ");
                }
            }
        }
    }

}
