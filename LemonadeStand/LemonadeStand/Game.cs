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
        public Day day;
        public Game()
        {
            player = new Player();
            store = new Store();
        }

        public void RunGame()
        {
            SetUpGame();
            RunWeek();
            
            //End of Season goes here.
        }
        public void SetUpGame()
        {
            UserInterface.DisplayGameRules();
            player.SetName();
        }
        public void RunWeek()
        {
            for (int index = 1; index <= 7; index++)
            {
                day = new Day();
                day.SetUpDay(index);
                UserInterface.DisplayBeginningOfDayReport(player, day);
                store.VisitStore(player);
                UserInterface.DisplayRecipeReport(player, day);
                //Call method to change recipe for the day.
                if (player.inventory.CheckInventory(player.recipe) == true)
                {
                    continue;
                }
                else
                {
                    store.VisitStore(player);
                }
                Console.WriteLine($"We have:{day.customers.Count} today.");
                // what next?






            }
        }
    }
}
