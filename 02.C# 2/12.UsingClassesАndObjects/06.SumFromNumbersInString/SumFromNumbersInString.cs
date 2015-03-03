//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. Example:
//string = "43 68 9 23 318"  result = 461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumFromNumbersInString
{
    class SumFromNumbersInString
    {
        static void Main()
        {
            string inputNumbers = "43 68 9 23 318";
            inputNumbers = inputNumbers.Trim(); // remove the space in begining or in the end
            int sum = 0;
            string[] strNums = inputNumbers.Split(' '); // separate the string use ' ';
            for (int i = 0; i < strNums.Length; i++)
            {
                sum = sum + int.Parse(strNums[i].Trim());
            }
            Console.WriteLine(sum);
            
        }
    }
}
