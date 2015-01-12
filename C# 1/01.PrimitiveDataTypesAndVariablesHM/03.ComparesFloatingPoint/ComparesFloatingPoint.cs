using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComparesFloatingPoint
{
    class ComparesFloatingPoint
    {
        static void Main()
        {
            string title = "ComparesFloatingPoint";
            string problem = @"Write a program that safely compares floating-point numbers with precision of 0.000001.
Examples:
(5.3 ; 6.01) à false;  (5.00000001 ; 5.00000003) à true";
            Console.WriteLine(title + "\n" + problem + "\n");
            float f1 = 5.3f;
            float f2 = 6.01f;
            bool isEqualF1toF2 = (f1 == f2);

            float f3 = 5.00000001f;
            float f4 = 5.00000003f;

            bool isEqualF3toF4 = (f3 == f4);

            Console.WriteLine("5.3 == 6.01 " + isEqualF1toF2);
            Console.WriteLine("5.00000001 ==  5.00000003 " + isEqualF3toF4);

        }
    }
}
