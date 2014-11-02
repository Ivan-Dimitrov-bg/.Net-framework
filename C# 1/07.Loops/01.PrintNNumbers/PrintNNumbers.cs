using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintNNumbers
{
    class PrintNNumbers
    {
        static void Main()
        {
            string titel = "PrintNNumbers";
            string problem = @"Write a program that prints all the numbers from 1 to N.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.Write("PLease, enter number N: ");
            int N = 0;
            bool isInt = int.TryParse(Console.ReadLine(), out N);

            if (isInt)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalide input. Try Again");
            }
           
        }
    }
}
