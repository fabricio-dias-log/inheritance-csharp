namespace InheritanceTest.Entities;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount()
    {
        
    }

    public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public override void Withdraw(double amount)
    {
        base.Withdraw(amount);
        Balance -= 2.00;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }
}