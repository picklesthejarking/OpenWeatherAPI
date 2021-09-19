using System;
using System.Collections.Generic;
using System.Text;

namespace PTJK.OpenWeatherAPI.Models
{
    public class City
    {
        public double id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public Collections.Coord coord { get; set; }
    }
}
