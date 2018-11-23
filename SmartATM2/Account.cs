using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartATM2
{
    public class Account
    {
       public static double DefaultBalance = 0;
        

        public static double AddBalance()
        {
            double newBalance = DefaultBalance + Convert.ToDouble(Console.ReadLine());
            return newBalance;
        }

        public static double WithDraw()
        {          
            int withdraw = int.Parse(Console.ReadLine());
            double result = DefaultBalance - withdraw;
            if (withdraw > DefaultBalance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else if(withdraw % 100 != 0)
            {
                Console.WriteLine("Please enter the amount in multiples of 100");
            }
            else
            {
                result = DefaultBalance - withdraw;
                Console.WriteLine("Your new balance is " + result);
            }
            return result;
        }

        
    }
}
