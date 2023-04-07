using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectSem3.Models;

namespace ProjectSem3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminInterviewsController : Controller
    {
        private readonly AbcCvContext _context;

        public AdminInterviewsController(AbcCvContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminInterviews
        public async Task<IActionResult> Index()
        {
              return _context.Interviews != null ? 
                          View(await _context.Interviews.ToListAsync()) :
                          Problem("Entity set 'AbcCvContext.Interviews'  is null.");
        }

        // GET: Admin/AdminInterviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Interviews == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interview == null)
            {
                return NotFound();
            }

            return View(interview);
        }

        // GET: Admin/AdminInterviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminInterviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InterDate,Static,FullName")] Interview interview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(interview);
        }

        // GET: Admin/AdminInterviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Interviews == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews.FindAsync(id);
            if (interview == null)
            {
                return NotFound();
            }
            return View(interview);
        }

        // POST: Admin/AdminInterviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InterDate,Static,FullName")] Interview interview)
        {
            if (id != interview.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterviewExists(interview.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(interview);
        }

        // GET: Admin/AdminInterviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Interviews == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interview == null)
            {
                return NotFound();
            }

            return View(interview);
        }

        // POST: Admin/AdminInterviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Interviews == null)
            {
                return Problem("Entity set 'AbcCvContext.Interviews'  is null.");
            }
            var interview = await _context.Interviews.FindAsync(id);
            if (interview != null)
            {
                _context.Interviews.Remove(interview);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterviewExists(int id)
        {
          return (_context.Interviews?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
