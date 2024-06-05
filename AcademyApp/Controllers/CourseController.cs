using AcademyApp.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AcademyApp.Controllers
{
    public class CourseController : Controller
    {
        AcademyDbContext _academyDbContext;
        public CourseController(AcademyDbContext academyDbContext)
        {
            this._academyDbContext = academyDbContext;
        }
        public IActionResult Index()
        {
            return View(_academyDbContext.Courses.ToList());
        }
    }
}
