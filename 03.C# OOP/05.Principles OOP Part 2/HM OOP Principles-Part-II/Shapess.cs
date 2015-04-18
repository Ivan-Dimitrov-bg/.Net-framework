/*
 Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). 
Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
 Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shapess
{
    protected int Width { get; set; }
    protected int Height { get; set; }
    public Shapess(int width)
    {
        this.Width = width;
    }
    public Shapess(int widht, int height)
    {
        this.Width = widht;
        this.Height = height;
    }
    public abstract double CalculateSurface();

}