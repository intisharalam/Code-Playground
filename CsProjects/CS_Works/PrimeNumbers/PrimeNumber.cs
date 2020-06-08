using System;

namespace PrimeNumbers
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int mod = 0, counter = 0;

            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                mod = num % i;
                if (mod == 0)
                {
                    counter++;
                }
            }
            if (counter > 1)
            {
                Console.WriteLine("Not A Prime Number");
            }
            else
            {
                Console.WriteLine("Prime Number");
            }
        }
    }
}
