using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AGL.SortPet.Utility
{
   public class APIHandler
    {
        public static string GetAPIResult(string apiUri, Dictionary<string, string> headerDetails = null)
        {
            HttpClientHandler _httpClientHandler = new HttpClientHandler();
            using (HttpClient httpClient = new HttpClient(_httpClientHandler))
            {
                httpClient.DefaultRequestHeaders.Clear();
                if (null != headerDetails)
                    foreach (KeyValuePair<string, string> header in headerDetails)
                    {
                        httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return httpClient.GetStringAsync(new Uri(apiUri)).Result;
            }
        }
    }
}
