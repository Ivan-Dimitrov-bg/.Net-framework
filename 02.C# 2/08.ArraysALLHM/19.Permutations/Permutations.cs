using System;

class Permutations
{
    static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }

    static void Permute(int[] array, int current, int length)
    {
        if (current == length)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Swap(ref array[i], ref array[current]);
                Permute(array, current + 1, length);
                Swap(ref array[i], ref array[current]);
            }
        }

    }

    static void Main(string[] args)
    {
        string titel = "Permutations";
        string problem = @"* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:

n = 3 à {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}";
        Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);
        int N = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[N];

        for (int i = 1; i <= N; i++)
        {
            arrayOfNumbers[i - 1] = i;
        }

        Permute(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);
    }
}