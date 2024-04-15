namespace DesignPatternsNET.Behavioral.State;

public class CardInserted : State
{

    public CardInserted(Context context) : base(context)
    {
    }

    public override void InsertCard()
    {
        Console.WriteLine("Card already inserted.");
    }

    public override void EjectCard()
    {
        Console.WriteLine("Card ejected.");
        _context.SetState(new NoCard(_context));
    }

    public override void InsertPin(int pin)
    {
        if (pin == 1234)
        {
            Console.WriteLine("PIN entered correctly.");
            _context.SetState(new PinInserted(_context));
        }
        else
        {
            Console.WriteLine("PIN entered incorrectly.");
            Console.WriteLine("Card ejected.");
            _context.SetState(new NoCard(_context));
        }
    }

    public override void WithdrawCash(int amount)
    {
        Console.WriteLine("PIN not entered.");
    }
}