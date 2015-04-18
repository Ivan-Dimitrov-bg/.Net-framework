using System;
public class Circle : Shapess
{

    public Circle(int radius)
        : base(radius)
    {

    }
    public override double CalculateSurface()
    {
        return Math.PI * this.Width * 2;
    }
}