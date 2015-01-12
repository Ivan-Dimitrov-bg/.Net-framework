using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SubsetOfKSumSArrayN
{
    class SubsetOfKSumSArrayN
    {
        static void Main(string[] args)
        {
            string titel = "SubsetWithSumS";
            string problem = @" Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
Find in the array a subset of K elements that have sum S or indicate about its absence.";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("Enter the wanted sum of the subsets:");
            long wantedSum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of subset elements");
            long length = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size of array:");
            long numberOfElements = long.Parse(Console.ReadLine());
            long[] elements = new long[numberOfElements];
            string subset = "";
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("Enter element № {0}", i + 1);
                elements[i] = long.Parse(Console.ReadLine());
            }
            int maxSubsets = (int)Math.Pow(2, numberOfElements) - 1;

            for (int i = 1; i < maxSubsets; i++)
            {
                subset = "";
                long checkingSum = 0;
                int counter = 0;
                for (int j = 0; j <= numberOfElements; j++)
                {

                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        checkingSum = checkingSum + elements[j];
                        subset = subset + " " + elements[j];
                        counter++;
                    }
                }
                if (checkingSum == wantedSum && counter == length)
                {
                    Console.WriteLine("Number of subest that have the sum of {0}", wantedSum);
                    Console.WriteLine("This subset has a sum of {0} : {1} ", wantedSum, subset);
                }
            }
        }
    }
}