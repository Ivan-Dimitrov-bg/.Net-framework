using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GCDofTwoNumbers
{
    class GCDofTwoNumbers
    {
        static void Main()
        {
            string titel = "GCDofTwoNumbers";
            string problem = @"Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int firstNumber, secondNumber;
            int length = 0;
            int gcd = 0;
            Console.Write("Please, enter firstNumber(firstNumber > 1):");
            bool isFirstNumberInt = int.TryParse(Console.ReadLine(), out firstNumber);

            Console.Write("Please, enter K(K > 1):");
            bool isSecondNumberInt = int.TryParse(Console.ReadLine(), out secondNumber);

            if (isFirstNumberInt && isSecondNumberInt)
            {
                if (firstNumber > secondNumber)
                {
                    length = firstNumber;
                }
                if (firstNumber < secondNumber)
                {
                    length = secondNumber;
                }

                for (int i = 1; i <= length; i++)
                {
                    if (firstNumber % i == 0 && secondNumber % i == 0)
                    {
                        gcd = i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("The GCD of {0} and {1} is: {2}", firstNumber, secondNumber, gcd);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalide input. Try Again");
            }

        }
    }
}
