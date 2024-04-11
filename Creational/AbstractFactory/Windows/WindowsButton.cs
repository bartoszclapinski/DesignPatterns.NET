using DesignPatternsNET.Creational.AbstractFactory.Interfaces;

namespace DesignPatternsNET.Creational.AbstractFactory.Windows;

public class WindowsButton : IButton
{

    public void Render()
    {
        Console.WriteLine("Rendering Windows Button");
    }

    public void HandleClick()
    {
        Console.WriteLine("Handling Windows Button Click");
    }
}