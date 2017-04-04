using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player1 = new Player();
        Day day = new Day();
        Store store = new Store();

        public void RunGame()
        {
        SetUpGame();
        }

        public void SetUpGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand! Instructions go here.");
            player1.SetName();
        }

    }
}
