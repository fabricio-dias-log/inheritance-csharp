using InheritanceTest.Entities;

namespace InheritanceTest;

class Program
{
    static void Main(string[] args)
    {
        BusinessAccount bAccount = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

        Console.WriteLine(bAccount.Balance);
        // bAccount.Balance = 100.00; dá erro por Balance ser protected e acessivel apenas pela subclasse
        bAccount.Deposit(100.00);
    }
}