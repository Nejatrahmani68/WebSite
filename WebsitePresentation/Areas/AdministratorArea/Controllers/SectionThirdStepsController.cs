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
    public class SectionThirdStepsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectionThirdStepsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdministratorArea/SectionThirdSteps
        public async Task<IActionResult> Index(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.SectionThirdSteps.Where(m => m.Id_SectionSecondStep == idTemp).Include(s => s.SectionSecondStep);
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");

        }

        // GET: AdministratorArea/SectionThirdSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SectionThirdSteps == null)
            {
                return NotFound();
            }

            var sectionThirdStep = await _context.SectionThirdSteps
                .Include(s => s.SectionSecondStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionThirdStep == null)
            {
                return NotFound();
            }

            return View(sectionThirdStep);
        }

        // GET: AdministratorArea/SectionThirdSteps/Create
        public IActionResult Create(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                ViewData["Id_SectionSecondStep"] = new SelectList(_context.SectionSecondSteps.Where(m => m.Id == idTemp), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionThirdSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Id_SectionSecondStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionThirdStep sectionThirdStep)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sectionThirdStep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { @idTemp = sectionThirdStep.Id_SectionSecondStep });
            }
            ViewData["Id_SectionSecondStep"] = new SelectList(_context.SectionSecondSteps, "Id", "Name", sectionThirdStep.Id_SectionSecondStep);
            ViewBag.idTemp = sectionThirdStep.Id_SectionSecondStep;
            return View(sectionThirdStep);
        }

        // GET: AdministratorArea/SectionThirdSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SectionThirdSteps == null)
            {
                return NotFound();
            }

            var sectionThirdStep = await _context.SectionThirdSteps.FindAsync(id);
            if (sectionThirdStep == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionSecondStep"] = new SelectList(_context.SectionSecondSteps.Where(m => m.Id == sectionThirdStep.Id_SectionSecondStep), "Id", "Name", sectionThirdStep.Id_SectionSecondStep);
            return View(sectionThirdStep);
        }

        // POST: AdministratorArea/SectionThirdSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Id_SectionSecondStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionThirdStep sectionThirdStep)
        {
            if (id != sectionThirdStep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionThirdStep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionThirdStepExists(sectionThirdStep.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { @idTemp = sectionThirdStep.Id_SectionSecondStep });
            }
            ViewData["Id_SectionSecondStep"] = new SelectList(_context.SectionSecondSteps, "Id", "Name", sectionThirdStep.Id_SectionSecondStep);
            return View(sectionThirdStep);
        }

        // GET: AdministratorArea/SectionThirdSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SectionThirdSteps == null)
            {
                return NotFound();
            }

            var sectionThirdStep = await _context.SectionThirdSteps
                .Include(s => s.SectionSecondStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionThirdStep == null)
            {
                return NotFound();
            }

            return View(sectionThirdStep);
        }

        // POST: AdministratorArea/SectionThirdSteps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SectionThirdSteps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionThirdSteps'  is null.");
            }
            var sectionThirdStep = await _context.SectionThirdSteps.FindAsync(id);
            if (sectionThirdStep != null)
            {
                _context.SectionThirdSteps.Remove(sectionThirdStep);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionThirdStepExists(int id)
        {
            return _context.SectionThirdSteps.Any(e => e.Id == id);
        }
    }
}
