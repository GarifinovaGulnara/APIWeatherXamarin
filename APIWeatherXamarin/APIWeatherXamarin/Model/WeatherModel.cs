using System;
using System.Collections.Generic;
using System.Text;

namespace APIWeatherXamarin.Model
{
    public class WeatherModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Temp { get; set; }
        public int GTemp { get; set; }
        public string Wind { get; set; }
        public double WindDirection { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
    }
}
