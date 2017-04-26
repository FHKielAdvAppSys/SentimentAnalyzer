using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentAnalyzer.Core;
using SentimentAnalyzer.Model;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SentimentAnalyzer.Service
{
    /// <summary>
    /// Bing Service Class
    /// </summary>
    class BingService : IBingService
    {
        /// <summary>
        /// Bing search API call functionality
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        public List<SearchResult> Search(string topic)
        {
            ///ToDo
            List<SearchResult> mockListResult = new List<SearchResult>()
            {
                new SearchResult { ID = 1, Title = "title1", Description = "scription1", Url = "www.url1.com" },
                new SearchResult { ID = 2, Title = "title2", Description = "scription2", Url = "www.url2.com" },
                new SearchResult { ID = 3, Title = "title3", Description = "scription3", Url = "www.url3.com" }
            };

           // MakeRequest(); // Uncomment this to Call Bing Search API

            return mockListResult;


        }

        static async void MakeRequest()
        {

            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "e58407b94ffc4d4d99c6a6b6eb711051");

            // Request parameters
            queryString["q"] = "bill gates";
            queryString["count"] = "10";
            queryString["offset"] = "0";
            queryString["mkt"] = "en-us";
            queryString["safesearch"] = "Moderate";
            queryString["JsonType"] = "raw";  
            var uri = "https://api.cognitive.microsoft.com/bing/v5.0/search?" + queryString;

            var response = await client.GetStringAsync(uri);

            var searchResult = JsonConvert.DeserializeObject(response);


        }

    }
}
