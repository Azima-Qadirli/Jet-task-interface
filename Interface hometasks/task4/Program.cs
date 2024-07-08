//Task 4: 
//1.Define an interface IAccount with the following properties and methods:
//double Balance { get; set; }
//void Deposit(double amount)
//void Withdraw(double amount)

//2.Create a class BankAccount that implements the IAccount interface.
//Implement the properties and methods defined in the IAccount interface in the BankAccount class.
//Add a constructor to initialize the Balance.

//3. In your Main method, create an instance of the BankAccount class.
//Test the Deposit and Withdraw methods by depositing and withdrawing various amounts and printing the balance after each operation.

//Set up a menu like this:
//1) Deposit Money
//2) Withdraw Money
//3) Exit menu 
//You can use loops(while,do while) and conditions (switch case , if else if)
using Interface_hometasks.task4;

static void Main(string[] args)
{
    BankAccount bankAccount = new BankAccount(1000);
    bool exit = false;
    while (!exit)
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1) Deposit Money");
        Console.WriteLine("2) Withdraw Money");
        Console.WriteLine("3) Exit menu ");
        Console.WriteLine("Enter your option:");

        int option;
        if (int.TryParse(Console.ReadLine(), out option))
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please, enter your amount of money to deposit:");
                    break;
                case 2:
                    Console.WriteLine("Please,enter your amount of money to withdraw:");
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Please, choose correct option:");
                    break;
            }
            Console.WriteLine("Thanks for choosing our bank!");
        }


    }
   


}


using System;
using System.Collections.Generic;

namespace Bank_Account_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();
            bool exit = false;

            while (!exit)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        OpenAccount(accounts);
                        break;
                    case "2":
                        InvestMoney(accounts);
                        break;
                    case "3":
                        WithdrawMoney(accounts);
                        break;
                    case "4":
                        ShowBalance(accounts);
                        break;
                    case "5":
                        ShowAccountActivity(accounts);
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1. Open an account");
            Console.WriteLine("2. Invest money");
            Console.WriteLine("3. Withdraw money");
            Console.WriteLine("4. Show balance");
            Console.WriteLine("5. Show account activity");
            Console.WriteLine("6. Exit");
            Console.Write("Please select an option: ");
        }

        private static void OpenAccount(Dictionary<string, BankAccount> accounts)
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            Console.Write("Enter owner name: ");
            string ownerName = Console.ReadLine();

            if (accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine("Account already exists.");
            }
            else
            {
                BankAccount newAccount = new BankAccount(ownerName, accountNumber);
                accounts.Add(accountNumber, newAccount);
                Console.WriteLine("Account created successfully.");
            }
        }

        private static void InvestMoney(Dictionary<string, BankAccount> accounts)
        {
            BankAccount account = GetAccount(accounts);
            if (account != null)
            {
                Console.Write("Enter amount to invest: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
                {
                    account.Deposit(amount);
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
            }
        }

        private static void WithdrawMoney(Dictionary<string, BankAccount> accounts)
        {
            BankAccount account = GetAccount(accounts);
            if (account != null)
            {
                Console.Write("Enter amount to withdraw: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
                {
                    account.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
            }
        }

        private static void ShowBalance(Dictionary<string, BankAccount> accounts)
        {
            BankAccount account = GetAccount(accounts);
            if (account != null)
            {
                Console.WriteLine($"Balance: {account.Balance:C}");
            }
        }

        private static void ShowAccountActivity(Dictionary<string, BankAccount> accounts)
        {
            BankAccount account = GetAccount(accounts);
            if (account != null)
            {
                // In this implementation, we don't have a specific activity log to show.
                // The activity log feature would need to be implemented in the BankAccount class.
                Console.WriteLine($"Owner: {account.OwnerName}, Account Number: {account.Number}, Balance: {account.Balance:C}");
            }
        }

        private static BankAccount GetAccount(Dictionary<string, BankAccount> accounts)
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            if (accounts.TryGetValue(accountNumber, out BankAccount account))
            {
                return account;
            }
            else
            {
                Console.WriteLine("Account not found.");
                return null;
            }
        }
    }
}
