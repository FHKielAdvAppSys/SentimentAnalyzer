using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.Model
{
    class SearchResult
    {
        //Member variables
        private string _description;
        private int _id;
        private string _title;
        private string _url;
        
        //getter and setter for description
        public string Description 
        {
            get 
            {
                return _description;
            }
            set 
            {
                _description = value;
            }

        }

        //getter and setter for ID 
        public int ID
        {
            get
            {
                return _id;
            }
            set 
            {
                _id = value;
            }
        }

        //getter and setter for title
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        //getter and setter for url
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
            }
        }
        

    }
}
