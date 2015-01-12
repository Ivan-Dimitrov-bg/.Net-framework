using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.WithinACircleAndOutOfRectangle
{
    class WithinACircleAndOutOfRectangle
    {
        static void Main(string[] args)
        {
            string title = "WithinACircleAndOutOfRectangle";
            string problem = @"Write an expression that checks for given point (x, y) 
            if it is within the circle K( (1,1), 3) and out of the rectangle
            R(top=1, left=-1, width=6, height=2).";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please enter x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Please enter y = ");
            int y = int.Parse(Console.ReadLine());

            if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) < 9)
            {
                if (y > 1)
                {
                    Console.WriteLine("Point is in circle, outside rec");
                }
                else if ((y < 1 || y > -1) && x < -1)
                {
                    Console.WriteLine("Point is in circle, outside rec");
                }
                else if (y < -1)
                {
                    Console.WriteLine("Point is in circle, outside rec");
                }
                else
                {
                    Console.WriteLine("Point doesn't meet conditions");
                }
            }

        }
    }
}
