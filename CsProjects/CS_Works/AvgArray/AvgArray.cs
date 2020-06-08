using System;

namespace AvgArray
{
    class AvgArray
    {
        static void Main(string[] args)
        {
            int [] array = { 10, 20, 15, 30, 50 };
            int sum = 0, avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            avg = sum / array.Length;
            Console.WriteLine("Average Of Array: "+avg);
        }
    }
}
