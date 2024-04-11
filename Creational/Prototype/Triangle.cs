namespace DesignPatternsNET.Creational.Prototype;

public class Triangle : Shape
{
    public int Radius { get; set; }
    
    public override void Render()
    {
        Console.WriteLine("Rendering Triangle");
    }

    public override Shape Clone()
    {
        return (Triangle)MemberwiseClone();
    }
}