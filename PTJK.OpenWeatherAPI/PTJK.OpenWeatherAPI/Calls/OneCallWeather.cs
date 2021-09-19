using PTJK.OpenWeatherAPI.Helpers;
using PTJK.OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTJK.OpenWeatherAPI.Calls
{
    public interface IOneCallWeather
    {
        /// <summary>
        /// Current and forecast weather data. To get access to current weather, minute forecast for 1 hour, hourly forecast for 48 hours, daily forecast for 7 days and government weather alerts.
        /// </summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lon">Longitude</param>
        /// <param name="metric">Units of measurement.</param>
        /// <param name="language">You can use this parameter to get the output in your language.</param>
        /// <returns></returns>
        Task<OneCall> GetByLatLon(double lat, double lon, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN);
    }

    internal sealed class OneCallWeather : ApiClientBase, IOneCallWeather
    {
        internal OneCallWeather(IRequest request) : base(request, "onecall")
        {
        }

        public Task<OneCall> GetByLatLon(double lat, double lon, MetricSystem metric = MetricSystem.Internal, Language language = Language.EN)
        {
            return GetByLatLon<OneCall>(lat, lon, metric, language, null, null);
        }
    }
}
