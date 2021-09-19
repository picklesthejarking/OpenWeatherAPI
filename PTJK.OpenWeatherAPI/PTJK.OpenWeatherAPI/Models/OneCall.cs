using System;
using System.Collections.Generic;
using System.Text;
using static PTJK.OpenWeatherAPI.Models.Collections;

namespace PTJK.OpenWeatherAPI.Models
{
    public class OneCall
    {
        /// <summary>
        /// Geographical coordinates of the location (latitude)
        /// </summary>
        public double lat { get; set; }
        /// <summary>
        /// Geographical coordinates of the location (longitude)
        /// </summary>
        public double lon { get; set; }
        /// <summary>
        /// Timezone name for the requested location
        /// </summary>
        public string timezone { get; set; }
        /// <summary>
        /// Shift in seconds from UTC
        /// </summary>
        public int timezone_offset { get; set; }
        /// <summary>
        /// Current weather data API response
        /// </summary>
        public OneCallCurrent current { get; set; }
        /// <summary>
        /// Minute forecast weather data API response
        /// </summary>
        public List<Minutely> minutely { get; set; }
        /// <summary>
        /// Hourly forecast weather data API response
        /// </summary>
        public List<Hourly> hourly { get; set; }
        /// <summary>
        ///  Daily forecast weather data API response
        /// </summary>
        public List<Daily> daily { get; set; }
        /// <summary>
        /// National weather alerts data from major national weather warning systems
        /// </summary>
        public List<Alert> alerts { get; set; }

        public class Minutely
        {
            /// <summary>
            /// Time of the forecasted data, unix, UTC
            /// </summary>
            public int dt { get; set; }
            /// <summary>
            /// Precipitation volume, mm
            /// </summary>
            public double precipitation { get; set; }
        }

        public class Hourly
        {
            /// <summary>
            /// Time of the forecasted data, Unix, UTC
            /// </summary>
            public int dt { get; set; }
            /// <summary>
            /// Temperature. Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public double temp { get; set; }
            /// <summary>
            /// Temperature. This accounts for the human perception of weather. Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public double feels_like { get; set; }
            /// <summary>
            /// Atmospheric pressure on the sea level, hPa
            /// </summary>
            public int pressure { get; set; }
            /// <summary>
            /// Humidity, %
            /// </summary>
            public int humidity { get; set; }
            /// <summary>
            /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form. Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public double dew_point { get; set; }
            /// <summary>
            /// UV index
            /// </summary>
            public double uvi { get; set; }
            /// <summary>
            /// Cloudiness, %
            /// </summary>
            public int clouds { get; set; }
            /// <summary>
            /// Average visibility, metres
            /// </summary>
            public int visibility { get; set; }
            /// <summary>
            /// Wind speed. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
            /// </summary>
            public double wind_speed { get; set; }
            /// <summary>
            /// Wind direction, degrees (meteorological)
            /// </summary>
            public int wind_deg { get; set; }
            /// <summary>
            /// (where available) Wind gust. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
            /// </summary>
            public double wind_gust { get; set; }
            public List<Weather> weather { get; set; }
            /// <summary>
            /// Probability of precipitation
            /// </summary>
            public int pop { get; set; }

            public Rain rain { get; set; }
            public Snow snow { get; set; }
        }

        public class Daily
        {
            /// <summary>
            /// Time of the forecasted data, Unix, UTC
            /// </summary>
            public int dt { get; set; }
            /// <summary>
            /// Sunrise time, Unix, UTC
            /// </summary>
            public int sunrise { get; set; }
            /// <summary>
            /// Sunset time, Unix, UTC
            /// </summary>
            public int sunset { get; set; }
            /// <summary>
            /// The time of when the moon rises for this day, Unix, UTC
            /// </summary>
            public int moonrise { get; set; }
            /// <summary>
            ///  The time of when the moon sets for this day, Unix, UTC
            /// </summary>
            public double moonset { get; set; }
            /// <summary>
            ///  Moon phase. 0 and 1 are 'new moon', 0.25 is 'first quarter moon', 0.5 is 'full moon' and 0.75 is 'last quarter moon'. The periods in between are called 'waxing crescent', 'waxing gibous', 'waning gibous', and 'waning crescent', respectively.
            /// </summary>
            public double moon_phase { get; set; }
            /// <summary>
            /// Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public Temp temp { get; set; }
            /// <summary>
            /// This accounts for the human perception of weather. Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public FeelsLike feels_like { get; set; }
            /// <summary>
            /// Atmospheric pressure on the sea level, hPa
            /// </summary>
            public int pressure { get; set; }
            /// <summary>
            /// Humidity, %
            /// </summary>
            public int humidity { get; set; }
            /// <summary>
            /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form. Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public double dew_point { get; set; }
            /// <summary>
            /// Wind speed. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
            /// </summary>
            public double wind_speed { get; set; }
            /// <summary>
            /// Wind direction, degrees (meteorological)
            /// </summary>
            public int wind_deg { get; set; }
            public List<Weather> weather { get; set; }
            /// <summary>
            /// Cloudiness, %
            /// </summary>
            public int clouds { get; set; }
            /// <summary>
            /// Probability of precipitation
            /// </summary>
            public double pop { get; set; }
            /// <summary>
            /// Precipitation volume, mm
            /// </summary>
            public double rain { get; set; }
            /// <summary>
            /// Snow volume, mm
            /// </summary>
            public double snow { get; set; }
            /// <summary>
            /// The maximum value of UV index for the day
            /// </summary>
            public double uvi { get; set; }
        }

