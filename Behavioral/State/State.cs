namespace DesignPatternsNET.Behavioral.State;

public abstract class State
{
    protected Context _context;
    public abstract void InsertCard();
    public abstract void EjectCard();
    public abstract void InsertPin(int pin);
    public abstract void WithdrawCash(int amount);

    protected State(Context context)
    {
        _context = context;
    }
}