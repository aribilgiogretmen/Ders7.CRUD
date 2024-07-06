using Ders6.EF.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ders6.EF.Controllers
{
    public class jobController : Controller
    {
        private readonly ApplicationDbContext _context;

        public jobController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {


            return View(_context.Job.ToList());
        }
    }
}
