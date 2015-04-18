//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
            if (str[i] != str[str.Length - 1 - i])
                return false;

        return true;
    }

    static void Main()
    {
        string str = "Static void Main() ABBA, using System lamal, exe.";

        foreach (Match item in Regex.Matches(str, @"\w+"))
            if (IsPalindrome(item.Value)) Console.WriteLine(item);

        foreach (Match item in Regex.Matches(str, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b")) // http://i.qkme.me/355ovv.jpg
            Console.WriteLine(item);
    }
}
// common search patterns:
// \S+ - every character that isn't whitespace (one or more)
// \s+ - whitespase one or more
// \s* - white spaces (space, tab, newline...) appear 0 or more times
// \w - characters a - z or A-Z or 0 - 9 appear one time or more times
// \W - every character that isn't letters or numbers.
// \d - digits only.
// \D - anyting not a digit.