using PTJK.OpenWeatherAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PTJK.OpenWeatherAPI
{
    internal interface IRequest
    {
        Uri Uri { get; set; }
        string AppId { get; set; }
        IDictionary<string, string> Parameters { get; set; }
        HttpClient HttpClient { get; set; }
        HttpRequestMessage RequestMessage { get; set; }
    }

    internal sealed class Request : IRequest
    {
        public Request(Uri uri, HttpClient httpClient, string appId)
        {
            Ensure.ArgumentNotNull(uri, "uri");
            Ensure.ArgumentNotNull(httpClient, "httpClient");

            Uri = uri;
            HttpClient = httpClient;
            Parameters = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(appId))
            {
                AppId = appId;
                Parameters.Add("APPID", appId);
            }
        }
        public Uri Uri { get; set; }
        public string AppId { get; set; }
        public IDictionary<string, string> Parameters { get; set; }
        public HttpClient HttpClient { get; set; }
        public HttpRequestMessage RequestMessage { get; set; }
    }
}
