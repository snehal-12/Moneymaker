using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A bronze coin is worth 1 cent
        A silver coin is worth 5 cents
        A gold coin is worth 10 cents*/
            Console.WriteLine("Welcome to Money Maker!");
            //Promt user to enter the amount
            Console.WriteLine("Enter the amount to convert to     coins");
            string amount = Console.ReadLine();
            //Round down the amount to nearest integer
            double amountTotal = Math.Floor(Convert.ToDouble(amount));
            Console.WriteLine($"{amount}cents is equal to...");

            int gold = 10;
            int silver = 5;
            //Max number of gold coins that fit in the amount
            double goldCoins = Math.Floor(amountTotal / gold);
            double amountLeft = amountTotal % gold;
            //Max number of silver coins that fit in the amount
            double silverCoins = Math.Floor(amountLeft / silver);
            double remainder = amountLeft % silver;
            //Print all the coins
            Console.WriteLine($"Gold coins:{goldCoins}");
            Console.WriteLine($"Silver coins:{silverCoins}");
            Console.WriteLine($"Bronze coins:{remainder}");

            Console.ReadLine();

        }
    }
}
