//Write a method that returns the index of the first element in array that is bigger than its neighbors,
//or -1, if there’s no such element.
//Use the method from the previous exercise.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggerNeighborsIndex_
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 1, 2, 1, 1, 4, 1, 1, 2, 1 };

            int firstElement = FindFisrtElemBiggerThanItsNeighbors(arr);
            if (firstElement != -1)
            {
                Console.WriteLine("The index of first element wich is bigger then its neighbors is:[{0}]", firstElement);
                Console.WriteLine("The Element is:{0}", arr[firstElement]);
            }
            else
            {
                Console.WriteLine("There is no such element");
            }


        }

        private static int FindFisrtElemBiggerThanItsNeighbors(int[] arr)
        {
            int element = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] + arr[i + 1])
                {
                    element = i;
                }
            }
            return element;
        }
    }
}
