using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ASCII
{
    class ASCII
    {
        static void Main(string[] args)
        {
            string title = "ASCII";
            string problem = @"12. Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.";
            Console.WriteLine(title + "\n" + problem + "\n");

            for (int i = 0; i < 255; i++)
            {
                Console.WriteLine((char)i + " ");
            }
            
        }
    }
}
