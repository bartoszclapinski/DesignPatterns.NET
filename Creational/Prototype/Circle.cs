namespace DesignPatternsNET.Creational.Prototype;

public class Circle : Shape
{

    public override void Render()
    {
        Console.WriteLine("Rendering Circle");
    }

    public override Shape Clone()
    {
        Circle cloneBase = (Circle)MemberwiseClone();
        cloneBase.Border = new Border { Color = Border.Color, Size = Border.Size };
        
        return cloneBase;
    }
}