using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentAnalyzer.Core;
using SentimentAnalyzer.Model;

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
            return mockListResult;
        }
    }
}
