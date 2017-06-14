using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using SentimentAnalyzer.Core;
using SentimentAnalyzer.Model;
using SentimentAnalyzer.DB;
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

        IBingService _bingService;

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

        private Search _currentsearch;
        public Search CurrentSearch
        {
            get { return _currentsearch; }
            set
            {
                SetProperty(ref _currentsearch, value);
            }
        }

        public SearchVM(IBingService bingService) : base()
        {
            _bingService = bingService;

            SearchCommand = new DelegateCommand(() =>
            {
                Search(Topic);
            },
            () => (!string.IsNullOrEmpty(Topic))
            );
        }

        private void Search(string Topic)
        {
            List<SearchResult> BingResults = _bingService.Search(Topic);

            ISearchDB searchDB = DIManager.Instance.Resolve<ISearchDB>();

            Search search = new Search();
            search.Topic = this.Topic;
            search.Date = DateTime.Now;

            CurrentSearch = searchDB.Create(search);

            List<SearchResult> searchResultlist = new List<SearchResult>();
            foreach (SearchResult result in BingResults)
            {
                SearchResult searchResult = new SearchResult();
                searchResult.SearchID = CurrentSearch.ID;
                searchResult.BingID = result.BingID;
                searchResult.Title = result.Title;
                searchResult.Url = result.Url;
                searchResult.Description = result.Description;
                searchResultlist.Add(searchResult);
            }
            ISearchResultDB searchResultDB = DIManager.Instance.Resolve<ISearchResultDB>();
            Results = searchResultDB.Create(searchResultlist);


           
        }
    }
}
