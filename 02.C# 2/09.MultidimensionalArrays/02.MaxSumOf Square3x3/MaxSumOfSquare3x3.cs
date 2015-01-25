using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxSumOf_Square3x3
{
    class MaxSumOfSquare3x3
    {
        static void Main(string[] args)
        {
            string titel = "02.MaxSumOfSquare3x3";
            string problem = @"Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("Please enter size of the matrix:");

            Console.Write("Colomns: (N > 3): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Rows: (M > 3): ");
            int M = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];

            for (int i = 0; i < M; i++)
            {
                for (int y = 0; y < N; y++)
                {
                    matrix[i, y] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            int maxSum = 0;
            int currentRow = 0;
            int currentCol = 0;
            int condition = 3;

            int positionOntheElementBottomRightCol = 0;
            int positionOntheElementBottomRightRow = 0;

            while (currentCol + condition <= N)
            {
                while (currentRow + condition <= M)
                {
                    for (int i = currentRow; i < currentRow + condition; i++)
                    {
                        for (int y = currentCol; y < currentCol+ condition; y++)
                        {
                            sum = sum + matrix[i, y];
                            if (maxSum < sum)
                            {
                                maxSum = sum;
                                positionOntheElementBottomRightCol = i;
                                positionOntheElementBottomRightRow = y;

                            }
                        }
                    }
                    currentRow++;
                    sum = 0; 
                }
                currentCol++;
                currentRow = 0;
                sum = 0;
            }

            for (int i = (positionOntheElementBottomRightRow - condition + 1  ); i <= positionOntheElementBottomRightRow; i++)
            {
                for (int y = (positionOntheElementBottomRightCol - condition + 1); y <= positionOntheElementBottomRightCol; y++)
                {
                    Console.Write(" " + matrix[i,y] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Max Sum :" + maxSum);

        }
    }
}
