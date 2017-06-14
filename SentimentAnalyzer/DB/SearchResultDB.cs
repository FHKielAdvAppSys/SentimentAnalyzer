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
        private SentimentAnalyzerContext _db;

        public SearchResultDB(SentimentAnalyzerContext sentimentAnalyzerContext)
        {
            _db = sentimentAnalyzerContext;
        }

        public List<SearchResult> Create(List<SearchResult> searchResults)
        {
            var result = _db.SearchResults.AddRange(searchResults);
            _db.SaveChanges();
            return result.ToList();
        }

        public IEnumerable<SearchResult> Delete(List<SearchResult> searchResults)
        {
            var result = _db.SearchResults.RemoveRange(searchResults);
            _db.SaveChanges();
            return result;
        }

        public List<SearchResult> Retrieve(int searchID)
        {
            var searchResults = from sR in _db.SearchResults
                                where sR.Search.ID == searchID
                                select sR;
            return searchResults.ToList();
        }

        public bool Update(List<SearchResult> searchResults)
        {
            searchResults.ForEach(searchResult =>
            {
                _db.SearchResults.Attach(searchResult);
                var entry = _db.Entry(searchResult);
                entry.Property(e => e.Search).IsModified = true;
                entry.Property(e => e.Url).IsModified = true;
                entry.Property(e => e.Title).IsModified = true;
                entry.Property(e => e.Description).IsModified = true;
            });
            return _db.SaveChanges() == 1;
        }
    }
}
