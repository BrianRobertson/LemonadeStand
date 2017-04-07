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
        public Customer customer;
        public Day()
        {
            //constructor.
            weather = new Weather();
// customers will happen in the generate customer method.            customer = new Customer();
        }

       public void SetUpDay(int value)
        {
            number = value;
            weather.SetWeather();
        }
    }
}
