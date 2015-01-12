using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBitThree
{
    class TheBitThree
    {
        static void Main(string[] args)
        {
            string title = "TheBitThree";
            string problem = "Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please enter integer number: ");
            int someInt = int.Parse(Console.ReadLine());
            int chackDigit = 3;

            Console.WriteLine(Convert.ToString(someInt, 2).PadLeft(32, '0'));
            Console.WriteLine("&");

            int mask = 1 << chackDigit;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));

            Console.WriteLine("=");
            int result = someInt & mask;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

            result >>= chackDigit;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

            Console.WriteLine("The bit {0} of a the number {1} is {2}", chackDigit, someInt, result);
        }
    }
}
