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