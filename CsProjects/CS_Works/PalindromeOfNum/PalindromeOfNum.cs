using System;

namespace PalindromeOfNum
{
    class PalindromeOfNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            int checknum = num;

            while (num != 0)
            {
                reverse = reverse + (num % 10);
                reverse = reverse * 10;
                num = num / 10;
            }

            reverse = reverse / 10;

            if (reverse == checknum)
            {
                Console.WriteLine("Its A Palindrome");
            }
            else
            {
                Console.WriteLine("Its NOT A Palindrome");
            }
        }
    }
}
