using DesignPatternsNET.Creational.AbstractFactory.Interfaces;

namespace DesignPatternsNET.Creational.AbstractFactory.Mac;

public class MacTextBox : ITextBox
{

    public void Render()
    {
        Console.WriteLine("Rendering Mac TextBox");
    }

    public void HandleInput()
    {
        Console.WriteLine("Handling Mac TextBox Input");
    }
}