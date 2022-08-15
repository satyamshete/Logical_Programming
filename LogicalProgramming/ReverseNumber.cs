using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public ReverseNumber()
        {
            Console.WriteLine("Enter number to be reversed");
            int number = Convert.ToInt32(Console.ReadLine());
            int RevNum = 0;
            string digit = Convert.ToString(number);
            for (int i = digit.Length - 1; i >= 0; i--)
            {
                RevNum += (number % 10) * (int)Math.Pow(10, i);
                number = number / 10;

            }
            Console.WriteLine(RevNum);
        }
    }
}
