using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FibonacciFirst100Membars
{
    class FibonacciFirst100Membars
    {
        static void Main()
        {
            string titel = "FibonacciFirst100Membars";
            string problem = @"Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            long prev = 0, 
            now = 1, 
            temp = 0;
            sbyte count = 1;
            Console.WriteLine(temp);
            Console.WriteLine(now);
            while (count <= 100)
            {
                temp = prev;
                prev = now;
                now = temp + prev;
                Console.WriteLine(now);
                count++;
            }
        }
    }
}
