////Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SurfaceOfTriangle
{
    class SurfaceOfTriangle
    {
        static void Main()
        {
            Console.WriteLine("Choose, how to calculate the surface of the triangle");
            Console.WriteLine("Please 1, 2 or 3");
            Console.WriteLine("1: Use site and altitude");
            Console.WriteLine("2: Use Three Sides");
            Console.WriteLine("3: Two sides and an angle between them");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: SideAndAltitude();break;

                case 2: ThreeSides();break;

                case 3: TwoSidesAndAngle();break;

                default: Console.WriteLine("Press 1, 2 or 3");break;
            }
        }

        private static void TwoSidesAndAngle()
        {
            Console.WriteLine("side 1: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.WriteLine("side 2:");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Enter an angle:");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface is:{0}", sideOne * sideTwo * Math.Sin(Math.PI * angle / 180) / 2);
        }

        private static void ThreeSides()
        {
            
            double[] sideTriangle = new double[4];
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Side: {0} = ", i);
                double side = double.Parse(Console.ReadLine());
                sideTriangle[i] = side; 
            }
            double p = (sideTriangle[1] + sideTriangle[2] + sideTriangle[3]) / 2;
            
            Console.WriteLine("S = {0}", Math.Sqrt(p * (p - sideTriangle[1]) * (p - sideTriangle[2]) * (p - sideTriangle[3])));
            
        }

        private static void SideAndAltitude()
        {
            Console.Write("side = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Altitude = ");
            double h = double.Parse(Console.ReadLine());
            double surface = (a * h) / 2;
            Console.Write("The surface is:{0}", surface);
        }
    }
}
