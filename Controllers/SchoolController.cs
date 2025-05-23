using Microsoft.AspNetCore.Mvc;
using MaintenancePortal.Data;
using MaintenancePortal.Models;
using System.Threading.Tasks;
using System.Linq;

namespace MaintenancePortal.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchoolController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: School/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: School/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(School school)
        {
            if (ModelState.IsValid)
            {
                _context.Schools.Add(school);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(school);
        }

        // GET: School
        public IActionResult Index()
        {
            var schools = _context.Schools.ToList();
            return View(schools);
        }
    }
}
