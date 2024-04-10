namespace DesignPatternsNET.Creational.Builder;

public class InvoiceBuilder
{
    private Invoice _invoice = new ();

    
    public InvoiceBuilder setVendor(string vendor)
    {
        _invoice.Vendor = vendor;
        return this;
    }
    public InvoiceBuilder setVendee(string vendee) 
    {
        _invoice.Vendee = vendee;
        return this;
    }
    public InvoiceBuilder setNumber(string number) 
    {
        _invoice.Number = number;
        return this;
    }
    public InvoiceBuilder setNote(string note) 
    {
        _invoice.Note = note;
        return this;
    }
    public InvoiceBuilder setDate(DateTime date) 
    {
        _invoice.Date = date;
        return this;
    }
    public InvoiceBuilder setLineItems(IEnumerable<string> lineItems) 
    {
        _invoice.LineItems = lineItems;
        return this;
    }
    
    public Invoice Build() => _invoice;
}