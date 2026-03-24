using Lab10;

List<IGraphic2DFactory> availableShapeTypes = new List<IGraphic2DFactory>
{
    new CircleFactory(),
    new RectangleFactory()
};

List<IGraphic2D> builtShapes = new List<IGraphic2D>();

while (true)
{
    Console.WriteLine("1 display drawing");
    Console.WriteLine("2 add graphic");
    Console.WriteLine("3 remove graphic");
    Console.WriteLine("4 exit");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.Clear();
        AbstractGraphic2D.Display(builtShapes);
        Console.ReadLine();
    }
    else if (input == "2")
    {
        for (int i = 0; i < availableShapeTypes.Count; i++)
        {
            Console.WriteLine($"{i}: {availableShapeTypes[i].Name}");
        }

        int choice = int.Parse(Console.ReadLine());

        var shape = availableShapeTypes[choice].Create();
        builtShapes.Add(shape);
    }
    else if (input == "3")
    {
        Console.WriteLine("enter index to remove");
        int index = int.Parse(Console.ReadLine());

        builtShapes.RemoveAt(index);
    }
    else if (input == "4")
    {
        break;
    }
}
