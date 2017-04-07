using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int factor;
        public string report;
        public Weather()
        {
            factor = 0;
            report = "Weather not yet forcasted.";
        }
        public void SetWeather()
        {
            factor = GetWeatherFactor();
            report = GetWeatherReport(factor);
        }
        public int GetWeatherFactor()
        {
            Random random = new Random();
            factor = random.Next(1, 7);
            return factor;
        }
        public string GetWeatherReport(int factor)
        {
            switch (factor)
            {
                case 1:
                    report = "Weather report 1 goes here.";
                    return report;
                case 2:
                    report = "Weather report 2 goes here.";
                    return report;
                case 3:
                    report = "Weather report 3 goes here.";
                    return report;
                case 4:
                    report = "Weather report 4 goes here.";
                    return report;
                case 5:
                    report = "Weather report 5 goes here.";
                    return report;
                case 6:
                    report = "Weather report 6 goes here.";
                    return report;
                case 7:
                    report = "Weather report 7 goes here.";
                    return report;
                default:
                    return "No Weather.";
            }
        }
    }
}
