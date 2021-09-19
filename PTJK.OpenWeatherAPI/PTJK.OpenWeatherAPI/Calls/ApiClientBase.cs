using Newtonsoft.Json;
using PTJK.OpenWeatherAPI.Helpers;
using PTJK.OpenWeatherAPI.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PTJK.OpenWeatherAPI.Calls
{
    internal interface IApiClientBase
    {
        IRequest Request { get; set; }
    }
    class ApiClientBase : IApiClientBase
    {
        protected ApiClientBase(IRequest request, string segment)
        {
            request.Uri = request.Uri.AddSegment(segment);
            Request = request;
        }
        public IRequest Request { get; set; }

        internal Task<T> GetByName<T>(string cityName, MetricSystem metric, Language language, int? count, Accuracy? accuracy)
        {
            Ensure.ArgumentNotNullOrEmptyString(cityName, "cityName");
            Ensure.ArgumentNotNull(metric, "metric");
            Ensure.ArgumentNotNull(language, "language");

            Request.Parameters.Add("q", cityName.UrlEncode());
            if (metric != MetricSystem.Internal)
            {
                Request.Parameters.Add("units", metric.ToString().ToLowerInvariant());
            }

            if (language != Language.EN)
            {
                Request.Parameters.Add("lang", language.ToString().ToLowerInvariant());
            }

            if (count.HasValue)
            {
                Request.Parameters.Add("cnt", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            if (accuracy.HasValue)
            {
                Request.Parameters.Add("type", accuracy.Value.ToString().ToLowerInvariant());
            }

            return RunGetRequest<T>();
        }

        internal Task<T> GetById<T>(double cityId, MetricSystem metric, Language language, int? count, Accuracy? accuracy)
        {
            Ensure.ArgumentNotNull(cityId, "citId");
            Ensure.ArgumentNotNull(metric, "metric");
            Ensure.ArgumentNotNull(language, "language");

            Request.Parameters.Add("id", cityId.ToString().UrlEncode());
            if (metric != MetricSystem.Internal)
            {
                Request.Parameters.Add("units", metric.ToString().ToLowerInvariant());
            }

            if (language != Language.EN)
            {
                Request.Parameters.Add("lang", language.ToString().ToLowerInvariant());
            }

            if (count.HasValue)
            {
                Request.Parameters.Add("cnt", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            if (accuracy.HasValue)
            {
                Request.Parameters.Add("type", accuracy.Value.ToString().ToLowerInvariant());
            }

            return RunGetRequest<T>();
        }

        internal Task<T> GetByLatLon<T>(double lat, double lon, MetricSystem metric, Language language, int? count, Accuracy? accuracy)
        {
            Ensure.ArgumentNotNull(lat, "latitude");
            Ensure.ArgumentNotNull(lon, "longitude");
            Ensure.ArgumentNotNull(metric, "metric");
            Ensure.ArgumentNotNull(language, "language");

            Request.Parameters.Add("lat", lat.ToString().UrlEncode());
            Request.Parameters.Add("lon", lon.ToString().UrlEncode());
            if (metric != MetricSystem.Internal)
            {
                Request.Parameters.Add("units", metric.ToString().ToLowerInvariant());
            }

            if (language != Language.EN)
            {
                Request.Parameters.Add("lang", language.ToString().ToLowerInvariant());
            }

            if (count.HasValue)
            {
                Request.Parameters.Add("cnt", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            if (accuracy.HasValue)
            {
                Request.Parameters.Add("type", accuracy.Value.ToString().ToLowerInvariant());
            }

            return RunGetRequest<T>();
        }

        Task<T> RunGetRequest<T>()
        {
            var uri = Request.Uri.AddQuery(Request.Parameters.ToUrlParameters());
            Request.RequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            return Send<T>();
        }

        async Task<T> Send<T>()
        {
            HttpResponseMessage response;
            try
            {
                response = await this.Request.HttpClient.SendAsync(this.Request.RequestMessage);
            }
            catch (Exception ex)
            {
                throw new APIException(ex);
            }

            if (!response.IsSuccessStatusCode)
            {
                throw new APIException(response);
            }

            var responseString = await response.Content.ReadAsStringAsync();

            try
            {

                return JsonConvert.DeserializeObject<T>(responseString);
            }
            catch (Exception e)
            {
                throw new APIException(response);
            }

        }
    }
}
