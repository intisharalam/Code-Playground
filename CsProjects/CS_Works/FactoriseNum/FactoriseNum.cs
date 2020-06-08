using System;

namespace FactoriseNum
{
    class FactoriseNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int mod = 0;

            for (int i = 1; i <= num; i++)
            {
                mod = num % i;
                if (mod == 0)
                {
                    Console.Write(i);
                    if (i != num)
                    {
                        Console.Write(" * ");
                    }
                    num = num / i;
                    i = 1;
                }
            }
            
        }
    }
}
