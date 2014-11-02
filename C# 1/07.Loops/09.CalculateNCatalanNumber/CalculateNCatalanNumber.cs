using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09.CalculateNCatalanNumber
{
    class CalculateNCatalanNumber
    {
        static void Main(string[] args)
        {
            string titel = "CalculateNCatalanNumber";
            string problem = @"In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("Please enter a number");
            int n = int.Parse(Console.ReadLine());
            BigInteger fakt2n = 1;
            BigInteger faktn = 1;
            BigInteger faktn1 = 1;
            BigInteger result = 0;
            if (n < 0)
            {
                Console.WriteLine("Please enter a number >= \"0\"");
                return;
            }
            else
            {
                if (n == 0)
                {
                    Console.WriteLine("The 0 Catalan number is: 0");
                    return;
                }
                for (int i = 1; i <= (2 * n); i++)
                {
                    fakt2n *= i;
                }
                for (int i = 1; i <= (n + 1); i++)
                {
                    faktn1 *= i;
                }
                for (int i = 1; i <= n; i++)
                {
                    faktn *= i;
                }
                result = fakt2n / (faktn1 * faktn);
                Console.WriteLine("The {0} Catalan number is: {1}", n, result);
            }
        }
    }
}
