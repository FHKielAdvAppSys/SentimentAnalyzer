using SentimentAnalyzer.Core;
using SentimentAnalyzer.Model;
using SentimentAnalyzer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.ViewModel
{
    class SearchVM : ISearchVM
    {
        // Member variables
        private List<SearchResult> _results;
        //public SearchCommand DelegateCommand;
        private String _topic;

        // getter and setter
        public String Topic
        {
            get
            {
                return _topic;
            }
            set
            {
                _topic = value;
            }
        }

        public List<SearchResult> Results
        {
            get
            {
                return _results;
            }
            set
            {
                _results = value;
            }
        }

        SearchVM searchVM = new SearchVM();


        public List<SearchResult> Search(string Topic)
        {
            BingService bingservice = new BingService();
            return bingservice.search(Topic);
         }
    }
}
