using SentimentAnalyzer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.Core
{
    /// <summary>
    /// Interface for Bing Service
    /// </summary>
    public interface IBingService
    {
        /// <summary>
        /// Bing search API call functionality
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        List<SearchResult> Search(string topic);
    }
}
