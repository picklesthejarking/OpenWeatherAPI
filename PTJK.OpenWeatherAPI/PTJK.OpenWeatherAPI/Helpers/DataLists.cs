using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace PTJK.OpenWeatherAPI.Helpers
{
    public class DataLists
    {
        public DataLists()
        {

        }

        public List<Models.City> AllCities()
        {
            var cities_json = Encoding.Default.GetString(Properties.Resources.city_list);
            List<Models.City> list = JsonConvert.DeserializeObject<List<Models.City>>(cities_json);
            return list;
        }

        public List<Models.City> FindCity(string cityName) {
            return AllCities().Where(x => x.name.IndexOf(cityName, StringComparison.OrdinalIgnoreCase) > -1).ToList();

        }
    }
}
