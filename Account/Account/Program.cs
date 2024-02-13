using System;

class Account
{
    public string accountName;
    public double balance;

    public Account(string accountName, double balance)
    {
        this.accountName = accountName;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            this.balance += amount;
        }
    }

    public void Withdrawal(double amount)
    {
        if (amount > 0 && this.balance >= amount)
        {
            this.balance -= amount;
        }
    }

    public override string ToString()
    {
        return $"{this.accountName}: {this.balance:C}";
    }
}

class Program
{
    static void Main()
    {
        Account heikkisAccount = new Account("Heikki's account", 100.00);
        Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

        Console.WriteLine("Initial state");
        Console.WriteLine(heikkisAccount);
       // Console.WriteLine(heikkisSwissAccount);

        heikkisAccount.Deposit(20.0);

       // Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance.ToString("C"));

        Console.WriteLine("End state");
        Console.WriteLine(heikkisAccount);
        //Console.WriteLine(heikkisSwissAccount);
    }
}
