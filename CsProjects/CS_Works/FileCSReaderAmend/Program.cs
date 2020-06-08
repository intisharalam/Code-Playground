using System;
using System.IO;

namespace FileCSReaderAmend
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("D:\\VS Studio\\CsProjects\\Files\\CsFile.txt");
            string str = sr.ReadLine();

            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();

            // to close the stream 
            sr.Close();
        }
    }
}
