using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartATM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Deposit balance");
            Console.WriteLine("3. Withdraw balance");
            Console.WriteLine("4. Change PIN");
            Console.WriteLine("5. Exit");

            int menu = int.Parse(Console.ReadLine());
            MainMenu(menu);
        }

        public static void MainMenu(int menu)
        {
            switch (menu)
            {
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
                    Console.WriteLine("Something went wrong, try again!");
                    break;
            }
        }
    }
}
