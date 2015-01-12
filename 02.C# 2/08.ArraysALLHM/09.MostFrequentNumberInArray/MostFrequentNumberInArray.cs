using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNumberInArray
{
    class MostFrequentNumberInArray
    {
        static void Main(string[] args)
        {
            string titel = "Selection Sort";
            string problem = @"Write a program that finds the most frequent number in an array. Example:
	                            • {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} à 4 (5 times)";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);
            int[] arr = new int[13] {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};

            int mostFrequentElement = 0;
            int element = 0;
            int frequency = 0;
            int currentFrequency = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentFrequency++;

                        element = arr[j];
                    } 
                }
                if (currentFrequency > frequency)
                {

                    frequency = currentFrequency;
                    mostFrequentElement = element;
                }

            }
            Console.WriteLine("The most frequent number is {0} - ({1} times)", mostFrequentElement, frequency);

        }
    }
}
