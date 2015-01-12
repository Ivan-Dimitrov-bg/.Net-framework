using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FiveVeriables
{
    class FiveVeriables
    {
        static void Main(string[] args)
        {
            string title = "FiveVeriables";
            string problem = @"1. Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.";
            Console.WriteLine(title + "\n" + problem + "\n");
            sbyte first = -115;		            
            byte second = 97;
		    short third = -10000;
		    ushort fourth = 52130;
		    int fifth = 4825932;
		    Console.WriteLine("First = " + first);
		    Console.WriteLine("Second = " + second);
		    Console.WriteLine("Third = " + third);
		    Console.WriteLine("Fourth = " + fourth);
		    Console.WriteLine("Fift = " + fifth);
        }
    }
}
