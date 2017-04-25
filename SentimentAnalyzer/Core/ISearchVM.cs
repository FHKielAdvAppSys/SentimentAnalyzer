using Microsoft.Practices.Prism.Commands;
using SentimentAnalyzer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SentimentAnalyzer.Core
{
    public interface ISearchVM
    {
        DelegateCommand SearchCommand { get; set; }

        String Topic { get; set; }

        List<SearchResult> Results { get; set; }
    }
}
