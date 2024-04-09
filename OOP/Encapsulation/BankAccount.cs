namespace DesignPatternsNET.OOP.Encapsulation;

public class BankAccount
{
    private float _balance = 0;
    public string Owner { get; set; }
    
    public BankAccount(string owner)
    {
        Owner = owner;
    }
    
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