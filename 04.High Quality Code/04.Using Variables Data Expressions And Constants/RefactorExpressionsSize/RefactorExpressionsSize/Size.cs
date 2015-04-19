using System;

public class Size
{
    private double width;
    private double height;

    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Size GetRotatedSize(Size size, double angleOfTheFigure)
    {
        double cosOfTheFigure = Math.Abs(Math.Cos(angleOfTheFigure));
        double sinOfTheFigure = Math.Abs(Math.Sin(angleOfTheFigure));

        double widthOfTheRotatedFigure = cosOfTheFigure * size.width + sinOfTheFigure * size.height;
        double heightOfTheRotatedFigure = sinOfTheFigure * size.width + cosOfTheFigure * size.height;

        Size rotatedSize = new Size(widthOfTheRotatedFigure, heightOfTheRotatedFigure);

        return rotatedSize;
    }
}