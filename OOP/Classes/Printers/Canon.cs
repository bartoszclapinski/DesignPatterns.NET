using DesignPatternsNET.OOP.Interfaces;

namespace DesignPatternsNET.OOP.Classes;

public class Canon : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine($"Canon is printing: {message}");
    }
}