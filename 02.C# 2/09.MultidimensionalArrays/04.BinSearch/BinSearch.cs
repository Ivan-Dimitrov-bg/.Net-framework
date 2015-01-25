using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinSearch
{
    class BinSearch
    {
        static void Main(string[] args)
        {
            string titel = "BinSearch";
            string problem = @"Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.
BinSearch() finds the largest number in the array which is ≤ K.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            //int[] arr = new int[10] { 1, 5, 2, 6, 4, 1, 10, 1, 50, 1 };

            //int K = 10;

            Console.WriteLine("Please enter a size of the array:");
            int K = int.Parse(Console.ReadLine());
            int[] arr = new int[K];

            Console.WriteLine("Please enter {0} numbers", K);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //find index of value in the array
            int index = Array.BinarySearch(arr, K);


            //if value is found print exact index
            if (arr[index] == K)
            {
                Console.WriteLine("Into array there is a number that is equal to {0}", K);
                Console.WriteLine("index is {0} ", index);
            }
            //Array.BinSearch returns minus index of next closest element in array
            //if value is not found get minus index and substract index to get previous closest element
            else
            {
                Console.WriteLine(-index - 1);
            }


        }
    }
}
