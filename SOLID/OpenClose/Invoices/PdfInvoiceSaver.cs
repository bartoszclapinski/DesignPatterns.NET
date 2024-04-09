namespace DesignPatternsNET.SOLID.OpenClose;

public class PdfInvoiceSaver : IInvoiceSaver
{

    public void Save(Invoice invoice)
    {
        Console.WriteLine("Saving invoice to PDF...");
    }
}