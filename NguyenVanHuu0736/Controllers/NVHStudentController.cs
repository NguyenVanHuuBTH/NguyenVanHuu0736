using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVanHuu0736.Models;

namespace NguyenVanHuu0736.Controllers
{
    public class NVHStudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NVHStudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NVHStudent
        public async Task<IActionResult> Index()
        {
              return _context.NVHStudent != null ? 
                          View(await _context.NVHStudent.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NVHStudent'  is null.");
        }

        // GET: NVHStudent/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NVHStudent == null)
            {
                return NotFound();
            }

            var nVHStudent = await _context.NVHStudent
                .FirstOrDefaultAsync(m => m.NVHStudentId == id);
            if (nVHStudent == null)
            {
                return NotFound();
            }

            return View(nVHStudent);
        }

        // GET: NVHStudent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NVHStudent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NVHStudentId,NVHStudentName,NVHStudentDIACHI")] NVHStudent nVHStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nVHStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nVHStudent);
        }

        // GET: NVHStudent/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NVHStudent == null)
            {
                return NotFound();
            }

            var nVHStudent = await _context.NVHStudent.FindAsync(id);
            if (nVHStudent == null)
            {
                return NotFound();
            }
            return View(nVHStudent);
        }

        // POST: NVHStudent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NVHStudentId,NVHStudentName,NVHStudentDIACHI")] NVHStudent nVHStudent)
        {
            if (id != nVHStudent.NVHStudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nVHStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVHStudentExists(nVHStudent.NVHStudentId))
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
            return View(nVHStudent);
        }

        // GET: NVHStudent/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NVHStudent == null)
            {
                return NotFound();
            }

            var nVHStudent = await _context.NVHStudent
                .FirstOrDefaultAsync(m => m.NVHStudentId == id);
            if (nVHStudent == null)
            {
                return NotFound();
            }

            return View(nVHStudent);
        }

        // POST: NVHStudent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NVHStudent == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NVHStudent'  is null.");
            }
            var nVHStudent = await _context.NVHStudent.FindAsync(id);
            if (nVHStudent != null)
            {
                _context.NVHStudent.Remove(nVHStudent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NVHStudentExists(string id)
        {
          return (_context.NVHStudent?.Any(e => e.NVHStudentId == id)).GetValueOrDefault();
        }
    }
}
