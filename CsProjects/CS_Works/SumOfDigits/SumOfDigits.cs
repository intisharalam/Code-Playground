using System;

namespace SumOfDigits
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int remainder = 0;

            while (num != 0)
            {
                remainder = remainder + (num % 10);
                num = num / 10;
            }

            Console.WriteLine("Sum Of Digits: " + remainder);

        }
    }
}
