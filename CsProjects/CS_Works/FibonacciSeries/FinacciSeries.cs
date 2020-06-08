using System;

namespace FibonacciSeries
{
    class FinacciSeries
    {
        static void Main(string[] args)
        {
            int fnum = 0, snum = 1;

            Console.WriteLine("Fibonacci Series");
            Console.Write("0");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(snum + " ");
                int next = fnum + snum;
                fnum = snum;
                snum = next;

            }
        }
    }
}
