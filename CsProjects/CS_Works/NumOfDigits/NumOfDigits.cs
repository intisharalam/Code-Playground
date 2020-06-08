using System;

namespace NumOfDigits
{
    class NumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (num != 0)
            {
                count++;
                num = num / 10;
            }

            Console.WriteLine("Numbers Of Digits: " + count);
        }
    }
}
