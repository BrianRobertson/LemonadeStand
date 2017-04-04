using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        string name;
        Inventory inventory;
        Wallet wallet;
        Recipe recipe;

        public Player()
        {
            Inventory inventory = new Inventory();
            Wallet wallet = new Wallet();
            Recipe recipe = new Recipe();
        }

        public string SetName()
        {
            Console.WriteLine("What is your player name?");
            name = Console.ReadLine();
            return name;
        }
    }
}
