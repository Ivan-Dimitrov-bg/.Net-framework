using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertNumberInRange
{
    class ConvertNumberInRange
    {
        //Method for the digits (0 to 9)
        public static void Digits(int number)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine(" Zero ");
                    break;
                case 1:
                    Console.Write(" One ");
                    break;
                case 2:
                    Console.Write(" Two ");
                    break;
                case 3:
                    Console.Write(" Three ");
                    break;
                case 4:
                    Console.Write(" Four ");
                    break;
                case 5:
                    Console.Write(" Five ");
                    break;
                case 6:
                    Console.Write(" Six ");
                    break;
                case 7:
                    Console.Write(" Seven ");
                    break;
                case 8:
                    Console.Write(" Eight ");
                    break;
                case 9:
                    Console.Write(" Nine ");
                    break;
                default:
                    break;
            }
        }
        //Method for the special cases (10 to 19)
        public static void SpecialCases(int number)
        {
            switch (number)
            {
                case 10:
                    Console.Write(" Ten ");
                    break;
                case 11:
                    Console.Write(" Eleven ");
                    break;
                case 12:
                    Console.Write(" Twelve ");
                    break;
                case 13:
                    Console.Write(" Thirteen ");
                    break;
                case 14:
                    Console.Write(" Fourteen ");
                    break;
                case 15:
                    Console.Write(" Fifteen ");
                    break;
                case 16:
                    Console.Write(" Sixteen ");
                    break;
                case 17:
                    Console.Write(" Seventeen ");
                    break;
                case 18:
                    Console.Write(" Eighteen ");
                    break;
                case 19:
                    Console.Write(" Nineteen ");
                    break;
                default:
                    break;
            }
        }

        //Method for tens
        public static void Tens(int number)
        {
            switch (number)
            {
                case 2:
                    Console.Write(" Twenty ");
                    break;
                case 3:
                    Console.Write(" Thirty ");
                    break;
                case 4:
                    Console.Write(" Fourty ");
                    break;
                case 5:
                    Console.Write(" Fifty ");
                    break;
                case 6:
                    Console.Write(" Sixty ");
                    break;
                case 7:
                    Console.Write(" Seventy ");
                    break;
                case 8:
                    Console.Write(" Eighty ");
                    break;
                case 9:
                    Console.Write(" Ninety ");
                    break;
                default:
                    break;
            }
        }

        //Method for hundreds
        public static void Hundreds(int number)
        {
            switch (number)
            {
                case 1:
                    Console.Write(" One Hundred ");
                    break;
                case 2:
                    Console.Write(" Two Hunderd ");
                    break;
                case 3:
                    Console.Write(" Three Hundred ");
                    break;
                case 4:
                    Console.Write(" Four Hundred ");
                    break;
                case 5:
                    Console.Write(" Five Hundred ");
                    break;
                case 6:
                    Console.Write(" Six Hundred ");
                    break;
                case 7:
                    Console.Write(" Seven Hundred ");
                    break;
                case 8:
                    Console.Write(" Eight Hundred ");
                    break;
                case 9:
                    Console.Write(" Nine Hundred ");
                    break;
                default:
                    break;
            }
        }
        static void Main()
        {
            string title = "ConvertNumberInRange";
            string problem = @"* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	• 0 à (Zero)
	• 273 à (Two hundred seventy three)
	• 400 à (Four hundred)
	• 501 à (Five hundred and one)
	• 711 à (Seven hundred and eleven)
";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            int number, firstDigit, secondDigit, thirdDigit;

            Console.WriteLine("Enter number between 0 and 999");
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());

            while (number < 0 || number > 999)
            {
                Console.WriteLine("Invalid input. Only number in the range [0 - 999] \n");
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());
            }

            // Digits
            if (number < 10)
            {
                Digits(number);
            }
            // Special cases(10 to 19)
            else if (number >= 10 && number <= 19)
            {
                SpecialCases(number);
            }
            // tens
            else if (number >= 20 && number < 100) // number between 20 and 99
            {
                firstDigit = number / 10; // take first digit
                secondDigit = number % 10; // take second digit

                if (secondDigit == 0)
                {
                    Tens(firstDigit);
                }
            }

 //Hundreds
            else if (number >= 100 && number < 1000) //numbers between 100 and 999
            {
                firstDigit = number / 100;
                secondDigit = (number / 10) % 10;
                thirdDigit = number % 10;
                Hundreds(firstDigit);

                int specials = number % 100;

                int digits = number % 100; // check for digits (0 to 9). Example: 501 (five hundred and one)
                if ((digits > 0 && digits < 10) || (specials >= 10 && specials < 20) && specials != 0)
                {
                    Console.Write("and");
                    Digits(digits);
                }

                //check for special cases (10 to 19)
                if (specials >= 10 && specials < 20)
                {
                    SpecialCases(specials);
                }

                int noZero = number % 100;  // check for zero in third and second digit
                if (noZero == 0)
                {
                    Hundreds(noZero);
                }
                else if (number > 20 && number < 1000)
                {
                    Tens(secondDigit);
                    int zeroChecker = number % 100;
                    int otherZeroChecker = number % 10;
                    if (otherZeroChecker != 0 && zeroChecker != 1 && zeroChecker != 2 && zeroChecker != 3 &&
                        zeroChecker != 4 && zeroChecker != 5 && zeroChecker != 6 &&
                        zeroChecker != 7 && zeroChecker != 8 && zeroChecker != 9 &&
                        !(specials >= 10 && specials < 20)) // check for zero in third digit
                    {
                        Digits(thirdDigit);
                    }
                }



            }
            Console.WriteLine();

        }
    }
}