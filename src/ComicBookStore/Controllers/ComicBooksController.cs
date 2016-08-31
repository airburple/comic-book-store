using ComicBookStore.Data;
using ComicBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookStore.Controllers
{
    public class ComicBooksController : Controller 
    {
        private ComicBookRepo _comicBookRepo = null;

        public ComicBooksController()
        {
            _comicBookRepo = new ComicBookRepo();
        } 

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepo.GetComicBook((int)id);

            return View(comicBook);
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepo.GetComicBooks();
            return View(comicBooks);
        }
    }
}