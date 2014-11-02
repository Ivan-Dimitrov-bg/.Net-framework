using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.NandKfactorielSecondExample
{
    class NandKfactorielSecondExample
    {
        static void Main(string[] args)
        {

            string titel = "NandKfactorielSecondExample";
            string problem = @"Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int N, K;
            BigInteger factK = 1;
            BigInteger factN = 1;
            BigInteger result = 1;
            BigInteger factNandK = 1;


            Console.Write("PLease enter N (N > 0) :");
            bool isIntN = int.TryParse(Console.ReadLine(), out N);

            Console.Write("PLease enter K (K > 0) :");
            bool isIntK = int.TryParse(Console.ReadLine(), out K);

            if (true)
            {
                for (int i = 1; i <= K; i++)
                {
                    factK = factK * i;
                }
                for (int i = 1; i <= N; i++)
                {
                    factN = factN * i;
                }
                for (int v = 1; v <= K - N; v++)
                {
                    factNandK = factNandK * v;
                }
                result = (factN * factK) / factNandK;
                Console.WriteLine("N!*K! / (K-N)! = {0}", result);
            }
            else
            {
                Console.WriteLine("Invalide input");
            }
        }
    }
}
