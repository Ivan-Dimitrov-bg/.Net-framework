using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexadecimalFormat
{
    class HexadecimalFormat
    {
        static void Main()
        {
            string title = "HexadecimalFormat";
            string problem = @" Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.";
            Console.WriteLine(title + "\n" + problem + "\n");

            int hexaDecimal = 0xFE;
            Console.WriteLine("Hexadecimal Format of 0xFE = {0} in Decimal", hexaDecimal );
        }
    }
}
