using DesignPatternsNET.Creational.AbstractFactory.Interfaces;

namespace DesignPatternsNET.Creational.AbstractFactory.Windows;

public class WindowsTexBox : ITextBox
{

    public void Render()
    {
        Console.WriteLine("Rendering Windows TextBox");
    }

    public void HandleInput()
    {
        Console.WriteLine("Handling Windows TextBox Input");
    }
}