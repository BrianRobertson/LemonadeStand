using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void MainMenu(Player player)
        {
            Console.WriteLine(player.name + ", this is the main menu."
         + "\n1. New Game"
         + "\n2. Resume Game"
         + "\n3. Save Game"
         + "\n4. End Game");
            string input = Console.ReadLine().ToLower().Trim();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Test option.\n");
                    break;
                case "2":
                    Console.WriteLine("Test option.\n");
                    break;
                case "3":
                    Console.WriteLine("Test option.\n");
                    break;
                case "4":
                    Console.WriteLine("End game?\n");
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    MainMenu(player);
                    break;
            }
        }

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
        public static void InventoryUpdateReport(Player player)//day removed for now.
        {
            Console.WriteLine("Inventory update."
//                + $"\n Hello {player.name}, here is your report for Day: {day.number}"
//                + $"\n Today's forecast is: {day.weather.report}"
                + $"\n Your current wallet balance is: ${player.wallet.balance}."
                + $"\n Your current inventory is: cups: {player.inventory.cups.Count}, lemons: {player.inventory.lemons.Count}, sugar: {player.inventory.cupsOfSugar.Count}, ice: {player.inventory.iceCubes.Count}."
                + " \n");
        }
    }
}
