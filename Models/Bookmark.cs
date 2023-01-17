using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookmarksManager.Models
{
    public class Bookmark
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}