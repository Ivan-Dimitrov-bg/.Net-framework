using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrixD
{
    class PrintMatrixD
    {
        static void Main(string[] args)
        {
            string titel = "PrintMatrixA";
            string problem = @"Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
A - 1  12  11   10
    2  13  16   9
    3  14  15   8
    4  5  6   7 
";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);


            int[,] matrix = new int[4, 4];
            int count = 1;
            int columns = 4;
            int rows = 4;
            string direction = "down";
            int row = 0;
            int col = 0;

            matrix[col, row] = count;
            count++;
            while (count <= 16)
            {

                if (direction == "down")
                {
                    while (row < 3 && matrix[col, row + 1] < 1)
                    {
                        row++;
                        matrix[col, row] = count;
                        count++;
                    }
                    direction = "right";

                }
                else if (direction == "right" )
	            {
                    while (col < 3 && matrix[col + 1, row] < 1)
                    {
                        col++;
                        matrix[col, row] = count;
                        count++;
                    }
                    direction = "up";
		               
	            }
                else if (direction == "up")
	            {
                    while (row > 0 && matrix[col, row - 1] < 1)
                    {
                        row--;
                        matrix[col, row] = count;
                        count++;
                    }
                    direction = "left";
		               
	            }
                 else if (direction == "left")
	            {
                    while (col > 0 && matrix[col - 1, row] < 1)
                    {
                        col--;
                        matrix[col, row] = count;
                        count++;
                    }
                    direction = "down";
		               
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
