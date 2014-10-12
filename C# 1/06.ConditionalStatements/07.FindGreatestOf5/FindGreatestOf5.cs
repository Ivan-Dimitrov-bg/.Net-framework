using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FindGreatestOf5
{
    class FindGreatestOf5
    {
        static void Main()
        {
            string title = "FindGreatestOf5";
            string problem = @"Write a program that finds the greatest of given 5 variables.";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, enter 5 veriables to see the greatest of them");
            int biggestNumber = 0;
            int[] array = new int[5];
            for (int i = 1; i <= array.Length; i++)
            {
                Console.Write("number {0} :", i);
                
                array[i - 1] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestNumber)
                {
                    biggestNumber = i;
                }
            }
            Console.WriteLine("The biggest number is {0}", biggestNumber);
        }
    }
}
