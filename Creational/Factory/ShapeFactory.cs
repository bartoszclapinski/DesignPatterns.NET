namespace DesignPatternsNET.Creational.Factory;

public class ShapeFactory
{
    public Shape CreateShape(ShapeType shapeType)
    {
        return shapeType switch
        {
            ShapeType.Circle => new Circle(),
            ShapeType.Rectangle => new Rectangle(),
            ShapeType.Triangle => new Triangle(),
            _ => throw new ArgumentException("Invalid shape type")
        };
    }
}