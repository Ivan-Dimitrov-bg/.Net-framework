using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindGivenSumInArray
{
    class FindGivenSumInArray
    {
        static void Main(string[] args)
        {

            string titel = "FindGiven Sum In Array";
            string problem = @"Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 à {4, 2, 5}";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int[] arr = new int[7] { 4, 3, 1, 4, 2, 5, 8 };
            int S = 11;

            int currentSum = 0;
            int timer = 0;
            int lastelementPocition = 1;
            

            for (int i = 0; i <arr.Length; i++)
            {
                currentSum += arr[i];
                if (currentSum == S)
                {
                    Console.WriteLine("{" + arr[i] + "}");
                }
                for (int j = i + 1 ; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    timer++;
                    if (currentSum == S)
                    {

                        for (int z = j - timer; z <= j; z++)
                        {
                            Console.WriteLine(arr[z]);
                        }
                        break;
                    }
                    else if (currentSum > S)
                    {
                        break;
                    }

                }
                currentSum = 0;
                timer = 0;
   
            }



        }
    }
}
