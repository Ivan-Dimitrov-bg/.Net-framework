//Write a program to convert hexadecimal numbers to their 
//decimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class convertHexadecimalTodecimal
{
    static void Main()
    {
        string hexString = "17";
        Console.Write("Hexadecimal: {0}", hexString);
        Console.WriteLine();
        //Console.WriteLine((int)'0');
        int totalResult = SumBinary(hexString);
        Console.WriteLine("Decimal: {0}",totalResult);

    }
    static int SumBinary(string hexStr)
    {
        int sum = 0;
        int num = 0;

        //bool numOrLetter = int.TryParse()
        for (int i = hexStr.Length - 1, pow = 0; i >= 0; i--, pow++)
        {

            if (hexStr[i] > 'A')
            {
                num = hexStr[i] - 'A' + 10;
            }
            else
            {
                num = hexStr[i] - '0';
            }

            sum += num * Convert.ToInt32(Math.Pow(16, pow));
        }
        return sum;
    }
}