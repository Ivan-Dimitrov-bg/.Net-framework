
public class Rectangle : Shapess
{
    public Rectangle(int width, int height) : base(width, height) { }
    public override double CalculateSurface()
    {
        return this.Height * Width;
    }

}
