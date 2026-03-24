namespace Lab10;

public class CircleFactory : IGraphic2DFactory
{
    public string Name => "Circle";

    public IGraphic2D Create()
    {
        Console.Write("enter center X: ");
        decimal x = decimal.Parse(Console.ReadLine());

        Console.Write("enter center Y: ");
        decimal y = decimal.Parse(Console.ReadLine());

        Console.Write("enter radius: ");
        decimal r = decimal.Parse(Console.ReadLine());

        Console.Write("enter display character: ");
        char displayChar = Console.ReadLine()[0];

        return new Circle(x, y, r)
        {
            DisplayChar = displayChar,
            ForegroundColor = ConsoleColor.Cyan,
            BackgroundColor = ConsoleColor.Black
        };
    }
}