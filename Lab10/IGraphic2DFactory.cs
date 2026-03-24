namespace Lab10;

public interface IGraphic2DFactory
{
    string Name { get; }

    IGraphic2D Create();
}