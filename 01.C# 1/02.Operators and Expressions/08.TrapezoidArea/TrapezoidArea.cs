using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            string title = "TrapezoidArea";
            string problem = "Write an expression that calculates trapezoid's area by given sides a and b and height h.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter h: ");
            int h = int.Parse(Console.ReadLine());

            int area = ((a + b) / 2) * h;
            Console.WriteLine("The area of trapezoid is {0}", area);
        }
    }
}
