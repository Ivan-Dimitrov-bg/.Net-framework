//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512 à "two", 1024 à "four", 12309 à "nine".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReturnTheLastDigitAsWord
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter some integer:");
            int number = int.Parse(Console.ReadLine());

            int lastDigit = FindLastDigit(number);
            PrintDigitAsWord(lastDigit);
            
        }

        private static void PrintDigitAsWord(int lastDigit)
        {
            switch (lastDigit)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
            }
        }

        private static int FindLastDigit(int number)
        {
            int lastNum = number % 10;
            return lastNum;
        }
    }
}
