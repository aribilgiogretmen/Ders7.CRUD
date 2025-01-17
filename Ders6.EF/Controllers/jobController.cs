﻿using Ders6.EF.Data;
using Ders6.EF.Models;
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

       

        public IActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Create(Job job)
        {

            var isler = new Job
            {
                Name = job.Name,
                Aciklama = job.Aciklama
            };
                
            _context.Job.Add(isler);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
