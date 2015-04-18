public class Triangle : Shapess
{
    public Triangle(int width, int height) : base(width, height) { }
    public override double CalculateSurface()
    {
        return this.Height * Width / 2;
    }
}