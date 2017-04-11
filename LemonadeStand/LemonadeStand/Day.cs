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
        public Random random;
        public int customersToday;
        public Day()
        {
            //constructor.
            weather = new Weather();
            customers = new List <Customer>();
            random = new Random();
        }

       public void SetUpDay(int dayOfWeek)
        {
            number = dayOfWeek;
            weather.SetWeather();
            GenerateCustomers(weather.factor);
        }
        public void RunDay(Player player)
        {
            //?
        }
        public void GenerateCustomers(int weatherFactor)
        {
            int customerCount = (weatherFactor * 10);
            for (int i = 0; i < customerCount; i++)
            {
                int personality = random.Next(1, 7);
                customers.Add(new Customer(personality));
            }
        }




    }
}
