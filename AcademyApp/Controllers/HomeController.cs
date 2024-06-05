using AcademyApp.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AcademyApp.Controllers
{
    public class HomeController : Controller
    {
        AcademyDbContext _academyDbContext;
        public HomeController(AcademyDbContext academyDbContext)
        {
            this._academyDbContext = academyDbContext;
        }
        public IActionResult Index()
        {
            return View(_academyDbContext.Groups.ToList());
        }

    }
}
