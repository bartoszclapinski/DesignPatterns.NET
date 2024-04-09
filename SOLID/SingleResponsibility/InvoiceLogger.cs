namespace DesignPatternsNET.SOLID.SingleResponsibility;

public class InvoiceLogger
{
    private readonly Invoice _invoice;
    
    public InvoiceLogger(Invoice invoice)
    {
        _invoice = invoice;
    }
    
    public void LogInvoice()
    {
        Console.WriteLine($"Invoice for {_invoice.Vendee} from {_invoice.Vendor} with total {_invoice.Total}...");
    }
}