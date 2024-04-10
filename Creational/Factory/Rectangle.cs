namespace DesignPatternsNET.Creational.Factory;

public class Rectangle : Shape
{

    public override void Render()
    {
        Console.WriteLine($"Rendering Rectangle at {x}, {y}");
    }
}