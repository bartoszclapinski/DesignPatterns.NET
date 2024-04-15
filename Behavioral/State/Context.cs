namespace DesignPatternsNET.Behavioral.State;

public class Context
{
    private State _state;
    public int AccountBalance { get; set; } = 2000;

    public Context()
    {
        _state = new NoCard(this);
    }
    
    public void SetState(State state)
    {
        _state = state;
    }
    
    public void InsertCard()
    {
        _state.InsertCard();
        
    }
    
    public void EjectCard()
    {
        _state.EjectCard();
    }
    
    public void InsertPin(int pin)
    {
        _state.InsertPin(pin);
    }
    
    public void WithdrawCash(int amount)
    {
        _state.WithdrawCash(amount);
    }
}