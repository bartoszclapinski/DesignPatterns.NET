namespace DesignPatternsNET.Behavioral.State;

public static class StateApp
{
    public static void Run()
    {
        var context = new Context();
        context.InsertCard();
        context.InsertPin(1234);
        context.WithdrawCash(1000);
        context.EjectCard();
    }
}