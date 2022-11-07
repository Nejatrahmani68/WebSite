using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using DataAccess.Services;
using Model.ViewModels;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    public class SectionSecondStepsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ViewModelHomePage _viewModelHomPage;

        public SectionSecondStepsController(ApplicationDbContext context, ViewModelHomePage viewModelHomPage)
        {
            _context = context;
            _viewModelHomPage = viewModelHomPage;
        }

        // GET: AdministratorArea/SectionSecondSteps
        public async Task<IActionResult> Index(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.SectionSecondSteps.Where(m => m.Id_SectionFirstStep == idTemp).Include(s => s.SectionFirstStep);
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionSecondSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SectionSecondSteps == null)
            {
                return NotFound();
            }

            var sectionSecondStep = await _context.SectionSecondSteps
                .Include(s => s.SectionFirstStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionSecondStep == null)
            {
                return NotFound();
            }

            return View(sectionSecondStep);
        }

        // GET: AdministratorArea/SectionSecondSteps/Create
        public IActionResult Create(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                ViewData["Id_SectionFirstStep"] = new SelectList(_context.SectionFirstSteps.Where(m=>m.Id== idTemp), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionSecondSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Id_SectionFirstStep,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionSecondStep sectionSecondStep)
        {
            if (ModelState.IsValid)
            {
                sectionSecondStep.Email = User.Identity!.Name;
                _context.Add(sectionSecondStep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { @idTemp = sectionSecondStep.Id_SectionFirstStep });
            }
            ViewData["Id_SectionFirstStep"] = new SelectList(_context.SectionFirstSteps, "Id", "Name", sectionSecondStep.Id_SectionFirstStep);
            ViewBag.idTemp = sectionSecondStep.Id_SectionFirstStep;
            return View(sectionSecondStep);
        }

        // GET: AdministratorArea/SectionSecondSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SectionSecondSteps == null)
            {
                return NotFound();
            }

            var sectionSecondStep = await _context.SectionSecondSteps.FindAsync(id);
            if (sectionSecondStep == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionFirstStep"] = new SelectList(_context.SectionFirstSteps.Where(m => m.Id == sectionSecondStep.Id_SectionFirstStep), "Id", "Name", sectionSecondStep.Id_SectionFirstStep);
            return View(sectionSecondStep);
        }

        // POST: AdministratorArea/SectionSecondSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Id_SectionFirstStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionSecondStep sectionSecondStep)
        {
            if (id != sectionSecondStep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionSecondStep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionSecondStepExists(sectionSecondStep.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { @idTemp = sectionSecondStep.Id_SectionFirstStep });
            }
            ViewData["Id_SectionFirstStep"] = new SelectList(_context.SectionFirstSteps, "Id", "Name", sectionSecondStep.Id_SectionFirstStep);
            return View(sectionSecondStep);
        }

        // GET: AdministratorArea/SectionSecondSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SectionSecondSteps == null)
            {
                return NotFound();
            }

            var sectionSecondStep = await _context.SectionSecondSteps
                .Include(s => s.SectionFirstStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionSecondStep == null)
            {
                return NotFound();
            }

            return View(sectionSecondStep);
        }

        // POST: AdministratorArea/SectionSecondSteps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SectionSecondSteps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionSecondSteps'  is null.");
            }
            var sectionSecondStep = await _context.SectionSecondSteps.FindAsync(id);
            if (sectionSecondStep != null)
            {
                _context.SectionSecondSteps.Remove(sectionSecondStep);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { @idTemp = sectionSecondStep.Id_SectionFirstStep });
        }

        private bool SectionSecondStepExists(int id)
        {
            return _context.SectionSecondSteps.Any(e => e.Id == id);
        }
    }
}
