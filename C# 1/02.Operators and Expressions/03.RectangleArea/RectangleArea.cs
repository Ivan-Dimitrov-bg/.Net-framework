using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            string title = "RectangleArea";
            string problem = "Write an expression that calculates rectangle’s area by given width and height.";
            Console.WriteLine(" Title:  {0} \nProblem: {1}", title, problem);

            Console.Write("Enter width: ");
            int widthRectangle = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int heightRectangle = int.Parse(Console.ReadLine());

            Console.WriteLine("Rectangle's area is {0}", widthRectangle * heightRectangle);



        }
    }
}
