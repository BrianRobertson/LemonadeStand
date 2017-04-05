using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Player player;
        public Store store;
        public Game()
        {
            player = new Player();
            store = new Store();
        }

        public void RunGame()
        {
            SetUpGame();
        //    List<Day> daysOfTheWeek = new List<Day>();
        //for (int index = 0; index <= 7; index++)
        //{

 //       Day.SetUpDay();
        }
        // End of Season?

        public void SetUpGame()
        {
            UserInterface.DisplayGameRules();
            player.SetName();
        }
    }
}
