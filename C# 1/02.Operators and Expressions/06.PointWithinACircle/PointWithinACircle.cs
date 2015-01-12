using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PointWithinACircle
{
    class PointWithinACircle
    {
        static void Main(string[] args)
        {
            string title = "PointWithinACircle";
            string problem = "Write an expression that checks if given point (x,  y) is within a circle K(O, 5).";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Please enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Please enter y: ");
            int y = int.Parse(Console.ReadLine());
            int radios = 5;
            bool onTheCircle = x * x + y * y == radios * radios;
            if (onTheCircle) 
	        {
                Console.WriteLine("The point with cordinate {0} and {1} is on the circle", x, y );
	        }
            else
            {
                string result = x * x + y * y < radios * radios ? "Yes" : "No";
                Console.WriteLine("The point with cordinate {0} and {1} is within the circle : {2}", x, y, result );
            }

        }
    }
}
