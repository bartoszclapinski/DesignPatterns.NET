namespace DesignPatternsNET.SOLID.OpenClose;

public class Invoice
{
    public IEnumerable<LineItems> LineItems { get; set; }
    public string Vendor { get; set; }
    public string Vendee { get; set; }
    public float Total { get; set; }

    public Invoice(IEnumerable<LineItems> lineItems, string vendor, string vendee)
    {
        LineItems = lineItems;
        Vendor = vendor;
        Vendee = vendee;
        Total = CalculateTotal();
    }

    private float CalculateTotal()
    {
        float total = 0;
        foreach (var lineItem in LineItems)
        {
            total += lineItem.Price * lineItem.Count * (1 + lineItem.TaxRate / 100);
        }
        
        return total;
    }
}