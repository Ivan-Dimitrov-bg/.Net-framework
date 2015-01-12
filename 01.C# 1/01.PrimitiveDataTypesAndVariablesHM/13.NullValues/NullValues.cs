using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NullValues
{
    class NullValues
    {
        static void Main()
        {
            string title = "ASCII";
            string problem = @"13. Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.";
            Console.WriteLine(title + "\n" + problem + "\n");
            int? intNull = null;
            double? doubleNull = null;
            Console.WriteLine("intNull= " + intNull);
            Console.WriteLine("doubleNull=  " + doubleNull);
            Console.WriteLine("intNull + 5= " + (intNull + 5));
            Console.WriteLine("doubleNull + 10=  " + (doubleNull + 10));
            Console.WriteLine("intNull + null=" + (intNull + null));
            Console.WriteLine("doubleNull + null=  " + (doubleNull + null));

        }
    }
}
