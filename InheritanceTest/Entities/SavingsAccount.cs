namespace InheritanceTest.Entities;

public sealed class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount()
    {
        
    }

    public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public sealed override void Withdraw(double amount) // sealed para selar metodos, só funciona se tiver override
    { // funciona para que nao seja reescrita novamente em outra classe
        base.Withdraw(amount);
        Balance -= 2.00;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }
}