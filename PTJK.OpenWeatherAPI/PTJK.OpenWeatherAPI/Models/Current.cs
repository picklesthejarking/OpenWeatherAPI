using System;
using System.Collections.Generic;
using System.Text;

namespace PTJK.OpenWeatherAPI.Models
{
    public class Current
    {
        public Collections.Coord coord { get; set; }
        public List<Collections.Weather> weather { get; set; }
        /// <summary>
        /// Internal parameter
        /// </summary>
        public string @base { get; set; }
        public Collections.Main main { get; set; }
        public int visibility { get; set; }
        public Collections.Wind wind { get; set; }
        public Collections.Rain rain { get; set; }
        public Collections.Snow snow { get; set; }
        public Collections.Clouds clouds { get; set; }
        /// <summary>
        /// Time of data calculation, unix, UTC
        /// </summary>
        public int dt { get; set; }
        public Collections.Sys sys { get; set; }
        /// <summary>
        /// Shift in seconds from UTC
        /// </summary>
        public int timezone { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Internal parameter
        /// </summary>
        public int cod { get; set; }

        
    }
}
