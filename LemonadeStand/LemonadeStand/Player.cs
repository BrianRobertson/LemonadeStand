using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        public Player()
        {
            name = "";
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        public void SetName()
        {
            Console.WriteLine("What is your player name?");
            name = Console.ReadLine();
        }
    }
}
