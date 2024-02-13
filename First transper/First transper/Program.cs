using System;

class Account
{
    private string accountName;
    private double balance;

    public Account(string accountName, double initialBalance)
    {
        this.accountName = accountName;
        this.balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public override string ToString()
    {
        return $"{accountName} balance: {balance:C}";
    }
}

class Program
{
    static void Main()
    {
        Account heikkisAccount = new Account("Heikki's account", 1000.0);
        Account personalAccount = new Account("Personal account", 0);

        heikkisAccount.Withdraw(100.0);
        personalAccount.Deposit(100.0);

        Console.WriteLine(heikkisAccount.ToString());
        Console.WriteLine(personalAccount.ToString());
    }
}
