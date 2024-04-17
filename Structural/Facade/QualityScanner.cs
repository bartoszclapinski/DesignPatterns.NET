namespace DesignPatternsNET.Structural.Facade;

public class QualityScanner
{
    public IEnumerable<string> QualityScan(string path)
    {
        Console.WriteLine($"Scanning quality of {path}");
        return new List<string> { "Error 1", "Error 2" };
    }
}