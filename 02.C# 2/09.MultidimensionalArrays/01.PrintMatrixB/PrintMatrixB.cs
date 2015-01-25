using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrixB
{
    class PrintMatrixB
    {
        static void Main(string[] args)
        {
            string titel = "PrintMatrixA";
            string problem = @"Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
A - 1  8  9  16
    2  7  10 15
    3  6  11 14
    4  5  12 13 
";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);


            int[,] matrix = new int[4, 4];
            int count = 1;
            int columns = 4;
            int rows = 4;
            string direction = "down";


            for (int col = 0; col < columns; col++)
            {
                if (direction == "down")
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[col, row] = count;
                        count++;
                    }
                    direction = "up";
                }
                else if (direction == "up")
                {
                    for (int row = rows - 1; row >= 0; row--)
                    {
                        matrix[col, row] = count;
                        count++;
                    }
                    direction = "down";
                }
                               
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(" " + matrix[col, row] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
