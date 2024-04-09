namespace DesignPatternsNET.OOP.Inheritance;

public class PersonalBankAccount : BaseBankAccount
{
    public void RequestLoan(float amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must be greater than 0");

        if (amount > 1000)
            throw new ArgumentException("Amount must be less than 1000");

        Deposit(amount);
    }
}