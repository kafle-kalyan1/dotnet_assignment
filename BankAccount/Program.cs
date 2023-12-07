using System;

class BankAccount
{
    // Properties
    private string accountNumber;
    private decimal balance;

    // Constructor
    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0m; // Setting balance to 0 by default
    }

    // Method to deposit money
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: ${amount:N2}");
    }

    // Method to withdraw money
    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount:N2}");
        }
    }

    // Method to display the balance
    public void DisplayBalance()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Current Balance: ${balance:N2}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the BankAccount class
        BankAccount myAccount = new BankAccount("123456789");

        // Perform a deposit of 1000 units
        myAccount.Deposit(1000m);

        // Withdraw 500 units
        myAccount.Withdraw(500m);

        // Display the final balance
        myAccount.DisplayBalance();
    }
}
