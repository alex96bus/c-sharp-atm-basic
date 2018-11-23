//Remove unused usingss
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartATM2
{
    //add access modifier to class
    class Program
    {
        //add access modifier to method
        static void Main(string[] args)
        {
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Deposit balance");
            Console.WriteLine("3. Withdraw balance");
            Console.WriteLine("4. Change PIN");
            //You can create here a clear screen method (look into System.Console methods)
            //Also, exit function is not implemented (look into System methods)
            Console.WriteLine("5. Exit");

            //Why not use TryParse?
            int menu = int.Parse(Console.ReadLine());
            MainMenu(menu);
        }

        public static void MainMenu(int menu)
        {
            // Why dont you create an instance of this account outside the menu? Before while
            switch (menu)
            {
                //Why don't you separate variables from writeline statement
                //Read about string interpolation
                case 1:
                    Console.WriteLine("Your current balance is " + Account.DefaultBalance);
                    break;
                case 2:
                    Console.WriteLine("How much would you like to deposit?");
                    Console.WriteLine("Your new balance is " + Account.AddBalance());
                    break;
                case 3:
                    Console.WriteLine("How much would you like to withdraw?");
                    Console.WriteLine("Your new balance is ", Account.WithDraw());
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    //You can be more explicit here, you can tell the user he entered a wrong number
                    //And show him what to enter
                    Console.WriteLine("Something went wrong, try again!");
                    break;
            }
        }
    }
}
