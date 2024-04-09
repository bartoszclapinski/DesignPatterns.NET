namespace DesignPatternsNET.SOLID.OpenClose;

public class WordInvoiceSaver : IInvoiceSaver
{

    public void Save(Invoice invoice)
    {
        Console.WriteLine("Saving invoice to Word...");
    }
}