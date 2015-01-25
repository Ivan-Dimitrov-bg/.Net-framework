using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortArrayofStringsByLength
{
    class SortArrayofStringsByLength
    {
        static void Main(string[] args)
        {
            string titel = "LongestSequenceOfEqualElements";
            string problem = @"We are given a matrix of strings of size N x M. 
Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
Write a program that finds the longest sequence of equal strings in the matrix. Example:";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            string[,] matrix = 
            {
            {"ha", "fifi", "ho", "hi","hi","hi"},
			{"ha", "ha","hi", "ho", "ho", "fifi"},
			{"ha", "fifi", "ha","fifi", "fifi", "ho"},
			{"ha", "fifi", "ha","fifi", "fifi", "ho"},
            };
            //solution
            int horisontal = 1;
            int vertical = 1;
            int diagonalR = 1;
            int diagonalL = 1;

            int horisontalMax = 1;
            int verticalMax = 1;
            int diagonalRMax = 1;
            int diagonalLMax = 1;

            string elementH = "";
            string elementV = "";
            string elementDR = "";
            string elementDL = "";

            int row = 0;

            // check Horizontals
            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] )
                    {
                        horisontal++;
                        if (horisontal >= horisontalMax)
                        {
                            elementH = matrix[row, col];
                            horisontalMax = horisontal;
                        }
                    }
                    else
                    {
                        horisontal = 1;
                    }
                }
            }
            //check Verticals
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        vertical++;
                        if (vertical >= verticalMax)
                        {
                            elementV = matrix[row, col];
                            verticalMax = vertical;
                        }
                    }
                    else
                    {
                        vertical = 1;
                    }
                }
            }

            // check DiagonalRight
            for (int i = 0; i <= matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int col = j;
                    row = i;
                    if (col >= matrix.GetLength(1) - 1 || row >= matrix.GetLength(0) - 1 )
                    {
                        break;
                    }
                    else
                    {
                        while (col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1) //Move to Diagonal
                        {
                            if (matrix[row, col] == matrix[row + 1, col + 1])// if fine some element that are equal continue move
                            {
                                diagonalR++;
                                if (diagonalR >= diagonalRMax)
                                {
                                    elementDR = matrix[row, col];
                                    diagonalRMax = diagonalR;
                                }
                                row++;
                                col++;
                            }
                            else // if element is different move to next diagonal
                            {
                                diagonalR = 1;
                                break;
                            }
                        }
                    }
                    diagonalR = 1;
                }
            }

            // check DiagonalLeft
            for (int i = 0; i <= matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    int col = j;
                    row = i;

                    if (col <= 1 || row >= matrix.GetLength(0) - 1)
                    {
                        break;
                    }
                    else
                    {
                        while (col > 0 && row < matrix.GetLength(0) - 1) //Move to Diagonal
                        {
                            if (matrix[row, col] == matrix[row + 1, col - 1]) 
                            {
                                diagonalL++;
                                if (diagonalL >= diagonalLMax)
                                {
                                    elementDL = matrix[row, col];
                                    diagonalLMax = diagonalL;
                                }
                                row++;
                                col--;
                            }
                            else 
                            {
                                diagonalL = 1;
                                break;
                            }
                        }
                        diagonalL = 1;
                    }
                }
            }


            //Fill MaxLenght of SameElements
            int[] maxLenght = new int[4];
            maxLenght[0] = horisontalMax;
            maxLenght[1] = verticalMax;
            maxLenght[2] = diagonalRMax;
            maxLenght[3] = diagonalLMax;

            //Fill Elements with maxLenght Element
            string[] elements = new string[4];
            elements[0] = elementH;
            elements[1] = elementV;
            elements[2] = elementDR;
            elements[3] = elementDL;

            //Print Exit
            for (int i = 0; i < 4; i++)
            {
                if (maxLenght.Max() == maxLenght[i])
                {
                    for (int j = 0; j < maxLenght.Max(); j++)
                    {
                        if (j < maxLenght.Max() - 1)
                        {
                            Console.Write(elements[i] + ",");
                        }
                        else
                        {
                            Console.Write(elements[i]);
                        }
                    }
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}














