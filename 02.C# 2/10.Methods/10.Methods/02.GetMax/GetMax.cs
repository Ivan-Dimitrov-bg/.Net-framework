//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them 
//using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetMax
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter three numbers to see the biggest");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The Bigest Number is{0}", GetMax(GetMax(a, b), c));
        }

        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
