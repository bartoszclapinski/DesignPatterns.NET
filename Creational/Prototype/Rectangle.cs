namespace DesignPatternsNET.Creational.Prototype;

public class Rectangle : Shape
{

    public override void Render()
    {
        Console.WriteLine("Rendering Rectangle");
    }

    public override Shape Clone()
    {
        return (Rectangle)MemberwiseClone();
    }
}