using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Divisible37
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]  {3, -21, 0, 84, 125, -45, 80, -105, 110 };

            var TwentyOne =
                from num in numbers
                where (num % 21 == 0)
                select num;

            int[] Dev21 = numbers.Where(a => a % 21 == 0).ToArray();

            foreach (int num in TwentyOne)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = Dev21.Length - 1; i >= 0; i--)
            {
                Console.Write( Dev21[i] + " ");
            }
        }
    }