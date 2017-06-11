using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.Model
{
    public class Search : BindableBase
    {
        private int _ID;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                SetProperty(ref _ID, value);
            }
        }

        private string _topic;
        public string Topic
        {
            get { return _topic; }
            set
            {
                SetProperty(ref _topic, value);
            }
        }

        private List<SearchResult> _searchResults;
        public List<SearchResult> SearchResults
        {
            get { return _searchResults; }
            set
            {
                SetProperty(ref _searchResults, value);
            }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set
            {
                SetProperty(ref _date, value);
            }

        }
    }
}
