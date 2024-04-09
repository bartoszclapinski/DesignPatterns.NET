namespace DesignPatternsNET.SOLID.SingleResponsibility;

public class InvoicePersistence
{
    private readonly Invoice _invoice;

    public InvoicePersistence(Invoice invoice)
    {
        _invoice = invoice;
    }

    public void SaveToPdf()
    {
        Console.WriteLine("Saving invoice to PDF...");
    }
}