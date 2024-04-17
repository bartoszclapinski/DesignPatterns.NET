namespace DesignPatternsNET.Structural.Facade;

public class ScanFacade
{
    private readonly QualityScanner _qualityScanner = new ();
    private readonly SecurityScanner _securityScanner = new ();
    private readonly DependencyScanner _dependencyScanner = new ();
    private readonly ReportGenerator _reportGenerator = new ();
    
    public void Scan(string path)
    {
        Console.WriteLine($"Scanning {path}");
        
        var qualityScanErrors = _qualityScanner.QualityScan(path);
        var securityScanErrors = _securityScanner.SecurityScan(path);
        var dependencyScanErrors = _dependencyScanner.DependencyScan(path);
        
        _reportGenerator.GenerateReport(qualityScanErrors, securityScanErrors, dependencyScanErrors);
    }
}