using System;

namespace ReverseNum
{
    class ReverseNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            while (num != 0)
            {
                reverse = reverse + (num % 10);
                reverse = reverse * 10;
                num = num / 10;
            }

            reverse = reverse / 10;

            Console.WriteLine("Reverse Number: " + reverse);

        }
    }
}
