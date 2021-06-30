using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShifTracker.Models;

namespace ShifTracker.Controllers
{
    public class WorkstationController : Controller
    {
        private readonly ShifTrackerDbContext _context;

        public WorkstationController(ShifTrackerDbContext context)
        {
            _context = context;
        }

        // GET: Workstation
        public async Task<IActionResult> Index()
        {
            return View(await _context.Workstations.ToListAsync());
        }

        

        // GET: Workstation/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if(id==0)
                return View(new Workstation());
            else
                return View(_context.Workstations.Find(id));
        }

        // POST: Workstation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("id,Name,Location")] Workstation workstation)
        {
            if (ModelState.IsValid)
            {
                if(workstation.id ==0)
                    _context.Add(workstation);
                else
                    _context.Update(workstation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workstation);
        }

        // GET: Workstation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var workstation =await _context.Workstations.FindAsync(id);
            _context.Workstations.Remove(workstation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
