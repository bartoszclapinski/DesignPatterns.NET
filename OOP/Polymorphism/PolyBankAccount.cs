namespace DesignPatternsNET.OOP.Polymorphism;

public class PolyBankAccount
{
    protected float _balance;
    
    public void Deposit(float amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must be greater than 0");
        
        _balance += amount;
    }
    
    public virtual void Withdraw(float amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must be greater than 0");
        
        if (_balance < amount)
            throw new ArgumentException("Insufficient funds");
        
        _balance -= amount;
    }
    
    public float GetBalance()
    {
        return _balance;
    }
}