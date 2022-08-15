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
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    break;
                default:
                case 3:
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    break;
                    Console.WriteLine("Give proper selection");
                    break;

            }
        }
    }
}