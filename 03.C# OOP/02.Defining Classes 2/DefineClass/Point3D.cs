using System;

    struct Point3D
    {      
        private static readonly Point3D pointZero = new Point3D(0, 0, 0);

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }    

        public Point3D(double x, double y, double z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }            

        public static Point3D Start()
        {
            return pointZero;
        }

        public void ToString()
        {
          Console.WriteLine("The coordinates of the point are: ");
          Console.WriteLine("X = {0}  Y = {1}   Z = {2}", X, Y, Z);           
        }
    }
