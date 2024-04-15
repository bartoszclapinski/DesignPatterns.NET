namespace DesignPatternsNET.Behavioral.TemplateMethod;

public class PdfGenerator : Generator
{

    protected override void PrepareData()
    {
        Console.WriteLine("Preparing data for PDF...");
    }

    protected override void GenerateFile()
    {
        Console.WriteLine("Generating PDF file...");
    }

    protected override void GetData()
    {
        Console.WriteLine("Getting data for PDF...");
    }
}