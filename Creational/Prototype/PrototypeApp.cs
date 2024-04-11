namespace DesignPatternsNET.Creational.Prototype;

public static class PrototypeApp
{
    public static void Run()
    {
        //  Prototype pattern allows to create a copy of an existing object
        var triangle = new Triangle { X = 10, Y = 20, Border = new Border { Color = "Red", Size = "2px" } };
        var clonedTriangle = triangle.Clone();
        clonedTriangle.X = 30;
        clonedTriangle.Y = 40;
        clonedTriangle.Border.Color = "Blue";
        clonedTriangle.Border.Size = "4px";

        triangle.Render();
        clonedTriangle.Render();
        
        //  Shallow cloning is used, so the Border object is the same for both Circle objects
        Console.WriteLine("Shallow Cloning:");
        Console.WriteLine("Objects ReferenceEquals? : " + ReferenceEquals(triangle, clonedTriangle));
        Console.WriteLine("Border ReferenceEquals? : " + ReferenceEquals(triangle.Border, clonedTriangle.Border));
        
        
        var circle = new Circle { X = 10, Y = 20, Border = new Border { Color = "Red", Size = "2px" } };
        var clonedCircle = circle.Clone();
        clonedCircle.X = 30;
        clonedCircle.Y = 40;
        clonedCircle.Border.Color = "Blue";
        clonedCircle.Border.Size = "4px";
        
        circle.Render();
        clonedCircle.Render();
        
        //  Deep cloning is used, so the Border object is different for both Circle objects
        Console.WriteLine("Deep Cloning:");
        Console.WriteLine("Objects ReferenceEquals? : " + ReferenceEquals(circle, clonedCircle));
        Console.WriteLine("Border ReferenceEquals? : " + ReferenceEquals(circle.Border, clonedCircle.Border));
    }
}