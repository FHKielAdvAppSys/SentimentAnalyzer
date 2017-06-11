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
        private SentimentAnalyzerContext _sentimentAnalyzerContext;

        public SearchResultDB(SentimentAnalyzerContext sentimentAnalyzerContext)
        {
            _sentimentAnalyzerContext = sentimentAnalyzerContext;
        }

        public List<SearchResult> Create(List<SearchResult> searchResults)
        {
            var result = _sentimentAnalyzerContext.SearchResults.AddRange(searchResults);
            _sentimentAnalyzerContext.SaveChanges();
            return result.ToList();
        }

        public IEnumerable<SearchResult> Delete(List<SearchResult> searchResults)
        {
            var result = _sentimentAnalyzerContext.SearchResults.RemoveRange(searchResults);
            _sentimentAnalyzerContext.SaveChanges();
            return result;
        }

        public List<SearchResult> Retrieve(int searchID)
        {
            var searchResults = from sR in _sentimentAnalyzerContext.SearchResults
                           where sR.Search.ID == searchID
                           select sR;
            return searchResults.ToList();
        }

        public bool Update(List<SearchResult> searchResults)
        {
            return false;
        }
    }
}
