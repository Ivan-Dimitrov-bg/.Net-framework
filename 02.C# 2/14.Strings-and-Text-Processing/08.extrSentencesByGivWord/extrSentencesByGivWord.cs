//Write a program that extracts from a given text all sentences containing given word.
    //Example: The word is "in". The text is:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//We are living in a yellow submarine.
//We will move out of it in 5 days.

//Consider that the sentences are separated by "." and the words – by non-letter symbols.
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        foreach (Match sentence in Regex.Matches(str, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
        {
            Console.WriteLine(sentence.Groups[1]);
        }
        

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