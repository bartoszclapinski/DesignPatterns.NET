namespace DesignPatternsNET.Behavioral.TemplateMethod;

public class ExcelGenerator : Generator
{

    protected override void PrepareData()
    {
        Console.WriteLine("Preparing data for Excel...");
    }

    protected override void GenerateFile()
    {
        Console.WriteLine("Generating Excel file...");
    }
}