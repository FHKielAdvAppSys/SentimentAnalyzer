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
using System.Web.UI.WebControls;

namespace SentimentAnalyzer.Service
{
    /// <summary>
    /// Bing Service Class
    /// </summary>
    class BingService : IBingService
    {
        // Root URL
        private const string rootUrl = "https://api.cognitive.microsoft.com/bing/v5.0/search?";
    
        //AccountKey
        private const string AccountKey = "e58407b94ffc4d4d99c6a6b6eb711051";

        private const string market = "en-us";
        private const string count = "10";
        private const string offset = "0";
        private const string safesearch = "Moderate";
        private const string JsonType = "raw";

        /// <summary>
        /// Bing search API call functionality
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        public List<SearchResult> Search(string topic)
        {

            var client = new HttpClient();
            List<SearchResult> searchResult = new List<SearchResult>();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", AccountKey);

            // Request parameters
            queryString["q"] = topic;
            queryString["count"] = count;
            queryString["offset"] = offset;
            queryString["mkt"] = market;
            queryString["safesearch"] = safesearch;
            queryString["JsonType"] = JsonType;

            //Request URL
            var uri = rootUrl + queryString;

            //Response JSON
            var response = client.GetStringAsync(uri).Result;

            //Response Object
            dynamic responseObj = JsonConvert.DeserializeObject(response);

            //Mapping of Response Object to searchResult 
            foreach (var obj in responseObj.webPages.value)
            {

                SearchResult result = new SearchResult();

                result.BingID = obj.id;
                result.Title = obj.name;
                result.Url = obj.url;
                result.Description = obj.snippet;

                searchResult.Add(result);
            }

            return searchResult;
        }
    }
}
