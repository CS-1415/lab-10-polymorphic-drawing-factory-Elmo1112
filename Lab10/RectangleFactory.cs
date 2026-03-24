namespace Lab10;

public class RectangleFactory : IGraphic2DFactory
{
    public string Name => "Rectangle";

    public IGraphic2D Create()
    {
        Console.Write("enter left: ");
        decimal left = decimal.Parse(Console.ReadLine());

        Console.Write("enter top: ");
        decimal top = decimal.Parse(Console.ReadLine());

        Console.Write("enter width: ");
        decimal width = decimal.Parse(Console.ReadLine());

        Console.Write("enter height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        Console.Write("enter display character: ");
        char displayChar = Console.ReadLine()[0];

        return new Rectangle(left, top, width, height)
        {
            DisplayChar = displayChar,
            ForegroundColor = ConsoleColor.Green,
            BackgroundColor = ConsoleColor.Black
        };
    }
}