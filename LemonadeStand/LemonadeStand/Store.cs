using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        //member varibles.
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
            string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "1":
            //        choice = 1;
            //        break;
            //    case "2":
            //        choice = 1;
            //        displayChoice = "Paper";
            //        break;
            //    case "3":
            //        choice = 2;
            //        displayChoice = "Scissors";
            //        break;
            //    case "4":
            //        choice = 3;
            //        displayChoice = "Spock";
            //        break;
            //    case "5":
            //        choice = 4;
            //        displayChoice = "Lizard";
            //        break;
            //    default:
            //        Console.WriteLine("Not a valid choice.\n");
            //        GetInput();
            //        break;
            //}
        }
    }
}
