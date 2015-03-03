//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ConvertDecimalToHexadecimal
{
    class ConvertDecimalToHexadecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            PrintReversed(ConvertDecToHex(input));

        }

        static List<char> ConvertDecToHex(string number)
        {
            int numInt = Int32.Parse(number);
            int index = -1;
            List<char> result = new List<char>();
            while (numInt >= 1)
            {
                result.Add('0');
                int reminder = numInt % 16;
                index++;
                switch (reminder)
                {
                    case 10: result[index] = 'A'; break;
                    case 11: result[index] = 'B'; break;
                    case 12: result[index] = 'C'; break;
                    case 13: result[index] = 'D'; break;
                    case 14: result[index] = 'E'; break;
                    case 15: result[index] = 'F'; break;
                    default: result[index] = (char)(reminder + 48); break;
                }
                numInt = numInt / 16;
            }
            return result;
        }

        static void PrintReversed(List<char> arr)
        {

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                Console.Write((char)(arr[i]));
            }
            Console.WriteLine();
        }
    }
}
