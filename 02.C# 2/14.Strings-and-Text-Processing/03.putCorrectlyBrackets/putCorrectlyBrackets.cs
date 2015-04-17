//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
using System;

class putCorrectlyBrackets
{
    static void Main()
    {
        string exampleOne = "((a + b) / 5 - d)";
        string exampleTwo = ")(a+b))";
        Console.WriteLine(CheckBrackets(exampleOne));
        Console.WriteLine(CheckBrackets(exampleTwo));
    }
    static bool CheckBrackets(string str)
    {

        int stack = 0;
        for (int i = 0; i < str.Length && stack >= 0 ; i++)
        {
            if (str[i] == '(')
            {
                stack++;
            }
            else if (str[i] == ')')
            {
                stack--;
            }
        }
        return stack == 0;
    }

}