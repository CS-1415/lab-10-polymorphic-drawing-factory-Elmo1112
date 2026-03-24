namespace Lab10
;

public class Rectangle : AbstractGraphic2D
{
    public decimal Left { get; }
    public decimal Top { get; }
    public decimal Width { get; }
    public decimal Height { get; }

    public Rectangle(decimal left, decimal top, decimal width, decimal height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }

    public override decimal LowerBoundX => Left;
    public override decimal UpperBoundX => Left + Width;
    public override decimal LowerBoundY => Top;
    public override decimal UpperBoundY => Top + Height;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return x >= Left &&
               x <= Left + Width &&
               y >= Top &&
               y <= Top + Height;
    }
}