using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SequenceMaxSumInArray
{
    class SequenceMaxSumInArray
    {
        static void Main(string[] args)
        {
            string titel = "Selection Sort";
            string problem = @"Write a program that finds the sequence of maximal sum in given array. Example:
                        • {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} à {2, -1, 6, 4}
                        • Can you do it with only one loop (with single scan through the elements of the array)?";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);
            int[] array = new int[10] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };


            int sumBest = 0;
            int sumAtTheMoment = 0;


            int positionStart = 0; // the fyrst element
            int positionStartFinal = 0;
            int positionEnd = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                sumBest += array[i]; // add element on position i to the sum 

                if (array[i] > sumBest) // check if the element on position i is bigger then the sumBest
                {
                    sumBest = array[i];
                    positionStart = i;
                }

                if (sumBest > sumAtTheMoment)
                {
                    sumAtTheMoment = sumBest;
                    positionStartFinal = positionStart;
                    positionEnd = i;
                }
            }

            for (int i = positionStart; i <= positionEnd; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

