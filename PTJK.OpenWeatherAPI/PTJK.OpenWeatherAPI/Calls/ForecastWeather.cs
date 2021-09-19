using PTJK.OpenWeatherAPI.Helpers;
using PTJK.OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTJK.OpenWeatherAPI.Calls
{
    public interface IForecastWeather
    {
        /// <summary>
        /// Call current weather data for one location by city name
        /// </summary>
        /// <param name="cityName">City name.</param>
        /// <param name="metric">Units of measurement.</param>
        /// <param name="language">You can use this parameter to get the output in your language.</param>
        /// <returns></returns>
        Task<Forecast> GetByName(string cityName, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN);

        /// <summary>
        /// Call current weather data for one location by city id.
        /// </summary>
        /// <param name="cityId">City ID.</param>
        /// <param name="metric">Units of measurement.</param>
        /// <param name="language">You can use this parameter to get the output in your language.</param>
        /// <returns></returns>
        Task<Forecast> GetById(double cityId, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN);

        /// <summary>
        /// Call current weather data for one location by geographic coordinates
        /// </summary>
        /// <param name="lat">Latitude.</param>
        /// <param name="lon">Longitude.</param>
        /// <param name="metric">Units of measurement.</param>
        /// <param name="language">You can use this parameter to get the output in your language.</param>
        /// <returns></returns>
        Task<Forecast> GetByLatLon(double lat, double lon, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN);
    }

    internal sealed class ForecastWeather : ApiClientBase, IForecastWeather
    {
        internal ForecastWeather(IRequest request) : base(request, "forecast")
        {
        }

        internal ForecastWeather(IRequest request, ForecastAmount forecastAmount) : base(request, $"forecast/{forecastAmount.ToString().ToLowerInvariant()}")
        {
        }

        public Task<Forecast> GetByName(string cityName, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN)
        {
            return GetByName<Forecast>(cityName, metric, language, null, null);
        }

        public Task<Forecast> GetById(double cityId, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN)
        {
            return GetById<Forecast>(cityId, metric, language, null, null);
        }

        public Task<Forecast> GetByLatLon(double lat, double lon, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN)
        {
            return GetByLatLon<Forecast>(lat, lon, metric, language, null, null);
        }

    }
}
