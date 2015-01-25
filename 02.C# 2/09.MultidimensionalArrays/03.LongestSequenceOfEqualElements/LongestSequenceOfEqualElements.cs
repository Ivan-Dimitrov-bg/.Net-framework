using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LongestSequenceOfEqualElements
{
    class LongestSequenceOfEqualElements
    {
        static void Main()
        {
            string titel = "LongestSequenceOfEqualElements";
            string problem = @"We are given a matrix of strings of size N x M. 
Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
Write a program that finds the longest sequence of equal strings in the matrix. Example:";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            Console.WriteLine("Please enter size of the matrix:");
            Console.Write("Rows: (N > 3): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Cols: (M > 3): ");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the matrix with some strings");
            //Example : 

            string[,] matrix = new string[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int y = 0; y < M; y++)
                {
                    matrix[i, y] = Console.ReadLine();
                }
            }

            int sequenceCounter = 0;
            int theBestSequence = 0;
            string direction = "right";
            int row = 0;
            int col = 0;
            int currentRow = 0;
            int currentCol = 0;
            string currentValue = "";
            string value = "";
            

            for (row = 0; row < N; row++)
            {
                currentRow = row;
                currentCol = col;
                for (col = 0; col < M; col++)
                {
                    value = matrix[row, col];
                    if (direction == "right")
                    {
                        currentValue = matrix[row + 1, col];
                        if (value == currentValue)
                        {
                            sequenceCounter++;
                            if (theBestSequence < sequenceCounter )
                            {
                                theBestSequence = sequenceCounter;
                            }
                        }
                    }   
                    
                }
            }

        }
    }
}
