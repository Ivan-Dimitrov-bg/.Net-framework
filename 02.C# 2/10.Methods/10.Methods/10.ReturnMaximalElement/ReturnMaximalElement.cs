//Write a method that return the maximal element 
//in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in 
//ascending / descending order.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ReturnMaximalElement
{
    class ReturnMaximalElement
    {
        static void Main()
        {
            int[] array = new int[10] { 10, 1, 2, 15, -50, 77, 1, 0, 22, 6 };
            int startIndex = 5;
            int portion = 3;
           
            KeyValuePair<int, int> maxNumberPositionAndValue = new KeyValuePair<int, int>();
            maxNumberPositionAndValue = getMaxNumberIntoPortion(array, startIndex, portion);
            Console.Write("The portion is: ");
            PrintArray(array, startIndex, portion);

            Console.WriteLine("Max number into the portion is:{0}", maxNumberPositionAndValue.Value);
            SortDescending(array);
            PrintArray(array, 0, array.Length);
            SortAscending(array);
            PrintArray(array, 0, array.Length);           
        }
        private static KeyValuePair<int, int> getMaxNumberIntoPortion(int[] array, int startIndex, int portion)
        {
            int maxNumber = int.MinValue;
            int maximalIndex = 0;

            for (int i = startIndex; i < startIndex + portion; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                    maximalIndex = i;
                }
            }

            return new KeyValuePair<int, int>(maximalIndex, maxNumber);
        }


        private static int[] SortDescending(int[] array)
        {
            int maximalElement = int.MinValue;
            KeyValuePair<int, int> maxNumberPositionAndValue = new KeyValuePair<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                maxNumberPositionAndValue = getMaxNumberIntoPortion(array, i, array.Length - i);
                
                maximalElement = maxNumberPositionAndValue.Value;
                int temp = array[i];
                array[i] = maxNumberPositionAndValue.Value;
                array[maxNumberPositionAndValue.Key] = temp; 

                maximalElement = int.MinValue;
            }
            return array;
        }
        private static int[] SortAscending(int[] array )
        {

            int maximalElement = int.MinValue;
            KeyValuePair<int, int> maxNumberPositionAndValue = new KeyValuePair<int, int>();
            for (int i = array.Length; i > 0; i--)
            {
                maxNumberPositionAndValue = getMaxNumberIntoPortion(array, 0 , i);
                
                maximalElement = maxNumberPositionAndValue.Value;
                int temp = array[i - 1 ];
                array[i - 1] = maxNumberPositionAndValue.Value;
                array[maxNumberPositionAndValue.Key] = temp;

                maximalElement = int.MinValue;
            }
            return array;
          
        }
        private static void PrintArray(int[] array, int star, int len)
        {
            for (int i = star; i < len; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
