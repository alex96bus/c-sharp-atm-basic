//remove unused usings
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartATM2
{
    //To do: why is this class non-static, but the methods static?
    public class Account
    {
       public static double DefaultBalance = 0;
       //To do: Delete unnecessary whitespaces + indent code (hotkey is CTRL+K, D) 

        public static double AddBalance()
        {
            double newBalance = DefaultBalance + Convert.ToDouble(Console.ReadLine());
            return newBalance;
        }

        //this method can either not return a value, and you set the result in the class
        //or you can create an instance of this class and remove static properties/methods
        //also rename this method to : Withdraw
        //for currencies always use : decimal (read on msdn)
        public static double WithDraw()
        {          
            int withdraw = int.Parse(Console.ReadLine());
            double result = DefaultBalance - withdraw;
            if (withdraw > DefaultBalance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            //why does the withdraw and balance have to be multiplies of 100 if values are double?
            else if(withdraw % 100 != 0)
            {
                Console.WriteLine("Please enter the amount in multiples of 100");
            }
            else
            {
                result = DefaultBalance - withdraw;
                Console.WriteLine("Your new balance is " + result);
            }
            //To do: If withdraw is greater than balance you will always return a negative number
            //Suggestion: remove unneccesary write lines from here, it isn't the responsability of the account
            //to tell the user his balance
            return result;
        }

        
    }
}
