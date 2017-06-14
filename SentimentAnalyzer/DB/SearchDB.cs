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
        private SentimentAnalyzerContext _db;

        public SearchDB(SentimentAnalyzerContext sentimentAnalyzerContext)
        {
            _db = sentimentAnalyzerContext;
        }

        public Search Create(Search search)
        {
            var result = _db.Searches.Add(search);
            _db.SaveChanges();
            return result;
        }

        public Search Delete(Search search)
        {
            var result = _db.Searches.Remove(search);
            _db.SaveChanges();
            return result;
        }

        public Search Retrieve(int id)
        {
            var searches = from s in _db.Searches
                           where s.ID == id
                           select s;
            var search = searches.Any() ? searches.Single() : null;
            return search;
        }

        public bool Update(Search search)
        {
            _db.Searches.Attach(search);
            var entry = _db.Entry(search);
            entry.Property(e => e.Topic).IsModified = true;
            entry.Property(e => e.Date).IsModified = true;
            return _db.SaveChanges() == 1;
        }
    }
}
