using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookmarksManager.Models
{
    public class BookmarksRepository : Repository<Bookmark>
    {
        public bool TitleExist(string title, int excludedId = 0)
        {
            foreach (Bookmark bookmark in ToList())
            {
                if ((bookmark.Id != excludedId) && string.Equals(title, bookmark.Title, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        public override int Add(Bookmark bookmark)
        {
            if (!TitleExist(bookmark.Title))
            {
                return base.Add(bookmark);
            }
            return 0;
        }
        public override bool Update(Bookmark bookmark)
        {
            if (!TitleExist(bookmark.Title, bookmark.Id))
            {
                return base.Update(bookmark);
            }
            return false;
        }
    }
}