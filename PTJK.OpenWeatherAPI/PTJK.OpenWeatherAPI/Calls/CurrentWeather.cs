using PTJK.OpenWeatherAPI.Helpers;
using PTJK.OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTJK.OpenWeatherAPI.Calls
{
    public interface ICurrentWeather
    {
        /// <summary>
        /// Call current weather data for one location by city name
        /// </summary>
        /// <param name="cityName">City name.</param>
        /// <param name="metric">Units of measurement.</param>
        /// <param name="language">You can use this parameter to get the output in your language.</param>
        /// <returns></returns>
        Task<Current> GetByName(string cityName, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN);

        /// <summary>
        /// Call current weather data for one location by city id.
        /// </summary>
        /// <param name="cityId">City ID.</param>
        /// <param name="metric">Units of measurement.</param>
        /// <param name="language">You can use this parameter to get the output in your language.</param>
        /// <returns></returns>
        Task<Current> GetById(double cityId, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN);

        /// <summary>
        /// Call current weather data for one location by geographic coordinates
        /// </summary>
        /// <param name="lat">Latitude.</param>
        /// <param name="lon">Longitude.</param>
        /// <param name="metric">Units of measurement.</param>
        /// <param name="language">You can use this parameter to get the output in your language.</param>
        /// <returns></returns>
        Task<Current> GetByLatLon(double lat, double lon, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN);
    }

    internal sealed class CurrentWeather : ApiClientBase, ICurrentWeather
    {
        internal CurrentWeather(IRequest request) : base(request, "weather")
        {
        }

        public Task<Current> GetByName(string cityName, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN)
        {
            return GetByName<Current>(cityName, metric, language, null, null);
        }

        public Task<Current> GetById(double cityId, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN)
        {
            return GetById<Current>(cityId, metric, language, null, null);
        }

        public Task<Current> GetByLatLon(double lat, double lon, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN)
        {
            return GetByLatLon<Current>(lat, lon, metric, language, null, null);
        }
    }
}
