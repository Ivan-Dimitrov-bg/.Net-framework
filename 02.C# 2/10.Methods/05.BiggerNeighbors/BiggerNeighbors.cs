//Write a method that checks if the element at given position in given array
//of integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggerNeighbors
{
    class BiggerNeighbors
    {
        static void Main()
        {
            int[] array = new int[10] { 10, 1, 2, 3, 50, 1, 2, 5, 6, 9 };
            int position = 2;
            bool isBiggest = false;

            if (position == 0)
            {
                if (array[position] > array[position + 1])
                {
                    Console.WriteLine();
                }
            }
            else if (position == array.Length)
	        {
		 
	        }
            else
            {
                isBiggest = ChesckNeighbors(array, position);
            }

        }

        private static bool ChesckNeighbors(int[] array, int position)
        {
            bool isItBigger = false;

            if (array[position] > array[position + 1] & array[position] > array[position - 1])
            {
                isItBigger = true;
            }
            
            return isItBigger;

        }
    }
}
