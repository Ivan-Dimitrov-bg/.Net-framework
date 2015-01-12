using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            string titel = "SieveOfEratosthenes";
            string problem = @" Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia)";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            bool[] nоtPrime = new bool[10000000];// all elements in the beginig are false
            for (long i = 2; i < nоtPrime.Length; i++) // loop true masive
            {
                if (nоtPrime[i] == false)// if value of the element is false it will be used to change his derivatives
                {
                    Console.Write("{0} ", i);
                    for (long j = i * i; j < nоtPrime.Length; j = j + i) 
                    {
                        nоtPrime[j] = true;
                    }
                }
            }
        }
    }
}