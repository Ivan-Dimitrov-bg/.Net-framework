//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChackIfIsLeapYear
{
    class ChackIfIsLeapYear
    {
        static void Main()
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))// if is true the year is leap
            {
                Console.WriteLine("The year {0} is Leap!", year);
            }
            else
            {
                Console.WriteLine("The year {0} is Not Leap!", year);
            }

        }
    }
}
