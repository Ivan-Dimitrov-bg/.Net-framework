using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractTheValueOfaGivenBit
{
    class ExtractTheValueOfaGivenBit
    {
        static void Main(string[] args)
        {
            string title = "ExtractTheValueOfaGivenBit";
            string problem = "Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 à value=1.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please enter some int: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Please enter number of bits: ");
            int bit = int.Parse(Console.ReadLine());
            int mask = 1 << bit;
            int result = number & mask;
            result >>= bit;
            Console.WriteLine("The bit is : {0}", result);
            
        }
    }
}
