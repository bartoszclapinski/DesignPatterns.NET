namespace DesignPatternsNET.OOP.Inheritance;

public class BaseBankAccount
{
    private float _balance;
    public string Owner { get; set; }
    
    public void Deposit(float amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must be greater than 0");
        
        _balance += amount;
    }
    
    public void Withdraw(float amount)
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