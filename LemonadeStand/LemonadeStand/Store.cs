using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        //member variables.
        public Store()
        {
            //constructor
        }
        public void VisitStore(Player player)
        {
            Console.WriteLine(player.name + ", do you want to stock up on anything?"
         + "\n1. Cups"
         + "\n2. Lemons"
         + "\n3. Sugar"
         + "\n4. Ice");
            string input = Console.ReadLine().ToLower().Trim();
            switch (input)
            {
                case "1":
                    ShopCups();
                    break;
                case "2":
                    Console.WriteLine("Test option.\n");
                    break;
                case "3":
                    Console.WriteLine("Test option.\n");
                    break;
                case "4":
                    Console.WriteLine("Test option.\n");
                    break;
                case "5":
                    Console.WriteLine("Go to Main Menu.\n");
                    UserInterface.MainMenu(player);
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    VisitStore(player);
                    break;
            }
        }

        public void ShopCups()
        {
            Console.WriteLine("Welcome to cup shopping.\n");

        }
    }
}
