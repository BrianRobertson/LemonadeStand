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
        public string cups;
        public int cupPackageQty;
        public double cupPackagePrice;
        public string lemons;
        public int lemonPackageQty;
        public double lemonPackagePrice;
        public string sugar;
        public int sugarPackageQty;
        public double sugarPackagePrice;
        public string ice;
        public int icePackageQty;
        public double icePackagePrice;

        public Store()
        {
            //constructor.
            cups = "Cups";
            cupPackageQty = 25;
            cupPackagePrice = 0.75;
            lemons = "Lemons";
            lemonPackageQty = 10;
            lemonPackagePrice = 1.00;
            sugar = "Sugar";
            sugarPackageQty = 8;
            sugarPackagePrice = 0.80;
            ice = "Ice";
            icePackageQty = 100;
            icePackagePrice = 0.75;
        }
        public void VisitStore(Player player)
        {
            Console.WriteLine(player.name + ", do you want to stock up on anything?"
         + "\n1. Cups"
         + "\n2. Lemons"
         + "\n3. Sugar"
         + "\n4. Ice"
         + "\n5. No, I am ready to make and sell lemonade."
         + "\n6. Go to main menu.");
            string input = Console.ReadLine().ToLower().Trim();
            switch (input)
            {
                case "1":
                    ShopItems(player, cups, cupPackageQty, cupPackagePrice);
                    break;
                case "2":
                    ShopItems(player, lemons, lemonPackageQty, lemonPackagePrice);
                    break;
                case "3":
                    ShopItems(player, sugar, sugarPackageQty, sugarPackagePrice);
                    break;
                case "4":
                    ShopItems(player, ice, icePackageQty, icePackagePrice);
                    break;
                case "5":
                    Console.WriteLine("Ready to make and sell lemonade.\n");
//                  Go back to game.
                    break;
                case "6":
                    Console.WriteLine("Go to Main Menu.\n");
                    UserInterface.MainMenu(player);
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    VisitStore(player);
                    break;
            }
        }
        public void ShopItems(Player player, string itemName, int qty, double price)
        {
            Console.WriteLine("Welcome to shopping.\n"
            + $"{itemName } comes in packages of {qty} at {price}; "
            + "\n1. Yes"
            + "\n2. No");
            string input = Console.ReadLine().ToLower().Trim();
            switch (input)
            {
                case "1":
                    PurchaseItem(player, itemName, qty, price);
                    break;
                case "2":
                    VisitStore(player);
                    break;
                case "3":
                    Console.WriteLine("Go to Main Menu.\n");
                    UserInterface.MainMenu(player);
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    ShopItems(player, itemName, qty, price);
                    break;
            }
        }
        public void PurchaseItem(Player player, string itemName, int qty, double price)
        {
            bool enoughMoney = player.wallet.CheckWallet(price);
            {
                if (enoughMoney == true)
                {
                    player.wallet.SubtractFromWallet(price);
                    player.inventory.AddItems(itemName, qty);
                    UserInterface.InventoryUpdateReport(player);
                    VisitStore(player);
                }
                else
                {
                    Console.WriteLine("Insufficient funds to make this particulair purchase.");
                    VisitStore(player);
                }
            }
        }
    }
}
