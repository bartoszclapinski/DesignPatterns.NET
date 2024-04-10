using DesignPatternsNET.Creational.Builder;

namespace DesignPatternsNET.Creational.Builder;

public static class InvoiceApp
{
    public static void Run()
    {
        var invoiceBuilder = new InvoiceBuilder();
        invoiceBuilder
            .setNumber("INV-001")
            .setVendor("Vendor")
            .setVendee("Vendee")
            .setDate(DateTime.Now)
            .setNote("This is an Invoice Note for Vendee from Vendor")
            .setLineItems(new List<string>
            {
                "Line item 1",
                "Line item 2",
                "Line item 3"
            });
        var invoice = invoiceBuilder.Build();
        
        Console.WriteLine($"Invoice: {invoice.Number} from {invoice.Vendor} to {invoice.Vendee} on {invoice.Date}");
        Console.WriteLine($"Note: {invoice.Note}");
        Console.WriteLine("Line items:");
        foreach (var lineItem in invoice.LineItems)
        {
            Console.WriteLine(lineItem);
        }
    }
}