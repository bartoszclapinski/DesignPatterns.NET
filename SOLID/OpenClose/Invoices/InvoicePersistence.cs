namespace DesignPatternsNET.SOLID.OpenClose;

public class InvoicePersistence
{
    private readonly Invoice _invoice;
    private readonly IInvoiceSaver _invoiceSaver;

    public InvoicePersistence(Invoice invoice, IInvoiceSaver invoiceSaver)
    {
        _invoice = invoice;
        _invoiceSaver = invoiceSaver;
    }

    public void Save()
    {
        _invoiceSaver.Save(_invoice);
    }
    
    
}