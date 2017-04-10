using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Cup> cups;
        public List<Lemon> lemons;
        public List<Sugar> cupsOfSugar;
        public List<Ice> iceCubes;
        public Inventory()
        {
            cups = new List<Cup>();
            lemons = new List<Lemon>();
            cupsOfSugar = new List<Sugar>();
            iceCubes = new List<Ice>();
        }
        public void AddItems(string itemName, int qty)
        {
            switch (itemName)
            {
                case "Cups":
                    AddCups(qty);
                    break;
                case "Lemons": 
                    AddLemons(qty);
                    break;
                case "Sugar":
                    AddSugar(qty);
                    break;
                case "Ice":
                    AddIce(qty);
                    break;
                default: 
                    break;
            }
        }
        public void AddCups(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                cups.Add(new Cup());
            }
        }
        public void AddLemons(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                lemons.Add(new Lemon());
            }
        }
        public void AddSugar(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                cupsOfSugar.Add(new Sugar());
            }
        }
        public void AddIce(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                iceCubes.Add(new Ice());
            }
        }
        public bool CheckInventory(Recipe recipe)
        {
            if (cups.Count >= recipe.cupsOfLemonadePerPitcher && lemons.Count >= recipe.lemonsPerPitcher 
                && cupsOfSugar.Count >= recipe.cupsOfSugarPerPitcher 
                && iceCubes.Count >= (recipe.iceCubesPerCup * recipe.cupsOfLemonadePerPitcher))
            {
                Console.WriteLine("Enough inventory to make lemonade");
                return true;
            }
            else {
                Console.WriteLine("Not enough inventory to make lemonade");
                return false;          }
        }
    }
}
