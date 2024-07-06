using Ders6.EF.Data;
using Ders6.EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders6.EF.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;

        }



        public IActionResult Index()
        {
            var people = _context.Person.ToList();

            return View(people);
        }

        public IActionResult Create()
        {
            

            return View();
        }

        public IActionResult Edit(int id)
        {
            var person = _context.Person.Find(id);
            if (person == null)
            {
                return NotFound();

            }

            return View(person);
        }


        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Person.Add(person);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }

            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Person.Update(person);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }

            return View(person);
        }

       

        public IActionResult Delete(int id)
        {

            var person = _context.Person.Find(id);
            
            if (person != null)
            {
                _context.Person.Remove(person);
                _context.SaveChanges();
               
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
