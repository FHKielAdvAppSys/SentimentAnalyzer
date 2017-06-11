using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SentimentAnalyzer.Model;

namespace SentimentAnalyzer.DB
{
   public class SentimentAnalyzerContext: DbContext
    {
        public DbSet<Search> Searches { get; set; }

        public DbSet<SearchResult> SearchResults { get; set; }

    }
}
