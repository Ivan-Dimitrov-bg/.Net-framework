using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxSequence
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            string titel = "MaxSequence";
            string problem = @"Write a program that finds the maximal sequence of equal elements in an array.Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} à {2, 2, 2}.";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int[] array = new int[10] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1};

            int end = 0; 
            int count = 1;
            int MaxCounter = 1;
            int commentElements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    if (array[i] == array[i + 1])
                    {
                        count++;
                        if (MaxCounter < count)
	                    {
		                    MaxCounter = count;
                            end = i;
                            commentElements = array[i];
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
            for (int i = 0; i < MaxCounter; i++)
            {
                Console.Write("{0}, ", commentElements);
            }
        }
    }
}
