using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookmarksManager.Models
{
    public sealed class DB
    {
        private static readonly DB instance = new DB();
        public static BookmarksRepository Bookmarks { get; set; }
        public DB()
        {
            Bookmarks = new BookmarksRepository();
        }
        public static DB Instance
        {
            get { return instance; }
        }
    }
}