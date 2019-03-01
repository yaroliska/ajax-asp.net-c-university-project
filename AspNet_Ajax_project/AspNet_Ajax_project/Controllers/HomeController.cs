using AspNet_Ajax_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNet_Ajax_project.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        PathContext db = new PathContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Path
            IEnumerable<Path> paths = db.Paths;
            // передаем все объекты в динамическое свойство Paths в ViewBag
            ViewBag.Paths = paths;
            // возвращаем представление
            return View();
        }
    }
}