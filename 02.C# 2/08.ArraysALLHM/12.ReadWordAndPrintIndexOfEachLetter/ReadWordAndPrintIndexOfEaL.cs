using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ReadWordAndPrintIndexOfEachLetter
{
    class ReadWordAndPrintIndexOfEaL
    {
        static void Main(string[] args)
        {

            string titel = "ReadWordAndPrintIndexOfEachLetter";
            string problem = @"Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.";

            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            char[] alphabet = new char[53];


            for (int i = 1; i < (alphabet.Length / 2 + 1); i++) // loop for small letters
            {
                alphabet[i] = (char)(64 + i);//position on 'a' is 65

            }
            for (int i = 0; i < (alphabet.Length / 2); i++)// loop for capital letters
            {
                alphabet[(alphabet.Length / 2 + 1) + i] = (char)(i + 97);// start with element that is last in loop one
            }

            string word = Console.ReadLine();

            // solution

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} : position i Array: {1}", word[i], j);
                    }
                }
            }
        }
    }
}