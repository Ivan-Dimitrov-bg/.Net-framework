using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NandXSum
{
    class NandXSum
    {
        static void Main(string[] args)
        {
            string titel = "NandXSum";
            string problem = @"Write a program that, for a given two integer numbers
N and X, calculates the sum S = 1 + 1!/X + 2!/X2 + … + N!/XN";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int N, X;
            decimal sum = 1M;
            decimal fakt = 1M;
            decimal divisor;
       

            Console.Write("Please, enter number N:");
            bool isNint = int.TryParse(Console.ReadLine(), out N);

            Console.Write("Please, enter number X:");
            bool isXint = int.TryParse(Console.ReadLine(), out X);

            for (int i = 1; i <= N; i++)
            {
                fakt *= i;
                divisor = (decimal)Math.Pow(X, i);
                sum += fakt / divisor;

            }
            Console.WriteLine(sum);



        }
    }
}
