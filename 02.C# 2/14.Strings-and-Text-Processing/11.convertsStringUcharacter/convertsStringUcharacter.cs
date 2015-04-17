//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//Hi!
//\u0048\u0069\u0021
using System;
using System.Text;

class Program
{
    static string ConvertToUnicode(string str)
    {
        StringBuilder utf = new StringBuilder(str.Length * 6);

        foreach (char c in str)
            utf.AppendFormat("\\u{0:X4}", (int)c);

        return utf.ToString();
    }

    static void Main()
    {
        Console.WriteLine(ConvertToUnicode("Hi!"));
    }
}