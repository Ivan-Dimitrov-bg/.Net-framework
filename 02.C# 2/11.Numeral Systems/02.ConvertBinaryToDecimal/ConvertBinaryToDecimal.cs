﻿//Write a program to convert binary numbers to their decimal representation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertBinaryToDecimal
{
    class ConvertBinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int decNum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                decNum = decNum << 1;
                
                if (input[i] == '1')
                {
                    decNum = decNum ^ 1;   
                }
            }
            Console.WriteLine(decNum);
        }
    }
}
