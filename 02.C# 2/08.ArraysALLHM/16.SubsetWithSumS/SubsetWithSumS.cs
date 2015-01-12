using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main()
        {
            string titel = "SubsetWithSumS";
            string problem = @" We are given an array of integers and a number S. 
Write a program to find if there exists a subset of the elements of the array that has a sum S. 
Example:	1. arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 à yes (1+2+5+6).";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            List<int> list = new List<int> { 2, 1, 2, 4, 3, 5, 2, 6 };
            int sum = 14;


            FindExactSubset(list, sum);
        }

        static void FindExactSubset(List<int> arr, int sum)
        {
            int count = (int)Math.Pow(2, arr.Count);
            int currentSum = 0;
            bool foundSubset = false;
            StringBuilder str = new StringBuilder();

            for (int i = 1; i <= count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if ((i >> j & 1) == 1)
                    {
                        if (currentSum == 0)
                        {
                            str.Append(arr[j]);
                        }
                        else
                        {
                            str.Append("+").Append(arr[j]);
                        }
                        currentSum += arr[j];
                    }
                }
                if (currentSum == sum)
                {
                    Console.WriteLine("Yes({0})", str);
                    foundSubset = true;
                    //break;
                }
                else
                {
                    currentSum = 0;
                    str.Clear();
                }
            }
            if (foundSubset == false)
            {
                Console.WriteLine("Subset with this sum does not exist");
            }
        }
    }
}