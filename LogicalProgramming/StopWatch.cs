using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class StopWatch
    {
        public StopWatch()
        {
            Console.WriteLine("press enter to start stopwatch");
            Console.ReadLine();
            DateTime start = DateTime.Now;
            Console.WriteLine("press enter to stop stopwatch");
            Console.ReadLine();
            DateTime stop = DateTime.Now;
            Console.WriteLine("Elasped time in second is  = " + (stop - start).TotalSeconds);
        }
    }
}
