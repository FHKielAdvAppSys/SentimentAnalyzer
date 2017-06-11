using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentAnalyzer.Core;
using SentimentAnalyzer.Model;

namespace SentimentAnalyzer.DB
{
    public class SearchDB : ISearchDB
    {
        private SentimentAnalyzerContext _sentimentAnalyzerContext;

        public SearchDB(SentimentAnalyzerContext sentimentAnalyzerContext)
        {
            _sentimentAnalyzerContext = sentimentAnalyzerContext;
        }

        public Search Create(Search search)
        {
            var result = _sentimentAnalyzerContext.Searches.Add(search);
            _sentimentAnalyzerContext.SaveChanges();
            return result;
        }

        public Search Delete(Search search)
        {
            var result = _sentimentAnalyzerContext.Searches.Remove(search);
            _sentimentAnalyzerContext.SaveChanges();
            return result;
        }

        public Search Retrieve(int id)
        {
            var searches = from s in _sentimentAnalyzerContext.Searches
                           where s.ID == id
                           select s;
            var search = searches.Any() ? searches.Single() : null;
            return search;
        }

        public bool Update(Search search)
        {
            return false;
        }
    }
}
