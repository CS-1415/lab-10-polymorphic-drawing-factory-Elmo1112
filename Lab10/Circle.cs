namespace Lab10;

public class Circle : AbstractGraphic2D
{
    public decimal CenterX { get; }
    public decimal CenterY { get; }
    public decimal Radius { get; }

    public Circle(decimal x, decimal y, decimal radius)
    {
        CenterX = x;
        CenterY = y;
        Radius = radius;
    }

    public override decimal LowerBoundX => CenterX - Radius;
    public override decimal UpperBoundX => CenterX + Radius;
    public override decimal LowerBoundY => CenterY - Radius;
    public override decimal UpperBoundY => CenterY + Radius;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        decimal dx = x - CenterX;
        decimal dy = y - CenterY;

        return (dx * dx + dy * dy) <= (Radius * Radius);
    }
}