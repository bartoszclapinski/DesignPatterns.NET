namespace DesignPatternsNET.Creational.Factory;

public class Triangle : Shape
{

    public override void Render()
    {
        Console.WriteLine($"Rendering Triangle at {x}, {y}");
    }
}