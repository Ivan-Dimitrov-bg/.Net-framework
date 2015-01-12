using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.NandKfactoriel
{
    class NandKfactoriel
    {
        static void Main()
        {
            string titel = "NandKfactoriel";
            string problem = @"Write a program that calculates N!/K! for given N and K (1<K<N).
";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int N, K;
            BigInteger factk = 1;
            BigInteger factn = 1;
            BigInteger result;

            Console.Write("Please, enter N(N > 1):");
            bool isNInt = int.TryParse(Console.ReadLine(), out N);

            Console.Write("Please, enter K(K > 1):");
            bool isKInt = int.TryParse(Console.ReadLine(), out K);

           if (isNInt && isKInt && (N > K) && (N > 1) && (K > 1))
            {
                for (int i = 1; i <= K; i++)
                {
                    factk = factk * i;
                }

                for (int j = 1; j <= N; j++)
                {
                    factn = factn * j;
                }
                result = factn / factk;
                Console.WriteLine("N!/K!= {0}", result);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
