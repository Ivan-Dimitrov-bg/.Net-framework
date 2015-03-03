//Write a method that reverses the digits of
//given decimal number. Example: 256 à 652


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ReversesNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please, Enter some number ");
           // decimal someNumber = decimal.Parse(Console.ReadLine());
            decimal someNumber = -123.456m;
            Console.WriteLine("The number is: {0}", someNumber);
            string numberToString = someNumber.ToString();
            string reversNumber = ReversedNumber(numberToString);
            Console.WriteLine(reversNumber);
        }

        private static string ReversedNumber(string someNumber)
        {
            string reversNumber ="";
            char[] reversedChar = someNumber.ToCharArray();
            Array.Reverse(reversedChar);
            StringBuilder reversed = new StringBuilder();
            if (reversedChar[reversedChar.Length - 1] == '-')
            {
                reversed = reversed.Append("-");
                for (int i = 0; i < reversedChar.Length - 1; i++)
                {
                    reversed = reversed.Append(reversedChar[i]);
                }
            }
            else
            {
                for (int i = 0; i < reversedChar.Length; i++)
                {
                    reversed = reversed.Append(reversedChar[i]);
                }
            }

            return reversed.ToString();

        }
    }
}
