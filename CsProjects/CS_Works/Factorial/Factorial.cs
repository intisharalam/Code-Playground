using System;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = num;

            for (int i = 1; i < num; i++)
            {
                sum = sum * (num - i);
            }

            Console.WriteLine("Factorial is: " + sum);
        }
    }
}
