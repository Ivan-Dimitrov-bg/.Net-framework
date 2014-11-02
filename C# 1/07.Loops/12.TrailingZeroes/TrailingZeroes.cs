using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _12.TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            string titel = "TrailingZeroes";
            string problem = @"1. * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	    1. N = 10 à N! = 3628800 à 2
	    2. N = 20 à N! = 2432902008176640000 à 4
		1. Does your program work for N = 50 000?
		2. Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);
            Console.WriteLine("Please enter a positive number");
            int number = int.Parse(Console.ReadLine());

            BigInteger faktn = 1;
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                faktn *= i;
            }
            for (int i = 0; i <= int.MaxValue; i++)
            {
                if (faktn % 10 == 0)
                {
                    count++;
                    faktn /= 10;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("The number of last trailing zeroes in {0}! is: {1}", number, count);
        }
    }
}
