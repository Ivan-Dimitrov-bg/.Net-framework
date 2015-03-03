//Write a method that adds two positive integer numbers 
//represented as arrays of digits (each array element arr[i] 
//contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up 
//to 10 000 digits.


using System;
using System.Collections.Generic;

class AddBigIntegersAsArrays
{
    static void Main()
    {
        Console.Write("Input the first positive integer: ");
        string input = Console.ReadLine();
        int[] firstNumber = new int[input.Length];
        int length = input.Length;
        for (int i = 0; i < length; i++)
        {
            firstNumber[i] = int.Parse(input[length - 1 - i].ToString());
        }
        Console.Write("Input the second positive integer: ");
        input = Console.ReadLine();
        int[] secondNumber = new int[input.Length];
        length = input.Length;
        for (int i = 0; i < length; i++)
        {
            secondNumber[i] = int.Parse(input[length - 1 - i].ToString());
        }
        int[] result = Add(firstNumber, secondNumber);
        Console.Write("And after adding the two numbers we get: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }

    private static int[] Add(int[] firstNumber, int[] secondNumber)
    {

        List<int> result = new List<int>(Math.Max(firstNumber.Length, secondNumber.Length) + 1);
        int min = Math.Min(firstNumber.Length, secondNumber.Length);
        int add = 0;
        for (int i = 0; i < min; i++)
        {
            result.Add((firstNumber[i] + secondNumber[i] + add) % 10);
            add = ((firstNumber[i] + secondNumber[i] + add) / 10) % 10;
        }
        if (firstNumber.Length > min)
        {
            for (int i = min; i < firstNumber.Length; i++)
            {
                result.Add((firstNumber[i] + add) % 10);
                add = ((firstNumber[i] + add) / 10) % 10;
            }
        }
        if (secondNumber.Length > min)
        {
            for (int i = min; i < secondNumber.Length; i++)
            {
                result.Add((secondNumber[i] + add) % 10);
                add = ((secondNumber[i] + add) / 10) % 10;
            }
        }
        if (add > 0)
        {
            result.Add(add);
        }
        return result.ToArray();
    }
}