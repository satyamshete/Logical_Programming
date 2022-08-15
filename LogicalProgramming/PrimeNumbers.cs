using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumbers
    {
        public PrimeNumbers()
        {
            int count = 0;
            Console.WriteLine("Enter the Numbers to check it is Prime Number or not");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < input / 2; i++)
            {
                if (input % i == 0)
                {
                    count++;

                }


            }
            if (count == 1)
            {
                Console.WriteLine("Number " + input + " is prime Number");
            }
            else
            {
                Console.WriteLine("Number " + input + " isnot prime Number");
            }
        }
    }
}
