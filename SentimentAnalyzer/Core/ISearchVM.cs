using SentimentAnalyzer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SentimentAnalyzer.Core
{
    interface ISearchVM
    {
       List<SearchResult> Search(String Topic);
    }
}
