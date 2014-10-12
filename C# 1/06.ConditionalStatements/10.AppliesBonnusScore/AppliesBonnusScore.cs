using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.AppliesBonnusScore
{
    class AppliesBonnusScore
    {
        static void Main()
        {
            string title = "IntDoubleOrString";
            string problem = @"Write a program that applies bonus scores to given scores in the range [1..9]. 
The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; 
if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
If it is zero or if the value is not a digit, the program must report an error.
Use a switch statement and at the end print the calculated new value in the console.";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            Console.WriteLine("Enter a digit in the range [1..9]: ");
        string userInput = Console.ReadLine();
        ushort intInput;
        bool isDigit = ushort.TryParse(userInput, out intInput);
 
        if (isDigit)
        {
            switch (intInput)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(intInput * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(intInput * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(intInput * 1000);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error! Incorrect input!");
        }
    }
}
