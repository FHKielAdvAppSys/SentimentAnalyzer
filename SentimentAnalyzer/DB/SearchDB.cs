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
        public Search Create(Search search)
        {
            return new Search();
        }
        public bool Delete(Search search)
        {
            return false;
        }
        public Search Retrieve()
        {
            return new Search();
        }
        public bool Update(Search search)
        {
            return false;
        }
    }
}
