using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrixC
{
    class PrintMatrixC
    {
        static void Main(string[] args)
        {
            string titel = "PrintMatrixA";
            string problem = @"Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
A - 7  11  14  16
    4  8   12  15
    2  5   9   13
    1  3   6   10 
";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);


            int[,] matrix = new int[4, 4];
            int count = 1;
            int columns = 4;
            int rows = 4;
            string direction = "up";
            int row = 3;
            int col = 0;
            bool toLastColumn = false;


            matrix[col, row] = count;
            count++;
            while (count <= 16)
            {

                if (toLastColumn)
                {
                    col++;
                    columns = col;
                    row = 0;
                    matrix[col, row] = count;
                    count++;
                    while (col < 3)
                    {

                        row++;
                        col++;
                        matrix[col, row] = count;
                        count++;
                    }
                    row = 0;
                    col = columns;
                }
                else
                {
                    row--;
                    rows = row;
                    col = 0;
                    matrix[col, row] = count;
                    count++;
                    while (row < 3)
                    {

                        row++;
                        col++;
                        matrix[col, row] = count;
                        count++;
                        if (col == 3)
                        {
                            toLastColumn = true;
                            col = 0;
                            
                        }

                    }
                    row = rows;
                }


            }

            for (row = 0; row < 4; row++)
            {
                for (col = 0; col < 4; col++)
                {
                    Console.Write(" " + matrix[col, row] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}