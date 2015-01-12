using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TheBiggestInt
{
    class TheBiggestInt
    {
        static void Main()
        {
            string title = "TheBiggestInt";
            string problem = "Write a program that finds the biggest of three integers using nested if statements.";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, enter three numbers: ");
            Console.Write("First :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second :");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Third :");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("First Number is bigger");
                }
                else if(thirdNumber > firstNumber)
                {
                    Console.WriteLine("Second Number is bigger");
                }
            }
            else
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("Second Number is bigger");      
                }
                else if (thirdNumber > secondNumber)
                {
                    Console.WriteLine("Third Number is bigger");   
                }
            }





        }
    }
}
