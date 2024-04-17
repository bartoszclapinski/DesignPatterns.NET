namespace DesignPatternsNET.Structural.Facade;

public class SecurityScanner
{
    public IEnumerable<string> SecurityScan(string path)
    {
        Console.WriteLine($"Scanning security of {path}");
        return new List<string> { "Security Error 3", "Security Error 4" };
    }
}