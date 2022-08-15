namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logical Programming
            Console.WriteLine("Logical Programming");
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("2. Perfect Number");
            Console.WriteLine("3 Prime Number");
            Console.WriteLine("4 Reverse a number");
            Console.WriteLine("5. Coupan Numbers");
            Console.WriteLine("6. Simulate Stopwatch Program");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    break;
                
                case 3:
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    break;
                case 5:
                    CoupanNumbers coupanNumbers = new CoupanNumbers();
                    break;
                case 6:
                    StopWatch stopWatch = new StopWatch();
                    break;
                default:
                    Console.WriteLine("Give proper selection");
                    break;

            }
        }
    }
}