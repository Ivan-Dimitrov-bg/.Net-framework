using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            string title = "QuadraticEquation";
            string problem = @"• Write a program that enters the coefficients a, b and c of a quadratic equation
	• a*x2 + b*x + c = 0
and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
";
            Console.WriteLine("Titel:   " + title + "\n" + "Problem: " + problem);

            double a, b, c, discriminant, x1, x2;

            Console.Write("Enter the first coefficient a: ");
            bool isADoubleA = double.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter the second coefficient b: ");
            bool isADoubleB = double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Enter the second coefficient c: ");
            bool isADoubleC = double.TryParse(Console.ReadLine(), out c);

            if (isADoubleA & isADoubleB & isADoubleC)
            {
                discriminant = (b * b) - (4 * a * c);
                if (discriminant > 0)
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                    x2 = (b + Math.Sqrt(discriminant)) / 2 * a;
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else if (discriminant == 0)
                {
                    x1 = x2 = -b / 2 * a;
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine("x1={0}", x1);
                    Console.WriteLine("x2={0}", x2);
                }
                else
                {
                    Console.WriteLine("There are no real roots!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not double!");
            }

        }
    }
}
