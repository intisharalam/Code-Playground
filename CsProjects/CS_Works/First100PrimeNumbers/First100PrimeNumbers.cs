using System;

namespace First100PrimeNumbers
{
    class First100PrimeNumbers
    {
        static void Main(string[] args)
        {
            int count = 0, num = 0, i = 1, j = 1;
            while (num < 100)
            {
                j = 1;
                count = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                        count++;
                        j++;
                }
                if (count == 2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    num++;
                }
                i++;
            }
        }
    }
}
