using DesignPatternsNET.Creational.AbstractFactory.Interfaces;

namespace DesignPatternsNET.Creational.AbstractFactory.Mac;

public class MacButton : IButton
{

    public void Render()
    {
        Console.WriteLine("Rendering Mac Button");
    }

    public void HandleClick()
    {
        Console.WriteLine("Handling Mac Button Click");
    }
}