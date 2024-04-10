using DesignPatternsNET.Creational.Factory;
namespace DesignPatternsNET.Creational.Factory;

public static class FactoryApp
{
    public static void Run()
    {
        var shapeFactory = new ShapeFactory();
        
        Shape shape1 = shapeFactory.CreateShape(ShapeType.Rectangle);
        shape1.x = 10;
        shape1.y = 20;
        shape1.Render();
        
        Shape shape2 = shapeFactory.CreateShape(ShapeType.Circle);
        shape2.x = 30;
        shape2.y = 40;
        shape2.Render();
        
        Shape shape3 = shapeFactory.CreateShape(ShapeType.Triangle);
        shape3.x = 50;
        shape3.y = 60;
        shape3.Render();
    }
}