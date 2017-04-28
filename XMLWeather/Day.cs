using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, conditions, currentTime, location, tempHigh, tempLow, windSpeed, windDirection, precipitation,
            visibility;

        public Day()
        {
            date = currentTemp = currentTime = conditions = location = tempHigh = tempLow = windSpeed = windDirection
                = precipitation = visibility = "";

                 
        }
    }
}
