using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_Sort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            string titel = "Selection Sort";            
            string problem = @"Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the (selection sort) algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int[] arr = new int[6] { 42, 4, 5, 6, 10, 2 };

            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int tmp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = tmp;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }
    //    public static void SelectionSort(int[] arr)
    //    {
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            int minIndex = i;
    //            for (int j = i + 1; j < arr.Length; j++)
    //            {
    //                if (arr[j] < arr[minIndex])
    //                {
    //                    minIndex = j;
    //                }
    //            }
    //            int tmp = arr[i];
    //            arr[i] = arr[minIndex];
    //            arr[minIndex] = tmp;
    //        }

    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item + " ");
    //        }
    //    }
    }
}


