using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace PTJK.OpenWeatherAPI.Helpers.Extensions
{
    internal static class UriExtensions
    {
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed. Suppression is OK here.")]
        public static Uri AddSegment(this Uri originalUri, string segment)
        {
            originalUri = new Uri(originalUri.OriginalString + "/" + segment);
            return originalUri;
        }

        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed. Suppression is OK here.")]
        public static Uri AddQuery(this Uri originalUri, string segment)
        {
            var uriBuilder = new UriBuilder(originalUri) { Query = segment };
            originalUri = uriBuilder.Uri;
            return originalUri;
        }

        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed. Suppression is OK here.")]
        public static string ToUrlParameters(this IEnumerable<KeyValuePair<string, string>> parameters)
        {
            var array = parameters.Select(x => string.Format("{0}={1}", Uri.EscapeUriString(x.Key), Uri.EscapeUriString(x.Value))).ToArray();
            return string.Join("&", array);
        }
    }

    internal static class StringExtensions
    {
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed. Suppression is OK here.")]
        public static string UrlEncode(this string input)
        {
            return Uri.EscapeDataString(input);
        }
    }
    
}
