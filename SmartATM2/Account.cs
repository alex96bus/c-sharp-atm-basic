//remove unused usings
using System;

namespace SmartATM2
{
    //To do: why is this class non-static, but the methods static?
    internal class Account
    {
        private decimal balance = 0;
        //To do: Delete unnecessary whitespaces + indent code (hotkey is CTRL+K, D) 
        internal void AddBalance()
        {
            balance += Convert.ToDecimal(Console.ReadLine());
        }

        //this method can either not return a value, and you set the result in the class
        //or you can create an instance of this class and remove static properties/methods
        //also rename this method to : Withdraw
        //for currencies always use : decimal (read on msdn)
        internal void Withdraw()
        {
            int withdraw = int.Parse(Console.ReadLine());
            if (withdraw > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            //why does the withdraw and balance have to be multiplies of 100 if values are decimal?
            else if (withdraw % 10 != 0)
            {
                Console.WriteLine("Please enter the amount in multiples of 10");
            }
            else
            {
                balance -= withdraw;
            }
            //To do: If withdraw is greater than balance you will always return a negative number
            //Suggestion: remove unneccesary write lines from here, it isn't the responsability of the account
            //to tell the user his balance
        }

        internal decimal GetBalance()
        {
            return balance;
        }
    }
}
