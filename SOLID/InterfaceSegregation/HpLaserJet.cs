namespace DesignPatternsNET.SOLID.InterfaceSegregation;

public class HpLaserJet : IPrinter, IScanner, IFax
{

    public void PrintGrey(string content)
    {
        Console.WriteLine("HpLaserJet printing in grey...");
    }

    public void PrintColor(string content)
    {
        Console.WriteLine("HpLaserJet printing in color...");
    }

    public void Scan(string content)
    {
        Console.WriteLine("HpLaserJet scanning...");
    }

    public void Fax(string content)
    {
        Console.WriteLine("HpLaserJet faxing...");
    }
}