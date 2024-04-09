namespace DesignPatternsNET.SOLID.OpenClose.Shapes;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class Shape
{
    public virtual void Render()
    {
    }
}

public class Circle : Shape
{
    public Point Center { get; set; }
    public int Radius { get; set; }

    public override void Render()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Point TopLeft { get; set; }
    public override void Render()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}