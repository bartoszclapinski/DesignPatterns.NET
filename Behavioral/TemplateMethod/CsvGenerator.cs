namespace DesignPatternsNET.Behavioral.TemplateMethod;

public class CsvGenerator : Generator
{

    protected override void PrepareData()
    {
        Console.WriteLine("Preparing data for CSV...");
    }

    protected override void GenerateFile()
    {
        Console.WriteLine("Generating CSV file...");
    }
}