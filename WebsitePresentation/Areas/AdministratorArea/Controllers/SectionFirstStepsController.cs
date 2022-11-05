using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    public class SectionFirstStepsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectionFirstStepsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdministratorArea/SectionFirstSteps
        public async Task<IActionResult> Index()
        {
              return View(await _context.SectionFirstSteps.ToListAsync());
        }

        // GET: AdministratorArea/SectionFirstSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SectionFirstSteps == null)
            {
                return NotFound();
            }

            var sectionFirstStep = await _context.SectionFirstSteps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionFirstStep == null)
            {
                return NotFound();
            }

            return View(sectionFirstStep);
        }

        // GET: AdministratorArea/SectionFirstSteps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdministratorArea/SectionFirstSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionFirstStep sectionFirstStep)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sectionFirstStep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sectionFirstStep);
        }

        // GET: AdministratorArea/SectionFirstSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SectionFirstSteps == null)
            {
                return NotFound();
            }

            var sectionFirstStep = await _context.SectionFirstSteps.FindAsync(id);
            if (sectionFirstStep == null)
            {
                return NotFound();
            }
            return View(sectionFirstStep);
        }

        // POST: AdministratorArea/SectionFirstSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionFirstStep sectionFirstStep)
        {
            if (id != sectionFirstStep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionFirstStep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionFirstStepExists(sectionFirstStep.Id))
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
            return View(sectionFirstStep);
        }

        // GET: AdministratorArea/SectionFirstSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SectionFirstSteps == null)
            {
                return NotFound();
            }

            var sectionFirstStep = await _context.SectionFirstSteps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionFirstStep == null)
            {
                return NotFound();
            }

            return View(sectionFirstStep);
        }

        // POST: AdministratorArea/SectionFirstSteps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SectionFirstSteps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionFirstSteps'  is null.");
            }
            var sectionFirstStep = await _context.SectionFirstSteps.FindAsync(id);
            if (sectionFirstStep != null)
            {
                _context.SectionFirstSteps.Remove(sectionFirstStep);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionFirstStepExists(int id)
        {
          return _context.SectionFirstSteps.Any(e => e.Id == id);
        }
    }
}
