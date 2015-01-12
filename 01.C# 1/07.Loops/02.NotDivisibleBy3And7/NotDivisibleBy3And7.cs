using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NotDivisibleBy3And7
{
    class NotDivisibleBy3And7
    {
        static void Main()
        {
            string titel = "NotDivisibleBy3And7";
            string problem = @"Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.Write("PLease, enter number N: ");
            int N = 0;
            bool isInt = int.TryParse(Console.ReadLine(), out N);

            if (isInt)
            {
                for (int i = 0; i < N; i++)
                {
                    if ((i % 7 != 0) && (i % 3 != 0))
                    {
                        Console.WriteLine("the number {0} is not divisible by 3 and 7", i);
                    }   
                }   
                  
            }
            else
            {
                Console.WriteLine("Invalide input, try again");
            }
        }
    }
}
