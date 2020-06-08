using System;
using System.Text;

namespace CaeserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            Console.Write("Enter Text:");
            String text = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Enter Key:");
            int s = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    char ch = (char)((int)text[i] + s);
                    if ((int)ch > 90)
                    {
                        ch = (char)((int)ch + 65 - 90 - 1);
                    }
                    result.Append(ch);
                }
                else
                {
                    char ch = (char)((int)text[i] + s);
                    if ((int)ch > 122)
                    {
                        ch = (char)((int)ch + 97 - 122 - 1);
                    }
                    result.Append(ch);
                }
            }

            Console.WriteLine("Text: " + text);
            Console.WriteLine("Ciphered: " + result);
        }
    }
}
