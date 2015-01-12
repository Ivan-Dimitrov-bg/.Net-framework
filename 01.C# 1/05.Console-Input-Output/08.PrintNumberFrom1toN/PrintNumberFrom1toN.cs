using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrintNumberFrom1toN
{
    class PrintNumberFrom1toN
    {
        static void Main()
        {
            string titel = "PrintNumberFrom1toN";
            string problem = @"Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int number;
            bool isANumber = int.TryParse(Console.ReadLine(), out number);

            if (isANumber)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid entrance");
            }
        }
    }
}
