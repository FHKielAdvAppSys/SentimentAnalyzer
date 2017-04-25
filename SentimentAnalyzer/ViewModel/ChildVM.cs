using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.ViewModel
{
    public class ChildVM : BindableBase
    {
        private MainVM _mainVM;
        public MainVM MainVM
        {
            get { return _mainVM; }
            set
            {
                SetProperty(ref _mainVM, value);
            }
        }

        // constructor with MainVM parameter
        public ChildVM(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}
