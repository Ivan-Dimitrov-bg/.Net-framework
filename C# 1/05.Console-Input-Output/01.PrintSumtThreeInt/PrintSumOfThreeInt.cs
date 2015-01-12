using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintSumOfThreeInt
{
    class PrintSumOfThreeInt
    {
        static void Main(string[] args)
        {
            string titel = "PrintSumofThreeInt";
            string problem = @"Write a program that reads 3 integer numbers from the console and prints their sum.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("PLease. enter three integer numbers");
            int a, b, c;
            Console.Write("a = ");
            bool isANumberA = int.TryParse(Console.ReadLine(), out a);

            Console.Write("b = ");
            bool isANumberB = int.TryParse(Console.ReadLine(), out b);
            
            Console.Write("c = ");
            bool isANumberC = int.TryParse(Console.ReadLine(), out c);

            if (isANumberA & isANumberB & isANumberC)
            {
                int sum = a + b + c;
                Console.WriteLine("{0} + {1} + {2}  = {3}", a, b, c, sum);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not int!");
            }
           

            


        }
    }
}
