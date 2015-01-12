using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ExchagesBits345
{
    class ExchagesBits345
    {
        static void Main(string[] args)
        {
            string title = "OddOrEven";
            string problem = @"Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit
            unsigned integer.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please, enter number from 0 to 4294967295 number = ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("That is mean: {0}", Convert.ToString(number, 2));

            int startBit = 3;
            int endBit = 5; 
            int exchangeStart = 21;

            for (int firstPosition = startBit; firstPosition <= endBit; firstPosition++) // bits at position 3, 4, 5
            {
                int exchangePosition = firstPosition + exchangeStart;  // bits at position 24, 25, 26

                uint mask1 = (uint)(1 << firstPosition); // define mask for the position 
                uint mask2 = (uint)(1 << exchangePosition);// define mask for the position 
                uint bit1 = (number & mask1); //chacking which bits stay of this positions 0 or 1
                uint bit2 = (number & mask2); //chacking which bits stay of this positions 0 or 1

                // bit on firstPosition goes to bit of exchangePosition 
                if (bit1 == 0)
                {
                    uint replacer = (uint)(1 << exchangePosition); // exchangePosition have bit = 1 
                    number = (number & ~replacer); // set bit 1 on exchangePosition ;
                    
                }
                else
                {
                    uint replacer = (uint)(1 << exchangePosition);
                    number = (number | replacer);
                }

                //bit on exchangePosition goes to firstPosition 

                if (bit2 == 0)
                {
                    uint replacer = (uint)(1 << firstPosition);
                    number = (number & ~replacer);
                }
                else
                {
                    uint replacer = (uint)(1 << firstPosition);
                    number = (number | replacer);
                }
            }
            Console.WriteLine("Binary representation of modifed number is: \n{0}", Convert.ToString(number, 2));
            Console.WriteLine("The uint number  after bit changes (3, 4, 5 <=> 24, 25, 26) is: \n{0}", number);


        }
    }
}
