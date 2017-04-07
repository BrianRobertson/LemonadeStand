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

        public void AddItems(string name, int value)
        {
            //add cups. needs to be generic. switch case to add to proper list.
            for (int i = 0; i < value; i++)
            {
                cups.Add(new Cup());
            }
        }
    }
}
