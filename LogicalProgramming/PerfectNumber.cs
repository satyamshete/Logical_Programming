using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
        public bool Factors(int Number, int potential_factor)
        {
            if (Number % potential_factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public PerfectNumber()
        {
            int check = 0;
            Console.WriteLine("Enter number to check whether it is Perfect or not");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number / 2; i++)
            {
                if (Factors(number, i))
                {
                    check += i;
                }
            }
            if (check == number)
            {
                Console.WriteLine("number is perfect");
            }
            if (check != number)
            {
                Console.WriteLine("addition of all factors is: " + check);
                Console.WriteLine("number isnot perfect");
            }
        }
    }
}
