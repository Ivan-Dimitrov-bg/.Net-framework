using System;


    static class Distance
    {
        static double Length(Point3D one, Point3D two)
        {
            double a = one.X - two.X;
            double b = one.Y - two.Y;
            double c = one.Z - two.Z;
            return Math.Sqrt(a * a + b * b + c * c);
        }
    }

