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
        public List<SearchResult> search(string topic)
        {
            List<SearchResult> mockListResult = new List<SearchResult>();
            SearchResult mockResult = new SearchResult();
            mockListResult.Add(mockResult);
            return mockListResult;
        }
    }
}
