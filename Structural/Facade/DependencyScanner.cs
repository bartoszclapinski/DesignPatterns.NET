namespace DesignPatternsNET.Structural.Facade;

public class DependencyScanner
{
    public IEnumerable<string> DependencyScan(string path)
    {
        Console.WriteLine($"Scanning dependencies of {path}");
        return new List<string> { "Dependency Error 1", "Dependency Error 2" };
    }
}