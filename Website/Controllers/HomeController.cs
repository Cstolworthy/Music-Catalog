using System.Web.Mvc;
using DataAccess;
using Interfaces;
using Objects.Database;

namespace Website.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

//            DatabaseConfiguration config = new DatabaseConfiguration("mongodb://MusicCatalog:Password@flame.mongohq.com:27053/"){DatabaseName = "Test"};

//            DatabaseAccess da = new DatabaseAccess(config);

//            var result = da.GetSingle<MusicSheet>(CollectionName.SheetMusic,"blah");

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
