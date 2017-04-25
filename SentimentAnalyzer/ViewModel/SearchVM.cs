using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
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
    public class SearchVM : BindableBase, ISearchVM
    {
        public DelegateCommand SearchCommand { get; set; }

        private String _topic;
        public String Topic
        {
            get { return _topic; }
            set
            {
                if (SetProperty(ref _topic, value))
                    SearchCommand.RaiseCanExecuteChanged();
            }
        }

        private List<SearchResult> _results;
        public List<SearchResult> Results
        {
            get { return _results; }
            set
            {
                SetProperty(ref _results, value);
            }
        }

        public SearchVM() : base()
        {
            SearchCommand = new DelegateCommand(() =>
            {
                Search(Topic);
            },
            () => (!string.IsNullOrEmpty(Topic))
            );
        }

        private void Search(string Topic)
        {
            IBingService bingService = DIManager.Instance.Resolve<IBingService>();
            Results = bingService.Search(Topic);
        }
    }
}
