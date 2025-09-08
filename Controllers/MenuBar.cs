using Microsoft.AspNetCore.Mvc;

namespace ST10461176_PROG_6212_POE.Controllers
{
    public class MenuBarController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        public IActionResult LecturerPage(string role)
        {
            ViewBag.role = role;
            if (role == "lecturer")
            {
                return View("~/Views/Home/LecturerPage.cshtml");
            }
            else if (role == "PC")
            {
                return View("~/Views/Home/ProgramCoordinatorPage.cshtml");
            }
            else if (role == "AM")
            {
                return View("~/Views/Home/AcademicManagerPage.cshtml");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
            
        }
        public IActionResult ProgramCoordinatorPage(string role)
        {
            return View("~/Views/Home/ProgramCoordinatorPage.cshtml");
        }
        public IActionResult AcademicManagerPage()
        {
            return View("~/Views/Home/AcademicManagerPage.cshtml");
        }
        public IActionResult ClaimPopup()
        {
            return View("~/Views/Home/ClaimPopup.cshtml");
        }
    }
}
