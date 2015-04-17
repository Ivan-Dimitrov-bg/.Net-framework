//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console
using System;

class PadRight
{
    static void Main()
    {
        string str = "Some text";
        string newStr = str.PadRight(20, '*');
        Console.WriteLine(newStr);
    }
}