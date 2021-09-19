using System;
using System.Collections.Generic;
using System.Text;
using static PTJK.OpenWeatherAPI.Models.Collections;

namespace PTJK.OpenWeatherAPI.Models
{
    public class Forecast
    {
        /// <summary>
        /// Internal parameter
        /// </summary>
        public string cod { get; set; }
        /// <summary>
        /// Internal parameter
        /// </summary>
        public double message { get; set; }
        /// <summary>
        /// Number of timestamps returned by this API call
        /// </summary>
        public int cnt { get; set; }
        public List<ForecastList> list { get; set; }
        public City city { get; set; }

        public class ForecastList
        {
            /// <summary>
            /// Time of data forecasted, Unix, UTC
            /// </summary>
            public int dt { get; set; }
            public Main main { get; set; }
            public List<Weather> weather { get; set; }
            public Clouds clouds { get; set; }
            public Wind wind { get; set; }
            public Rain rain { get; set; }
            public Snow snow { get; set; }
            /// <summary>
            /// Average visibility, metres
            /// </summary>
            public int visibility { get; set; }
            /// <summary>
            /// Probability of precipitation
            /// </summary>
            public double pop { get; set; }
            public SysPod sys { get; set; }
            /// <summary>
            /// Time of data forecasted, ISO, UTC
            /// </summary>
            public string dt_txt { get; set; }

        }

    }
}
