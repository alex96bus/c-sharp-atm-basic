using System;

namespace SmartATM2
{
    internal class Account
    {
        private string pin;
        private decimal balance = 0;
 
        internal void AddBalance()
        {
            decimal value;
            decimal.TryParse(Console.ReadLine(), out value);
            if (value > 0)
            {
                balance += value;
            }
            else
            {
                Console.WriteLine($"You cannot deposit {value} ammount!");
            }
        }

        internal void Withdraw()
        {
            int withdraw;
            int.TryParse(Console.ReadLine(), out withdraw);

            if (withdraw > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else if (withdraw % 10 != 0)
            {
                Console.WriteLine("Please enter the amount in multiples of 10");
            }
            else if (withdraw <= 0)
            {
                Console.WriteLine($"Cannot withdraw {withdraw}!");
            }
            else
            {
                balance -= withdraw;
            }
        }

        internal decimal GetBalance()
        {
            return balance;
        }
    }
}
