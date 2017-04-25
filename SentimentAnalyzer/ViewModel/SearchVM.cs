using Microsoft.Practices.Prism.Commands;
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
    public class SearchVM : ChildVM, ISearchVM
    {
        // Member variables
        public DelegateCommand SearchCommand;

        private String _topic;
        public String Topic
        {
            get { return _topic; }
            set
            {
                SetProperty(ref _topic, value);
            }
        }

        private List<SearchResult> _results;

        public List<SearchResult> Results
        {
            get{return _results;}
            set
            {
                SetProperty(ref _results, value);
            }
        }

        private SearchVM(MainVM mainVM) : base(mainVM)
        {
        }

        public List<SearchResult> Search(string Topic)
        {
            IBingService bingservice = DIManager.Instance.Resolve<IBingService>();
            return bingservice.Search(Topic);
        }
    }
}
