using SentimentAnalyzer.Core;
using SentimentAnalyzer.Service;
using SentimentAnalyzer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.ViewModel
{
    class MainVM
    {
        private ISearchVM _searchVM = new SearchVM();

        public ISearchVM SearchVM
        {
            get
            {
                return _searchVM;
            }
            set
            {
                _searchVM = value;
            }
        }

        public MainVM (IBingService bingService, ISearchVM searchVM)
        {
            // Constructor coding
        }
        public MainVM ()
        {

        }
    }
}
