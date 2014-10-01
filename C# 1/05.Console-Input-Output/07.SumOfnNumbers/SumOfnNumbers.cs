using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOfnNumbers
{
    class SumOfnNumbers
    {
        static void Main()
        {
            string titel = "SumOfnNumbers";
            string problem = @"Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. ";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, enter number N");

            int n ;
            bool isInt = int.TryParse(Console.ReadLine(), out n);
            int sum = 0;
            if (isInt)
            {
                Console.WriteLine("Please, enter n numbers");
                for (int i = 0; i < n; i++)
                {
                    int sumNumber;
                    bool isAnumber = int.TryParse(Console.ReadLine(), out sumNumber);
                    if (isAnumber)
	                {
		                 int sumeNumber = int.Parse(Console.ReadLine());
                         sum += sumeNumber;
	                }
                    else
                    {
                        Console.WriteLine("Not a valid entry! Some of the numbers are not double!");
                    }
                }
                Console.WriteLine("The sum is: {0}", sum);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Try again ");
            }
      
            
        }
    }
}
