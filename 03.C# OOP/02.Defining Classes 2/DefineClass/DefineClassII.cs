using System;
using System.IO;

    class DefineClassII
    {
        static void Main(string[] args)
        {
            Point3D proba = new Point3D(2, 3, 5.8);
            proba.ToString();
            StreamReader pointRead = new StreamReader(@"..\..\..\Points.txt");
            StreamWriter pointWrite = new StreamWriter(@"..\..\..\Save.txt");
            Path.Read(pointRead, pointWrite);
        }
    }
