//Write a program that reads a text file and prints on the console its odd lines.



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintOdsLine
{
    class PrintOdsLine
    {
        static void Main()
        {
            int numberOfRow = 1;
            StreamReader input = new StreamReader("../../test.txt");

            using (input)
            {
                for(string line; (line = input.ReadLine()) != null ; numberOfRow++)
                {
                    if (numberOfRow % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
