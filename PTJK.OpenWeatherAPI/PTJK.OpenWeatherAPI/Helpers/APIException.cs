using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;

namespace PTJK.OpenWeatherAPI.Helpers
{
    public sealed class APIException : Exception
    {
        internal APIException(HttpStatusCode status)
        {
            this.StatusCode = status;
        }
        internal APIException(HttpResponseMessage response)
           : this(response.StatusCode)
        {
            this.Response = response;
        }
        internal APIException(Exception ex)
           : base("OpenWeatherMap : an error occurred", ex)
        {
        }
        public HttpResponseMessage Response { get; private set; }
        public HttpStatusCode StatusCode { get; private set; }
    }
}
