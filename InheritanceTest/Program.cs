using System.Globalization;
using InheritanceTest.Entities;

namespace InheritanceTest;

class Program
{
    static void Main(string[] args)
    {
        /*BusinessAccount bAccount = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

        Console.WriteLine(bAccount.Balance);
        // bAccount.Balance = 100.00; dá erro por Balance ser protected e acessivel apenas pela subclasse
        bAccount.Deposit(100.00);
        
        Account account = new Account(1001, "Alex", 0.00);
        BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.00, 500.00);
        
        // Upcasting
        Account account1 = businessAccount; //Convertendo uma variável BusinessAccount em Account
        Account account2 = new BusinessAccount(1003, "Bob", 0.00, 200.00); // Instancia direta
        Account account3 = new SavingsAccount(1004, "Ana", 0.00, 0.01);
        
        //Downcasting - Somente quando necessário
        BusinessAccount bAccount2 = (BusinessAccount)account2; // Conversão da classe Account para subclasse BusinessAccount
        bAccount2.Loan(100.00);
        
        // BusinessAccount bAccount3 = (BusinessAccount)account3 {é do tipo SavingsAccount};
        // erro em tempo de execução onde não foi possivel conversão

        if (account3 is BusinessAccount) // dará falso já que é SavingsAccount
        {
            // BusinessAccount bAccount3 = (BusinessAccount)account3;
            BusinessAccount bAccount3 = account3 as BusinessAccount; // outra maneira de fazer casting
            bAccount3.Loan(200.00);
            Console.WriteLine("Loaned");
        }

        if (account3 is SavingsAccount)
        {
            SavingsAccount account4 = (SavingsAccount)account3;
            account4.UpdateBalance();
            Console.WriteLine("Balance Updated");
        }
        
        Account normalAccount = new Account(1001, "Alex", 500);
        Account normalAccount2 = new SavingsAccount(1002, "Ana", 500, 0.01);
        
        normalAccount.Withdraw(10.00);
        normalAccount2.Withdraw(10.00);

        Console.WriteLine(normalAccount.Balance);
        Console.WriteLine(normalAccount2.Balance);*/

        List<Account> accounts = new List<Account>();
        
        accounts.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
        accounts.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
        accounts.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
        accounts.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));

        double sum = 0;

        foreach (Account acc in accounts)
        {
            sum += acc.Balance;
        }

        Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

        foreach (Account acc in accounts)
        {
            acc.Withdraw(10);
        }

        foreach (var acc in accounts)
        {
            Console.WriteLine($"Updated Balance for account {acc.Number}: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}