using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ReturnsBitOnGivenPosition
{
    class ReturnsBitOnGivenPosition
    {
        static void Main(string[] args)
        {
            string title = "OddOrEven";
            string problem = @"Write a boolean expression that returns if the bit at position p 
                (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 à false.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please enter some int: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Please enter number of bit: ");
            int bit = int.Parse(Console.ReadLine());
            int mask = 1 << bit;
            int result = number & mask;
            result >>= bit;
            Console.WriteLine(result == 1 ? "True" : "False");

        }
    }
}
