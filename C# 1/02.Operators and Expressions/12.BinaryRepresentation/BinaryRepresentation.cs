using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BinaryRepresentation
{
    class BinaryRepresentationChangeBitOnPosition
    {
        static void Main(string[] args)
        {
            string title = "OddOrEven";
            string problem = @"We are given integer number n, value v (v=0 or 1) and a position p. 
Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1 à 13 (00001101)
    n = 5 (00000101), p=2, v=0 à 1 (00000001)";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please, enter number n: ");
            int number = int.Parse(Console.ReadLine());
        
            Console.Write("Please, enter position on the bit: ");
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            int maskIf = (mask & number) != 0 ? 1 : 0; //determine the bit in position p

            Console.WriteLine("Before: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            if (maskIf == 0)
            {
                number |= (1 << position);             
            }
            else
            {
                number &= ~(1 << position);
            }
            Console.WriteLine("After3 : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

            
        



        }
    }
}
