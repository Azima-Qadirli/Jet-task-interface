using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hometasks.task4
{
    public class BankAccount : IAccount
    {
        public double Balance { get; set; }
        public BankAccount(double balance)
        {
            this.Balance = balance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {

                Balance += amount;
                Console.WriteLine($"Your deposit: {amount}. New Balance: {Balance}" );
            }
            else
            {
                Console.WriteLine("Your entered amount must be postive integer.");
            }
        }

        public void WithDraw(double amount)
        {
            if(amount > 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw: {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Your entered amount must be postive integer.");
            }
        }
    }
}
