namespace DesignPatternsNET.Creational.Factory;

public class Circle : Shape
{

    public override void Render()
    {
        Console.WriteLine($"Rendering Circle at {x}, {y}");
    }
}