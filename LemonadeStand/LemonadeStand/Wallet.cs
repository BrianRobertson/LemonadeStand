using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double balance;

        public Wallet()
        {
            balance = 20.00;
        }
        public bool ValidateSufficientFunds(double costs)
        {
            bool sufficientFunds = true;
            if (costs > balance)
                sufficientFunds = false;
            return sufficientFunds;
        }
        public void AddSalesToWallet(double sales)
        {
            balance = balance + sales;
//            Console.WriteLine(amount);
//            Console.ReadKey();
        }
        public void RemoveCostsFromWallet(double costs)
        {
            balance = balance - costs;
//            Console.WriteLine(amount);
//            Console.ReadKey();
        }
    }
}
