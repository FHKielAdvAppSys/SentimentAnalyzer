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
        private int _id;
        public int ID
        {
            get { return _id; }
            set
            {
                SetProperty(ref _id, value);
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
