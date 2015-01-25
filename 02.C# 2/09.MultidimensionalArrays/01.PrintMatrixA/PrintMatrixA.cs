using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrixA
{
    class PrintMatrixA
    {
        static void Main(string[] args)
        {
            string titel = "PrintMatrixA";
            string problem = @"Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
A - 1  5  9  13
    2  6  10 14
    3  7  11 15
    4  8  12 16 
";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);


            int[,] matrix = new int[4 , 4];
            int count = 1;
            int columns = 4;
            int rows = 4;

            for (int col = 0; col < columns; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[col, row] = count;
                    count++;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(matrix[col, row] + "  ");   
                }
                Console.WriteLine();
            }



        }
    }
}
