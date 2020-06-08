using System;

namespace SumOfNumbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fourth Number:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fifth Number:");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int Sum = num1 + num2 + num3 + num4 + num5;

            Console.WriteLine("Sum: " + Sum);

        }
    }
}
