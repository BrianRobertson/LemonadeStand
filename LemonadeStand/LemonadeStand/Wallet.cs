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
        public bool CheckWallet(double amount)
        {
            if (balance - amount >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddToWallet(double amount)
        {
            balance += amount;
        }
        public void SubtractFromWallet(double amount)
        {
            balance -= amount;
        }
    }
}
