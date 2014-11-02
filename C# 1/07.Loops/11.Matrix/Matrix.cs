using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            string titel = "GCDofTwoNumbers";
            string problem = @"1. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
	1. N = 3 N = 4";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("Please enter a number for matrix");
            int number = int.Parse(Console.ReadLine());
            int n = 1;
            if (number <= 0)
            {
                Console.WriteLine("Please enter a number bigger than Zero");
                return;
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    n = i + 1;
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write(" {0} ", n);
                        n += 1;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
