using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void DisplayGameRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand! Rules go here.");
        }

        public static void DisplayBeginningOfDayReport(Player player, Day day)
        {
            Console.WriteLine("Beginning of day report."
                + $"\n Hello {player.name}, here is your report for Day: {day.number}"
                + $"\n Today's forecast is: {day.weather.report}"
                + $"\n Your current wallet balance is: ${player.wallet.balance}."
                + $"\n Your current inventory is: cups: {player.inventory.cups.Count}, lemons: {player.inventory.lemons.Count}, sugar: {player.inventory.cupsOfSugar.Count}, ice: {player.inventory.iceCubes.Count}."
                + " \n");
        }
    }
}
