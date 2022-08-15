using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CoupanNumbers
    {
        public CoupanNumbers()
        {
            Console.WriteLine("Enter the toatl no. of coupans");
            int TotalNumbers = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[TotalNumbers];
            int count = TotalNumbers;
            int input;
            int index = 0;
            for (int i = 0; i < TotalNumbers; i++)
            {
                int j = i + 1;
                Console.WriteLine("enter " + j + " Coupan number ");
                input = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    arr[i] = input;
                }
                for (int K = 0; K < i; K++)
                {
                    if (arr[K] != input)
                    {
                        arr[i] = input;
                    }
                    else
                    {
                        Console.WriteLine("You are entering same element twice please enter again");
                        i--;
                        break;
                    }
                }
            }
            var maxNumber = arr.Max();
            var numbersList = arr.ToList();
            while (count > 0)
            {
                index++;
                Random random = new Random();
                int check = random.Next(maxNumber + 1);
                foreach (int i in numbersList)
                {
                    if (i == check)
                    {
                        Console.WriteLine("Hey you got value " + check + " when the random is rolled " + index + " times");
                        count--;
                    }
                }
                numbersList.Remove(check);


            }
            Console.WriteLine("Total random rolled are " + index);
        }
    }
}
