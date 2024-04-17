namespace DesignPatternsNET.Structural.Facade;

public class ReportGenerator
{
    public void GenerateReport(
                    IEnumerable<string> qualityErrors, 
                    IEnumerable<string> securityErrors, 
                    IEnumerable<string> dependencyErrors)
    {
        Console.WriteLine("Quality Scan Errors:");
        Console.WriteLine(string.Join(", ", qualityErrors));
        
        Console.WriteLine("Security Scan Errors:");
        Console.WriteLine(string.Join(", ", securityErrors));
        
        Console.WriteLine("Dependency Scan Errors:");
        Console.WriteLine(string.Join(", ", dependencyErrors));
    }
}