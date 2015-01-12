using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxIncreasingSequence
{
    class MaxIncreasingSequence
    {
        static void Main()
        {
            string titel = "MaxIncreasingSequence";
            string problem = @"Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} à {2, 3, 4}.";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int[] array = new int[7] { 3, 2, 3, 4, 2, 2, 4 };

            int end = 0;
            int count = 1;
            int MaxCounter = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    if (array[i] < array[i + 1])
                    {
                        count++;
                        if (MaxCounter < count)
                        {
                            MaxCounter = count;
                            end = i + 1;
                            
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = (end + 1) - MaxCounter; i <= end; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();


        }
    }
}
