using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace SchoolWeb.Controllers
{
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            return Ok();
        }

        public IActionResult Create()
        {
            return Content("création", "text/plain", Encoding.UTF8);
        }

        public IActionResult Photo(int photoid, [FromServices] IWebHostEnvironment environment)
        {
            string path = Path.Join(environment.ContentRootPath, "photos", "teacher-logo.png");
            using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            return File(fs, "image/png", "teacher.png");
        }
    }
}
