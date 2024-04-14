namespace DesignPatternsNET.Behavioral.TemplateMethod;

public static class TemplateMethodApp
{
    public static void Run()
    {
        var pdfGenerator = new PdfGenerator();
        pdfGenerator.Generate();
        
        var excelGenerator = new ExcelGenerator();
        excelGenerator.Generate();
        
        var csvGenerator = new CsvGenerator();
        csvGenerator.Generate();
    }
}