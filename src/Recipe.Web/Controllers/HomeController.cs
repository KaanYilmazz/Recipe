using Microsoft.AspNetCore.Mvc;

namespace Recipe.Web.Controllers
{
    public class HomeController : RecipeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}