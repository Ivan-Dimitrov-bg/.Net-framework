using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FloatAndDoubleVariables
{
    class FloatAndDoubleVariables
    {
        static void Main()
        {
            string title = "FloatAndDoubleVariables"; 
            string problem = @"02.Which of the following values 
can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?";
            Console.WriteLine("Remember: Double 64 bits , float 32 bit");
            Console.WriteLine(title + "\n" + problem + "\n");

            double first = 34.567839023;
            Console.WriteLine("First = " + first);
            double second = 12.345;
            Console.WriteLine("Second = " + second);
            double third = 8923.1234857;
            Console.WriteLine("Third = " + third);
            float fourth = 3456.091f;
            Console.WriteLine("Fourth = " + fourth);
            
        }
    }
}
