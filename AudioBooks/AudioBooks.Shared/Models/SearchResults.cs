using System.Collections.Generic;

namespace AudioBooks.Shared.Models
{
    public class SearchResults<T>
    {
        public List<T> List { get; set; }
        public int TotalRecords { get; set; }
        public int DisplayRecords { get; set; }
    }
}
