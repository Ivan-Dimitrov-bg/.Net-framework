//Write a program to convert decimal numbers to their binary representat


using System;
using System.Collections.Generic;

namespace _01.ConvertDecimalToBinary
{
    class ConvertDecimalToBinary
    {
        static void Main()
        {
            Console.Write("Please, enter some int number: ");
            int number = int.Parse(Console.ReadLine());
            List<int> binaryRepresentation = new List<int>();
            binaryRepresentation = ConvertDecToBinary(number);
            PrintBinaryRepresentation(binaryRepresentation);

        }

        private static void PrintBinaryRepresentation(List<int> binaryRepresentation)
        {
            for (int i = binaryRepresentation.Count - 1; i >= 0; i--)
            {
                Console.Write("{0}", binaryRepresentation[i]);
            }
            Console.WriteLine();
        }

        private static List<int> ConvertDecToBinary(int number)
        {
            List<int> binaryRepresentation = new List<int>();
            while (number > 0)
            { 
                binaryRepresentation.Add(number % 2);
                number /= 2;
            }
            

            return binaryRepresentation;
        }
    }
}
