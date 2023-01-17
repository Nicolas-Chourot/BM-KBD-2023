using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookmarksManager.Models;

namespace BookmarksManager.Controllers
{
    public class BookmarksController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(DB.Bookmarks.ToList().OrderBy(b => b.Title));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Bookmark());
        }
        [HttpPost]
        public ActionResult Create(Bookmark bookmark)
        {
            DB.Bookmarks.Add(bookmark);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(DB.Bookmarks.Get(id));
        }
        [HttpPost]
        public ActionResult Edit(Bookmark bookmark)
        {
            DB.Bookmarks.Update(bookmark);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            DB.Bookmarks.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
