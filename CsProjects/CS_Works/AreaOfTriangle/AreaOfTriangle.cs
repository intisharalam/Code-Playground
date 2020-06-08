using System;

namespace AreaOfTriangle
{
    class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base:");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            int Height = Convert.ToInt32(Console.ReadLine());

            double AreaOfTriangle = 0.5 * Base * Height;

            Console.WriteLine("Area Of Triangle: " + AreaOfTriangle);
        }
    }
}
