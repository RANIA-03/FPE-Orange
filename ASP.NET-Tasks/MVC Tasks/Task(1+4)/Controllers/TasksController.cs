using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Task_1_4_.Data;
using Task_1_4_.Models;

namespace Task_1_4_.Controllers
{
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tasks
        [Authorize(Roles = "ADMIN, MANAGER, EMPLOYEE")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Tasks.Include(t => t.Employee).Include(t => t.Manager);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tasks/Details/5
        [Authorize(Roles = "ADMIN, MANAGER, EMPLOYEE")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var tasks = await _context.Tasks
                .Include(t => t.Employee)
                .Include(t => t.Manager)
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (tasks == null)
            {
                return NotFound();
            }

            return View(tasks);
        }

        // GET: Tasks/Create
        [Authorize(Roles = "MANAGER")]
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id");
            ViewData["ManagerId"] = new SelectList(_context.Managers, "Id", "Id");
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "MANAGER")]
        public async Task<IActionResult> Create([Bind("TaskId,Title,StartDate,DueDate,Description,ImportanceLevel,EmployeeId,ManagerId")] Tasks tasks)
        {
            //if (ModelState.IsValid)
            //{
                _context.Add(tasks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            //ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", tasks.EmployeeId);
            //ViewData["ManagerId"] = new SelectList(_context.Managers, "Id", "Id", tasks.ManagerId);
            //return View(tasks);
        }

        // GET: Tasks/Edit/5
        [Authorize(Roles = "MANAGER")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var tasks = await _context.Tasks.FindAsync(id);
            if (tasks == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", tasks.EmployeeId);
            ViewData["ManagerId"] = new SelectList(_context.Managers, "Id", "Id", tasks.ManagerId);
            return View(tasks);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "MANAGER")]
        public async Task<IActionResult> Edit(int id, [Bind("TaskId,Title,StartDate,DueDate,Description,ImportanceLevel,EmployeeId,ManagerId")] Tasks tasks)
        {
            //if (id != tasks.TaskId)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(tasks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TasksExists(tasks.TaskId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            //ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", tasks.EmployeeId);
            //ViewData["ManagerId"] = new SelectList(_context.Managers, "Id", "Id", tasks.ManagerId);
            //return View(tasks);
        }

        // GET: Tasks/Delete/5
        [Authorize(Roles = "MANAGER")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var tasks = await _context.Tasks
                .Include(t => t.Employee)
                .Include(t => t.Manager)
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (tasks == null)
            {
                return NotFound();
            }

            return View(tasks);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "MANAGER")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tasks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Tasks'  is null.");
            }
            var tasks = await _context.Tasks.FindAsync(id);
            if (tasks != null)
            {
                _context.Tasks.Remove(tasks);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TasksExists(int id)
        {
          return (_context.Tasks?.Any(e => e.TaskId == id)).GetValueOrDefault();
        }
    }
}
