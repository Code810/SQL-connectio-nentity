using AcademyApp.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AcademyApp.Controllers
{
    public class StudentController : Controller
    {
        AcademyDbContext _academyDbContext;
        public StudentController(AcademyDbContext academyDbContext)
        {
            this._academyDbContext = academyDbContext;
        }
        public IActionResult Index(int? groupId)
        {
            if (groupId is null)
                return View(_academyDbContext.Students.ToList());
            if (_academyDbContext.Students.Any(m => m.GroupId == groupId))
                return View(_academyDbContext.Students.Where(m => m.GroupId == groupId).ToList());
            return NotFound();
        }
    }
}
