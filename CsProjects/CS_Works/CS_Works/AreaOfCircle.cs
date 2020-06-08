using System;

namespace CS_Works
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");

            int radius = Convert.ToInt32(Console.ReadLine());

            double AreaOfCircle = 3.142 * radius * radius;

            Console.WriteLine("Area Of The Circle: " + AreaOfCircle);
        }
    }
}
