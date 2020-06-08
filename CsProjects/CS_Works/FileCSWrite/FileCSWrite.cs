using System;
using System.IO;

namespace FileCSWrite
{
    class FileCSWrite
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("D:\\VS Studio\\CsProjects\\Files\\CsFile.txt");

            Console.WriteLine("Enter the Text that you want to write on File");

            string str = Console.ReadLine();

            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
        }
    }
}
