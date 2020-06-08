using System;

namespace PositiveOrNegative
{
    class PositiveOrNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>0)
            {
                Console.WriteLine("Positive number");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative number");
            }
            else
            {
                Console.WriteLine("Number Is Zero");
            }
        }
    }
}
