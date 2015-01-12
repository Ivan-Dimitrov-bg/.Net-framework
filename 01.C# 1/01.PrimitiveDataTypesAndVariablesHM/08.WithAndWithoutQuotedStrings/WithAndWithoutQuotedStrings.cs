using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.WithAndWithoutQuotedStrings
{
    class WithAndWithoutQuotedStrings
    {
        static void Main(string[] args)
        {
            string title = "WithAndWithoutQuotedStrings";
            string problem = @"8.Declare two string variables and assign them with following value:
			""The ""use"" of quotations causes difficulties.""
                		Do the above in two different ways: with and without using quoted strings.";
            Console.WriteLine(title + "\n" + problem + "\n");

            string WithQuotedString = @"The ""use"" of quotations causes difficulties.(With Quoted String)";
            string WithoutQuotedStrings = "The \"use\" of quotations causes difficulties.(Without Quoted Strings)";

            Console.WriteLine(WithQuotedString);
            Console.WriteLine(WithoutQuotedStrings);

        }
    }
}
