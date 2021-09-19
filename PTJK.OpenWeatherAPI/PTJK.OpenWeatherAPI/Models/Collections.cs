using System;
using System.Collections.Generic;
using System.Text;

namespace PTJK.OpenWeatherAPI.Models
{
    public class Collections
    {
        public class Coord
        {
            /// <summary>
            /// City geo location, longitude
            /// </summary>
            public double lon { get; set; }
            /// <summary>
            /// City geo location, latitude
            /// </summary>
            public double lat { get; set; }
        }

        public class SysPod
        {
            /// <summary>
            /// Part of the day (n - night, d - day)
            /// </summary>
            public string pod { get; set; }
        }

        public class Weather
        {
            /// <summary>
            /// Weather condition id
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// Group of weather parameters (Rain, Snow, Extreme etc.)
            /// </summary>
            public string main { get; set; }
            /// <summary>
            /// Weather condition within the group. You can get the output in your language. Learn more
            /// </summary>
            public string description { get; set; }
            /// <summary>
            /// Weather icon id
            /// </summary>
            public string icon { get; set; }
        }

        public class Main
        {
            /// <summary>
            /// Temperature. Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
            /// </summary>
            public double temp { get; set; }
            /// <summary>
            /// Temperature. This temperature parameter accounts for the human perception of weather. Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
            /// </summary>
            public double feels_like { get; set; }
            /// <summary>
            /// Minimum temperature at the moment. This is minimal currently observed temperature (within large megalopolises and urban areas). Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
            /// </summary>
            public double temp_min { get; set; }
            /// <summary>
            /// Maximum temperature at the moment. This is maximal currently observed temperature (within large megalopolises and urban areas). Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
            /// </summary>
            public double temp_max { get; set; }
            /// <summary>
            /// Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data), hPa
            /// </summary>
            public int pressure { get; set; }
            /// <summary>
            ///  Atmospheric pressure on the sea level, hPa
            /// </summary>
            public int sea_level { get; set; }
            /// <summary>
            /// Atmospheric pressure on the ground level, hPa
            /// </summary>
            public int grnd_level { get; set; }
            /// <summary>
            /// Internal parameter
            /// </summary>
            public int temp_kf { get; set; }
            /// <summary>
            /// Humidity, %
            /// </summary>
            public int humidity { get; set; }
        }

        public class Wind
        {
            /// <summary>
            /// Wind speed. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.
            /// </summary>
            public double speed { get; set; }
            /// <summary>
            /// Wind direction, degrees (meteorological)
            /// </summary>
            public int deg { get; set; }
            /// <summary>
            /// Wind gust. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
            /// </summary>
            public double gust { get; set; }
        }

        public class Rain
        {
            /// <summary>
            /// Rain volume for the last 1 hour, mm
            /// </summary>
            public double _1h { get; set; }
            /// <summary>
            /// Rain volume for the last 3 hours, mm
            /// </summary>
            public double _3h { get; set; }
        }

        public class Snow
        {
            /// <summary>
            /// Snow volume for the last 1 hour, mm
            /// </summary>
            public double _1h { get; set; }
            /// <summary>
            /// Snow volume for the last 3 hours, mm
            /// </summary>
            public double _3h { get; set; }
        }

        public class Clouds
        {
            /// <summary>
            /// Cloudiness, %
            /// </summary>
            public int all { get; set; }
        }

        public class Sys
        {
            /// <summary>
            /// Internal parameter
            /// </summary>
            public int type { get; set; }
            /// <summary>
            /// Internal parameter
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// Internal parameter
            /// </summary>
            public double message { get; set; }
            /// <summary>
            /// Country code (GB, JP etc.)
            /// </summary>
            public string country { get; set; }
            /// <summary>
            /// Sunrise time, unix, UTC
            /// </summary>
            public int sunrise { get; set; }
            /// <summary>
            /// Sunset time, unix, UTC
            /// </summary>
            public int sunset { get; set; }
        }
    }
}
