using System;
using System.IO;

namespace FileCSAmend
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter myWriter = new StreamWriter("D:\\VS Studio\\CsProjects\\Files\\Error.txt");
            StreamReader myReader = new StreamReader("D:\\VS Studio\\CsProjects\\Files\\City.txt");

            string theLine = "";
            int count = 0;

            while (myReader.Peek() >= 0)
            {
                theLine = myReader.ReadLine();
                count++;
                theLine = Convert.ToString(count) + " " + theLine;

                Console.WriteLine(theLine);
                myWriter.WriteLine(theLine);
            }

            myWriter.Close();
            myReader.Close();
        }
    }
}
