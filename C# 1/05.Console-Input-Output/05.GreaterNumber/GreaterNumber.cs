using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            string titel = "GreaterNumber";
            string problem = @"Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.Write("Please, enter first number :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please, enter second bigger then firat number :");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(firstNumber, secondNumber));

        }
    }
}
