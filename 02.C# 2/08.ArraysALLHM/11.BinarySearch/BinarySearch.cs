using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            string titel = "BinarySearch";
            string problem = @"Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int[] arr = new int[8] { 2, 4, 6, 7, 8, 10, 12, 16 };
            int surchElement = 10;
            int lowElementPosition = 0;
            int highElementPosition = arr.Length;
        
            int mid;
            while (lowElementPosition < highElementPosition)
            {
                mid = (lowElementPosition / 2 + highElementPosition / 2);// very important 
                if (arr[mid] == surchElement)
                {
                    Console.WriteLine("The position is: {0}", mid);
                    break;
                }
                else if (arr[mid] < surchElement)//the element we search is located to the right from the mid point
                {
                    lowElementPosition = mid-1;
                    continue;
                }
                else if (arr[mid] > surchElement)//the element we search is located to the left from the mid point
                {
                    highElementPosition = mid-1;
                    continue;
                }

                //at this point low and high bound are equal and we have found the element or
                //arr[mid] is just equal to the value => we have found the searched element

            }
           
        }
    }
}
