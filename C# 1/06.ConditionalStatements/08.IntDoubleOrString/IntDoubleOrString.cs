using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IntDoubleOrString
{
    class IntDoubleOrString
    {
        static void Main()
        {
            string title = "IntDoubleOrString";
            string problem = @"Write a program that, depending on the user's choice inputs int, double or string variable. 
            If the variable is integer or double, increases it with 1. If the variable is string, appends (*) at its end. 
            The program must show the value of that variable as a console output. Use switch statement.";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            Console.WriteLine("Please, enter int, double or string");

            string data = Console.ReadLine();
            int dataInt;
            double dataDouble;
            bool isInt = int.TryParse(data, out dataInt);
            bool isDouble = double.TryParse(data, out dataDouble);

            if (isInt)
            {
                Console.WriteLine(++dataInt);
            }
            else if (isDouble)
            {
                Console.WriteLine(++dataDouble);
            }
            else
            {
                Console.WriteLine(data + "*");
            }

        }
    }
}
