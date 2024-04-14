using CodeFirstASPCore6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task <IActionResult> Index()
        {
            return View(await studentDBContext.Students.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                await studentDBContext.Students.AddAsync(std);
                await studentDBContext.SaveChangesAsync();
                TempData["insert_success"] = "Inserted";
                return RedirectToAction("Index","Home");
            }
            return View(std);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id==null || studentDBContext.Students== null)
            {
                return NotFound();
            }
            var stdData =await studentDBContext.Students.FirstOrDefaultAsync(x=> x.Id == id);
            if (stdData==null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || studentDBContext.Students == null)
            {
                return NotFound();
            }
            var stdData = await studentDBContext.Students.FindAsync(id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Student std)
        {
            if(id != std.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                studentDBContext.Update(std);
                await studentDBContext.SaveChangesAsync();
                TempData["updated_success"] = "Updated";
                return RedirectToAction("Index", "Home");
            }

            return View(std);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || studentDBContext.Students == null)
            {
                return NotFound();
            }
            var stdData = await studentDBContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stdData == null)
            {
                return NotFound();

            }

            return View(stdData);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var stdData = await studentDBContext.Students.FindAsync(id);
            if (stdData != null)
            {
                studentDBContext.Students.Remove(stdData);
            }
           await studentDBContext.SaveChangesAsync();
            TempData["delete_success"] = "Deleted";
            return RedirectToAction("Index", "Home");
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