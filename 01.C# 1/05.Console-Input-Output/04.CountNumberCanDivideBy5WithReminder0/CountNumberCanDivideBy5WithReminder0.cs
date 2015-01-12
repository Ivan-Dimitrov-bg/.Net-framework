using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountNumberCanDivideBy5WithReminder0
{
    class CountNumberCanDivideBy5WithReminder0
    {
        static void Main()
        {
            string titel = "CountNumberCanDivideBy5WithReminder0";
            string problem = @"Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int firstNumber, secondNumber;
            Console.Write("Please, enter first int number :");
            bool isAIntFirstNumber = int.TryParse(Console.ReadLine(), out firstNumber );

            Console.Write("Please, enter second int number bigger then first number :");
            bool isAINtSecondNumber = int.TryParse(Console.ReadLine(), out secondNumber);

            int divider = 5;
            int counter = 0;

            if (isAIntFirstNumber & isAINtSecondNumber)
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    if (i % divider == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("answer : {0}", counter);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not int!");
            }       
        }
    }
}
