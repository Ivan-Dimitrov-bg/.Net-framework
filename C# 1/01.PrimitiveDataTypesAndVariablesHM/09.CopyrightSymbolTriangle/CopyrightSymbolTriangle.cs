using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CopyrightSymbolTriangle
{
    class CopyrightSymbolTriangle
    {
        static void Main()
        {
            string title = "CopyrightSymbolTriangle";
            string problem = @"Write a program that prints an isosceles triangle of 9 3symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.";
            Console.WriteLine(title + "\n" + problem + "\n");

            char copyright = '\u00a9';
            int height = 3;
            int count = 1;
            for (int i = height; i > 0; i--)
            {
                Console.Write(new string(' ', i));
                Console.Write(new String(copyright, count));
                count +=2;
                Console.WriteLine(new string(' ', i));
            }

            //Console.WriteLine(" " + " " + " " + copyright + " " + " ");
            //Console.WriteLine(" " + " " + copyright + copyright + copyright + " ");
            //Console.WriteLine(" " + copyright + copyright + copyright + copyright + copyright);
        }
    }
}
