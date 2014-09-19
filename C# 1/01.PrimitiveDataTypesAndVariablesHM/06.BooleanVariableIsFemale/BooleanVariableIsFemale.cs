using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BooleanVariableIsFemale
{
    class BooleanVariableIsFemale
    {
        static void Main()
        {
            string title = "BooleanVariable";
            string problem = @"Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender";
            Console.WriteLine(title + "\n" + problem + "\n");

            bool isFemale = false;

            Console.WriteLine("isFemale? {0}", isFemale);
        }
    }
}
