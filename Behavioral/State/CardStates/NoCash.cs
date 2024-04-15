namespace DesignPatternsNET.Behavioral.State;

public class NoCash : State
{

    public NoCash(Context context) : base(context)
    {
    }

    public override void InsertCard()
    {
        Console.WriteLine("No cash available.");
    }

    public override void EjectCard()
    {
        Console.WriteLine("No cash available.");
    }

    public override void InsertPin(int pin)
    {
        Console.WriteLine("No cash available.");
    }

    public override void WithdrawCash(int amount)
    {
        Console.WriteLine("No cash available.");
    }
}