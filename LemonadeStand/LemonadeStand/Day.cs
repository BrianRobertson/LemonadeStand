using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public int number;
        public Weather weather;
        public List<Customer> customers;
        public Day()
        {
            //constructor.
            weather = new Weather();
            customers = new List <Customer>();

            // customers will happen in the generate customer method.            customer = new Customer();
        }

       public void SetUpDay(int dayOfWeek)
        {
            number = dayOfWeek;
            int weatherFactorweather = SetWeather();
            Customer.GenerateCustomers(customers, weather.factor);
        }
        public void RunDay(Player player)
        {

        }
    }
}
