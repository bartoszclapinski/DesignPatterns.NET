namespace DesignPatternsNET.OOP.Polymorphism;

public class PolyCompanyBankAccount : PolyBankAccount
{
    public void RequestLoan(float amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must be greater than 0");

        if (amount > 10000)
            throw new ArgumentException("Amount must be less than 10000");

        Deposit(amount);
    }

    public override void Withdraw(float amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must be greater than 0");
        
        _balance -= amount;
    }
}