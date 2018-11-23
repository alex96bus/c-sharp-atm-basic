//Remove unused usingss
using System;

namespace SmartATM2
{
    //add access modifier to class
    internal class Program
    {
        //add access modifier to method
        internal static void Main(string[] args)
        {
            Account account = new Account();
            while (true)
            {
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Deposit balance");
                Console.WriteLine("3. Withdraw balance");
                Console.WriteLine("4. Change PIN");
                //You can create here a clear screen method (look into System.Console methods)
                //Also, exit function is not implemented (look into System methods)
                Console.WriteLine("5. Clear");
                Console.WriteLine("6. Exit");
                //Why not use TryParse?
                int menu;
                int.TryParse(Console.ReadLine(), out menu);
                // Why dont you create an instance of this account outside the menu? Before while
                switch (menu)
                {
                    //Why don't you separate variables from writeline statement
                    //Read about string interpolation
                    case 1:
                        Console.WriteLine($"Your current balance is {account.GetBalance()} ");
                        break;
                    case 2:
                        Console.WriteLine("How much would you like to deposit?");
                        account.AddBalance();
                        Console.WriteLine("Your balance is " + account.GetBalance());
                        break;
                    case 3:
                        Console.WriteLine("How much would you like to withdraw?");
                        account.Withdraw();
                        Console.WriteLine("Your balance is " + account.GetBalance());
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("You entered a wrong selection!");
                        break;
                }
            }
        } 
    }
}
