using System;
using System.IO;

namespace FileCS
{
    class FileCSCreate
    {
        static void Main(string[] args)
        {
            File.Create("D:\\VS Studio\\CsProjects\\Files\\CsFile.txt");
            if (File.Exists("D:\\VS Studio\\CsProjects\\Files\\CsFile.txt"))
            {
                Console.WriteLine("File Created");
            }
            else
            {
                Console.WriteLine("File Already Exixsted");
            }
        }
    }
}
