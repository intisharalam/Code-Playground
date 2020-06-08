using System;

namespace QuadraticFormula
{
    class QuadraticFormula
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Equation!");

            Console.WriteLine("Enter Coefficient a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Coefficient b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Coefficient c:");
            double c = Convert.ToDouble(Console.ReadLine());


            double x1 = ( -b + Math.Sqrt( (b * b) - (4 * a * c) ) )/ (2 * a);
            double x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

            Console.WriteLine("X Factors: " + x1 + " and " + x2);

        }
    }
}
