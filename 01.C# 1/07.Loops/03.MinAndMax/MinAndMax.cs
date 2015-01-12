using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinAndMax
{
    class MinAndMax
    {
        static void Main()
        {
            string titel = "MinAndMax";
            string problem = @"Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, enter N number of integer numbers that you want to chack");
            int nNumbers = int.Parse(Console.ReadLine());
            int[] allNumber = new int[nNumbers];
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 1; i <= nNumbers; i++)
            {
                
                Console.Write("Please, enter {0}: ", i);
                allNumber[i - 1] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if ( allNumber[i-1] > max)
                {
                    max = allNumber[i - 1];
                }
                if (allNumber[i-1] < min)
	            {
                    min = allNumber[i - 1];
	            }
            }

            Console.WriteLine("The max number is: {0}", max);

            Console.WriteLine("The min number is: {0}", min);

        }
    }
}
