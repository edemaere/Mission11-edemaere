using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_edemaere.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        // Calculate number of pages
        public int TotalPages => (int) Math.Ceiling((double)TotalNumBooks / BooksPerPage);
    }
}
