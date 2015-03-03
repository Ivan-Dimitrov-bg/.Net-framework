//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number
//represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Factorial
{
    static void Main()
    {

        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = CalculateFactorial(n);

        PrintFactorial(arr);
    }

    private static int[] CalculateFactorial(int n)
    {
        int[] arr = { 1 };

        for (int multiplier = 1; multiplier <= n; multiplier++)
        {
            //create list= (array arr)*multiplier

            List<int> multi = new List<int>();
            int adder = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                multi.Add((arr[i] * multiplier + adder) % 10);
                adder = (arr[i] * multiplier + adder) / 10;
            }

            while (adder > 0)
            {
                multi.Add(adder % 10);
                adder = adder / 10;

            }
            arr = multi.ToArray();
            multi.Clear();
        }
        return arr;
    }
    private static void PrintFactorial(int[] arr)
    {
        bool check = false;
        for (int k = arr.Length - 1; k >= 0; k--)
        {
            if (arr[k] != 0)
            {
                Console.Write(arr[k]);
                check = true;
            }
            else if (check == true) Console.Write(arr[k]);
        }
        Console.WriteLine();
    }
}
