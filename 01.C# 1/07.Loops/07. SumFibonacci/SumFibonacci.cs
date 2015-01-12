using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.SumFibonacci
{
    class SumFibonacci
    {
        static void Main(string[] args)
        {

            string titel = "SumFibonacci";
            string problem = @"Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
1. Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int N;
            Console.Write("Please enter N (N > 0):");
            bool isNint = int.TryParse(Console.ReadLine(), out N);
            BigInteger[] arr = new BigInteger[N + 1];
            arr[0] = 1;
            arr[1] = 1;
            if (isNint && N > 0)
            {
                for (int i = 2; i < N; i++)
                {
                    arr[i] = arr[i - 2] + arr[i - 1];
                }
            }
            else
            {
                Console.WriteLine("Invalide input");
            }
            Console.WriteLine("The {0} Fibonacci member is: {1}", N, arr[N - 1]);
        }
    }
}
