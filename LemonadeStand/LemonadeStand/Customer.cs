using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public string name;
        public int propensityToBuy;
        public bool didBuy;

        public Customer()
        {
            name = "customer";
            propensityToBuy = 0;
            didBuy = false;
        }
        public void SetPropensityToBuy(int value)
        {
            propensityToBuy = value;
        }
    }
}
