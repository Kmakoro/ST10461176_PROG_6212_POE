using Microsoft.AspNetCore.Mvc;

namespace ST10461176_PROG_6212_POE.Controllers
{
    public class MenuBarController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        public IActionResult LecturerPage()
        {
            return View("~/Views/Home/LecturerPage.cshtml");
        }
        public IActionResult ProgramCoordinatorPage()
        {
            return View("~/Views/Home/ProgramCoordinatorPage.cshtml");
        }
        public IActionResult AcademicManagerPage()
        {
            return View("~/Views/Home/AcademicManagerPage.cshtml");
        }
    }
}
