using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookStore.Controllers
{
    public class ComicBooksController : Controller 
    {

        public ActionResult Detail()
        {

           

            

            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }
            return new ContentResult
            {

                Content = "hello from the other side."

            };
        }
    }
}