using System;

namespace SmartATM2
{
    internal class Account
    {
        private decimal balance = 0;
 
        internal void AddBalance()
        {
            balance += Convert.ToDecimal(Console.ReadLine());
        }

        internal void Withdraw()
        {
            int withdraw = int.Parse(Console.ReadLine());

            if (withdraw > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else if (withdraw % 10 != 0)
            {
                Console.WriteLine("Please enter the amount in multiples of 10");
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
