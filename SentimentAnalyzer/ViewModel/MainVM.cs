    using Microsoft.Practices.Prism.Mvvm;
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
    public class MainVM : BindableBase
    {
        private ISearchVM _searchVM;
        public ISearchVM SearchVM
        {
            get { return _searchVM; }
            set
            {
                SetProperty(ref _searchVM, value);
            }
        }

        public MainVM(ISearchVM searchVM)
        {
            SearchVM = searchVM;
        }
    }
}
