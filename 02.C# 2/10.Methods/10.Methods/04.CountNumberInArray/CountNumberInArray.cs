//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountNumberInArray
{
    class CountNumberInArray
    {
        static void Main()
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };
            int checkNumber = 9;

            int times = 0;
            times = CheckNumer(array, checkNumber);


            Console.WriteLine("The number {0}, appears {1} times into array", checkNumber, times);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static int CheckNumer(int[] array, int checkNumber)
        {
            int times = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == checkNumber )
                {
                    times++;
                }
            }
            return times;

        }
    }
}
