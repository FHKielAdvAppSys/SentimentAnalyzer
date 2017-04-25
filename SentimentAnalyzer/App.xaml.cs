using SentimentAnalyzer.Core;
using SentimentAnalyzer.Model;
using SentimentAnalyzer.Service;
using SentimentAnalyzer.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SentimentAnalyzer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// Application startup logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            DIManager.Instance.Register<SearchResult, SearchResult>(LifeCycle.Transient);
            DIManager.Instance.Register<IBingService, BingService>(LifeCycle.Transient);
            DIManager.Instance.Register<MainVM, MainVM>(LifeCycle.Singletone);
            DIManager.Instance.Register<ISearchVM, SearchVM>(LifeCycle.Singletone);
        }

        /// <summary>
        /// Application Unhandled Exception logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {

        }

        /// <summary>
        /// Application exit logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Application_Exit(object sender, ExitEventArgs e)
        {
            DIManager.Instance.Dispose();
        }
    }
}
