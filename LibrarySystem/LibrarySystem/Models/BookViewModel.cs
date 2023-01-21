using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }
        public Nullable<int> MainCategoryId { get; set; }
        public Nullable<int> SubCategoryId { get; set; }

    }
}