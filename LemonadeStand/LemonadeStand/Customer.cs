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
        public Random random;

        public Customer()
        {
            name = "Customer";
            propensityToBuy = 0;
            didBuy = false;
            random = new Random();
        }
        public void GenerateCustomers(List<Customer> customers, int weatherFactor)
        {
            int customerCount = (weatherFactor * 10);
            for (int i = 0; i < customerCount; i++)
            {
                customers.Add(new Customer());
                propensityToBuy = random.Next(1, 7);
            }
        }
    }
}
