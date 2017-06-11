using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentAnalyzer.Model;

namespace SentimentAnalyzer.Core
{
    public interface ISearchResultDB
    {
        List<SearchResult> Create(List<SearchResult> searchResults);
        IEnumerable<SearchResult> Delete(List<SearchResult> searchResults);
        List<SearchResult> Retrieve(int searchID);
        bool Update(List<SearchResult> searchResults);
    }
}
