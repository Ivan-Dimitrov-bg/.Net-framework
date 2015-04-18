using System;
using System.IO;
using System.Collections.Generic;


    class Path
    {         

        public static void Read(StreamReader sr, StreamWriter sw)
        {
            List<Point3D> tochki = new List<Point3D>();
            using (sr)
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] coords = line.Split(' ');
                    Point3D current = new Point3D(double.Parse(coords[0]), double.Parse(coords[1]), double.Parse(coords[2]));
                    tochki.Add(current);
                    line = sr.ReadLine();
                }
            }

            using (sw)
            {
                foreach (Point3D p in tochki)
                {
                    sw.WriteLine("X coordinate is " + p.X + " Y coordinate is " + p.Y + " Z coordinate is " + p.Z);
                }
            }
        }
    }