using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebAppEmpty.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("Index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
