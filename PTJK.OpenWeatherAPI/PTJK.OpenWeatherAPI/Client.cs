using PTJK.OpenWeatherAPI.Calls;
using PTJK.OpenWeatherAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PTJK.OpenWeatherAPI
{
    internal interface IClient
    {
        string AppId { get; set; }

        ICurrentWeather CurrentWeather { get; }

    }

    public sealed class Client : IClient
    {
        public string AppId { get; set; }

        public static readonly Uri OpenWeatherUrl = new Uri("https://api.openweathermap.org/data/2.5");

        private HttpClient httpClient { get; set; }

        public Client(string appId, HttpMessageHandler httpMessageHandler = null)
        {
            if (httpMessageHandler == null)
            {
                httpMessageHandler = new HttpClientHandler();
            }

            httpClient = new HttpClient(httpMessageHandler);
            AppId = appId;
        }

        /// <summary>
        /// Call current weather data for one location
        /// </summary>
        public ICurrentWeather CurrentWeather { get { return new CurrentWeather(new Request(OpenWeatherUrl, httpClient, AppId)); } }

        /// <summary>
        /// Call forecast data for specified days
        /// </summary>
        /// <param name="forecastAmount">Hourly Forecast for 4 days, Daily forecast for 16 days, or climatic forecast for 30 days.</param>
        /// <returns></returns>
        public IForecastWeather ForecastWeather(ForecastAmount forecastAmount) { return new ForecastWeather(new Request(OpenWeatherUrl, httpClient, AppId), forecastAmount);}

        /// <summary>
        /// Call 5 day / 3 hour forecast data
        /// </summary>
        /// <returns></returns>
        public IForecastWeather ForecastWeather() { return new ForecastWeather(new Request(OpenWeatherUrl, httpClient, AppId)); }
        /// <summary>
        /// Current and forecast weather data
        /// </summary>
        public IOneCallWeather OneCallWeater { get { return new OneCallWeather(new Request(OpenWeatherUrl, httpClient, AppId)); } }
    }
}
