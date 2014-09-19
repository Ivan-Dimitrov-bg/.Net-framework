using System;

namespace _1.FiveVariables
{
    class FiveVariables
    {
        static void Main()
        {
            string title = "FiveVariables";
            string problem = @"1. Declare five variables choosing for each of them the most appropriate of the types 
byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4 825 932, 97, -10000.";
            Console.WriteLine(title + "\n" + problem + "\n");

            sbyte first = -115;
            byte second = 97;
            short third = -10000;
            ushort fourth = 52130;
            int five = 4825932;

            Console.WriteLine("First = {0}. Use sbyte (-128 to 127):signed 8 - bit ", first);
            Console.WriteLine();
            Console.WriteLine("Second = {0}, Use byte (0 to 255): unsigned 8 - bit",second);
            Console.WriteLine();
            Console.WriteLine("Third = {0}, Use short (-32 768 to 32 767):signrd 16 - bit",third);
            Console.WriteLine();
            Console.WriteLine("Fourth = {0}, Use ushort (0 to 65 535) unsigned 16-bit", fourth);
            Console.WriteLine();
            Console.WriteLine("Five = {0}, Use int (-2 147 483 648 to 2 147 483 647)" , five);
            Console.WriteLine();



        }
    }
}
