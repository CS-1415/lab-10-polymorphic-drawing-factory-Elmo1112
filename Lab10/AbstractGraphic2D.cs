namespace Lab10;

public abstract class AbstractGraphic2D : IGraphic2D
{
    public abstract bool ContainsPoint(decimal x, decimal y);

    public abstract decimal LowerBoundX { get; }
    public abstract decimal UpperBoundX { get; }
    public abstract decimal LowerBoundY { get; }
    public abstract decimal UpperBoundY { get; }

    public char DisplayChar { get; set; }
    public ConsoleColor ForegroundColor { get; set; }
    public ConsoleColor BackgroundColor { get; set; }

    public static void Display(List<IGraphic2D> shapes)
    {
        foreach (IGraphic2D shape in shapes)
        {
            shape.Display();
        }
    }

    public bool Display()
    {
        Console.ForegroundColor = ForegroundColor;
        Console.BackgroundColor = BackgroundColor;

        int lowX = (int)LowerBoundX;
        int lowY = (int)LowerBoundY;
        int highX = (int)UpperBoundX;
        int highY = (int)UpperBoundY;

        for (int y = lowY; y <= highY; y++)
        {
            for (int x = lowX; x <= highX; x++)
            {
                if (ContainsPoint(x, y))
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(DisplayChar);
                }
            }
        }

        Console.ResetColor();
        return true;
    }
}