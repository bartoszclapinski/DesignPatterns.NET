namespace DesignPatternsNET.SOLID.InterfaceSegregation;

public class Canon : IPrinter, IFax
{

    public void PrintGrey(string content)
    {
        Console.WriteLine("Canon printing in grey...");
    }

    public void PrintColor(string content)
    {
        Console.WriteLine("Canon printing in color...");
    }

    public void Fax(string content)
    {
        Console.WriteLine("Canon faxing...");
    }
}