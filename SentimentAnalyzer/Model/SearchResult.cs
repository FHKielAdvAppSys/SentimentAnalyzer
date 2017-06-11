using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.Model
{
    public class SearchResult : BindableBase
    {
        private int _searchID;

        public int SearchID
        {
            get
            {
                return _searchID;
            }

            set
            {
                SetProperty(ref _searchID,value);
            }
        }

        private int _bingID;

        public int BingID
        {
            get
            {
                return _bingID;
            }

            set
            {
                SetProperty(ref _bingID, value);
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                SetProperty(ref _description, value);
            }
        }

        private string _url;
        public string Url
        {
            get { return _url; }
            set
            {
                SetProperty(ref _url, value);
            }
        }

       
    }
}
