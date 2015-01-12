using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintCirclesPerimeterAndArea
{
    class PrintCirclesPerimeterAndArea
    {
        static void Main(string[] args)
        {
            string titel = "PrintSumtThreeInt";
            string problem = @"Write a program that reads the radius r of a circle and prints its perimeter and area.";
            Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

            int radius;
            Console.Write("Please, enter radius r = ");
            bool isAIntRadius = int.TryParse(Console.ReadLine(), out radius);

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * (Math.Pow(radius, 2)); // radius * radius
            Console.WriteLine("The perimeter of the circle is: {0}", perimeter);
            Console.WriteLine("The area of the circle is:{0} ", area);
           

        }
    }
}
