using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year:");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year % 4 == 0)
            {
                Console.WriteLine("Its A Leap Year");
            }
            else
            {
                Console.WriteLine("Not A Leap Year");
            }
        }
    }
}
