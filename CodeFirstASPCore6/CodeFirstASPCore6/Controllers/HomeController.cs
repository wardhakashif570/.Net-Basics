using CodeFirstASPCore6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirstASPCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext studentDBContext;

        /*private readonly ILogger<HomeController> _logger;

public HomeController(ILogger<HomeController> logger)
{
_logger = logger;
}
*/

        public HomeController(StudentDBContext studentDBContext)
        {
            this.studentDBContext = studentDBContext;
        }
        public IActionResult Index()
        {
            return View(studentDBContext.Students.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}