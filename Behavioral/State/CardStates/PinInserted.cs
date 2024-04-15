namespace DesignPatternsNET.Behavioral.State;

public class PinInserted : State
{

    public PinInserted(Context context) : base(context)
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
        Console.WriteLine("PIN already entered.");
    }

    public override void WithdrawCash(int amount)
    {
        if (amount > 0 && amount <= _context.AccountBalance)
        {
            Console.WriteLine($"Withdrawing {amount}...");
            _context.AccountBalance -= amount;
            if (_context.AccountBalance == 0)
            {
                Console.WriteLine("No cash available.");
                _context.SetState(new NoCash(_context));
            }
            else
            {
                Console.WriteLine("Cash withdrawn.");
                Console.WriteLine($"New balance: {_context.AccountBalance}");
                Console.WriteLine("Card ejected.");
                _context.SetState(new NoCard(_context));
            }
        }
        else if (amount > _context.AccountBalance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Need to withdraw more than 0.");
        }
    }
}