        public class Alert
        {
            /// <summary>
            /// Name of the alert source. Please read here the
            /// </summary>
            public string sender_name { get; set; }
            /// <summary>
            /// Alert event name
            /// </summary>
            public string @event { get; set; }
            /// <summary>
            /// Date and time of the start of the alert, Unix, UTC
            /// </summary>
            public int start { get; set; }
            /// <summary>
            /// Date and time of the end of the alert, Unix, UTC
            /// </summary>
            public int end { get; set; }
            /// <summary>
            /// Description of the alert
            /// </summary>
            public string description { get; set; }
            /// <summary>
            /// Type of severe weather
            /// </summary>
            public List<string> tags { get; set; }
        }

        public class Temp
        {
            /// <summary>
            /// Day temperature.
            /// </summary>
            public double day { get; set; }
            /// <summary>
            /// Min daily temperature.
            /// </summary>
            public double min { get; set; }
            /// <summary>
            /// Max daily temperature.
            /// </summary>
            public double max { get; set; }
            /// <summary>
            /// Night temperature.
            /// </summary>
            public double night { get; set; }
            /// <summary>
            ///  Evening temperature.
            /// </summary>
            public double eve { get; set; }
            /// <summary>
            /// Morning temperature.
            /// </summary>
            public double morn { get; set; }
        }

        public class FeelsLike
        {
            /// <summary>
            /// Day temperature.
            /// </summary>
            public double day { get; set; }
            /// <summary>
            /// Night temperature.
            /// </summary>
            public double night { get; set; }
            /// <summary>
            ///  Evening temperature.
            /// </summary>
            public double eve { get; set; }
            /// <summary>
            /// Morning temperature.
            /// </summary>
            public double morn { get; set; }
        }

        public class OneCallCurrent
        {
            /// <summary>
            /// Current time, Unix, UTC
            /// </summary>
            public int dt { get; set; }
            /// <summary>
            /// Sunrise time, Unix, UTC
            /// </summary>
            public int sunrise { get; set; }
            /// <summary>
            /// Sunset time, Unix, UTC
            /// </summary>
            public int sunset { get; set; }
            /// <summary>
            /// Temperature. Units - default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public double temp { get; set; }
            /// <summary>
            /// Temperature. This temperature parameter accounts for the human perception of weather. Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public double feels_like { get; set; }
            /// <summary>
            /// Atmospheric pressure on the sea level, hPa
            /// </summary>
            public int pressure { get; set; }
            /// <summary>
            /// Humidity, %
            /// </summary>
            public int humidity { get; set; }
            /// <summary>
            /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form. Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
            /// </summary>
            public double dew_point { get; set; }
            /// <summary>
            /// Current UV index
            /// </summary>
            public double uvi { get; set; }
            /// <summary>
            /// Cloudiness, %
            /// </summary>
            public int clouds { get; set; }
            /// <summary>
            /// Average visibility, metres
            /// </summary>
            public int visibility { get; set; }
            /// <summary>
            /// Wind speed. Wind speed. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
            /// </summary>
            public int wind_speed { get; set; }
            /// <summary>
            /// Wind direction, degrees (meteorological)
            /// </summary>
            public int wind_deg { get; set; }
            public List<Weather> weather { get; set; }
            public Rain rain { get; set; }
            public Snow snow { get; set; }
        }
    }
}
