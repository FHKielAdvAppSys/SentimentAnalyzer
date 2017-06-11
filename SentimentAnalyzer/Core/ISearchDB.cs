using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentimentAnalyzer.Model;

namespace SentimentAnalyzer.Core
{
    public interface ISearchDB
    {
        Search Create(Search search);
        Search Delete(Search search);
        Search Retrieve(int id);
        bool Update(Search search);
    }
}
