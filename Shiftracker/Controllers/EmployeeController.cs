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
    public class EmployeeController : Controller
    {
        private readonly ShifTrackerDbContext _context;
        public EmployeeController(ShifTrackerDbContext context)
        {
            _context = context;
        }
        // GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }
        // GET: Employee/AddOrEdit
        public IActionResult AddOrEdit(int id = 0)
        {

            if (id == 0)
                return View(new Employee());
            else
                return View(_context.Employees.Find(id));

        }
        // POST: Employee/AddOrEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name,Surname")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Id == 0)
                    _context.Add(employee);
                else
                    _context.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
