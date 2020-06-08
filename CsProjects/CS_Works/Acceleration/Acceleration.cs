using System;

namespace Acceleration
{
    class Acceleration
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Final Velocity:");
            double v = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Initial Velocity:");
            double u = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time Taken:");
            double t = Convert.ToDouble(Console.ReadLine());

            double a = (v - u) / t;

            Console.WriteLine("Acceleration: " + a + "m/s2");
        }
    }
}
