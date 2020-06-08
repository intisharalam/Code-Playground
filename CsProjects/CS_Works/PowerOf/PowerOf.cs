using System;

namespace PowerOf
{
    class PowerOf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Power Of:");
            int indice = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < indice; i++)
            {
                result = result * num;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
