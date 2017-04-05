using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double amount;
        public Wallet()
        {
            amount = 20.00;
        }
        public bool ValidateSufficientFunds(double costs)
        {
            bool sufficientFunds = true;
            if (costs > amount)
                sufficientFunds = false;
            return sufficientFunds;
        }
        public void AddSalesToWallet(double sales)
        {
            amount = amount + sales;
//            Console.WriteLine(amount);
//            Console.ReadKey();
        }
        public void RemoveCostsFromWallet(double costs)
        {
            amount = amount - costs;
//            Console.WriteLine(amount);
//            Console.ReadKey();
        }
    }
}
