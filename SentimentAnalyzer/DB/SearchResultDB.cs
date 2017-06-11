using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentAnalyzer.Core;
using SentimentAnalyzer.Model;

namespace SentimentAnalyzer.DB
{
    public class SearchResultDB : ISearchResultDB
    {
        public List<SearchResult> Create(List<SearchResult> searchResults)
        {
            return new List<SearchResult>();
        }

        public bool Delete(List<SearchResult> searchResults)
        {
            return false;
        }

        public List<SearchResult> Retrieve()
        {
            return new List<SearchResult>();
        }

        public bool Update(List<SearchResult> searchResults)
        {
            return false;
        }
    }
}
