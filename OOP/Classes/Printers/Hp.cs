using DesignPatternsNET.OOP.Interfaces;

namespace DesignPatternsNET.OOP.Classes;

public class Hp : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine($"Hp is printing: {message}");
    }
}