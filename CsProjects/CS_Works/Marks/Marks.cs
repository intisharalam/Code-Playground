using System;

namespace Marks
{
    class Marks
    {
        static void Main(string[] args)
        {
            int []Marks = new int[5];
            int total = 0, average = 0;

            Console.WriteLine("Enter 5 marks:");

            for (int i = 0; i < Marks.Length; i++)
            {
                int marks = Convert.ToInt32(Console.ReadLine());
                total = total + marks;
            }

            average = total / 5;

            if (average>= 90)
            {
                Console.WriteLine("Grade: A*");
            }
            if (average >= 80)
            {
                Console.WriteLine("Grade: A");
            }
            if (average >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            if (average >= 60)
            {
                Console.WriteLine("Grade: C");
            }
            if (average >= 50)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}