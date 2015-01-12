using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSumfromKElementsInArray
{
    class MaxSumfromKElementsInArray
    {
        static void Main(string[] args)
        {
            string titel = "MaxSumfromKElementsInArray";
            string problem = @"Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.Write("Please, enter N the size of matrix:");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Please, enter K - number of elements wich maximal sum the progrma will fine:(K < N ) ");
            int K = int.Parse(Console.ReadLine());


            while (K > N) 
            {
                Console.WriteLine("Try again condition : K < N");
                Console.Write("Please, enter K - number of elements wich maximal sum the progrma will fine:(K < N ) ");
                K = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("PLease, Fill the Array with {0} element", N);
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            long sum = 0;

            
            for (int i = N - 1; i >= N - K; i--)
            {
                sum += array[i];
            }

            Console.WriteLine("The Sum  is {0}", sum);



        }
    }
}
