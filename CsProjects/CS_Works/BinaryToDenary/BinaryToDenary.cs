using System;

namespace BinaryToDenary
{
    class BinaryToDenary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary:");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = num, Base = 1, denary = 0 ;
            while (temp != 0)
            {
                denary = denary + (temp % 10)*Base;
                Base = Base * 2;
                temp = temp / 10;
            }

            Console.WriteLine("Denary: " + denary);
        }
    }
}
