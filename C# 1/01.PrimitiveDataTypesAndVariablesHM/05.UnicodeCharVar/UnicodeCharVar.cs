using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UnicodeCharVar
{
    class UnicodeCharVar
    {
        static void Main(string[] args)
        {
            string title = "UnicodeCharVar";
            string problem = @"Declare a character variable and assign it with the symbol that has Unicode code 72.
Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
";
            Console.WriteLine(title + "\n" + problem + "\n");

            int charVar = 72;
            Console.WriteLine("The code of '{0}' is: {1}",charVar, (char)charVar);


        }
    }
}
