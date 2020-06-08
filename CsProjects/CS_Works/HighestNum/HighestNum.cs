using System;

namespace HighestNum
{
    class HighestNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number 1 Is The Greatest");
                }
                else
                {
                    Console.WriteLine("Number 3 Is The Greatest");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number 2 Is The Greatest");
            }
            else
            {
                Console.WriteLine("Number 3 Is The Greatest");
            }
        }
    }
}
