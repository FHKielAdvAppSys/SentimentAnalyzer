using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.ViewModel
{
    class ChildVM
    {
        // instance of MainVM
        MainVM mainVM = new MainVM();

        // constructor with MainVM parameter
        public ChildVM (MainVM mVM)
        {
            mainVM = mVM;
        }
    }
}
