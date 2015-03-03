using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ConvertHexToBinary
{
    class ConvertHexToBinary
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                switch (str.Substring(i, 1))
                {
                    case "0": result += "0000"; break;
                    case "1": result += "0001"; break;
                    case "2": result += "0010"; break;
                    case "3": result += "0011"; break;
                    case "4": result += "0100"; break;
                    case "5": result += "0101"; break;
                    case "6": result += "0110"; break;
                    case "7": result += "0111"; break;
                    case "8": result += "1000"; break;
                    case "9": result += "1001"; break;
                    case "a": result += "1010"; break;
                    case "b": result += "1011"; break;
                    case "c": result += "1100"; break;
                    case "d": result += "1101"; break;
                    case "e": result += "1110"; break;
                    case "f": result += "1111"; break;
                    default: result += ""; break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
