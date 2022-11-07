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
    public class SectionPostCommentStepsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectionPostCommentStepsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdministratorArea/SectionPostCommentSteps
        public async Task<IActionResult> Index(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.SectionPostCommentSteps.Where(m => m.Id_SectionPostStep == idTemp).Include(s => s.SectionPostStep);
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostCommentSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SectionPostCommentSteps == null)
            {
                return NotFound();
            }

            var sectionPostCommentStep = await _context.SectionPostCommentSteps
                .Include(s => s.SectionPostStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostCommentStep == null)
            {
                return NotFound();
            }

            return View(sectionPostCommentStep);
        }

        // GET: AdministratorArea/SectionPostCommentSteps/Create
        public IActionResult Create(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == idTemp), "Id", "Title");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionPostCommentSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Comment,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionPostCommentStep sectionPostCommentStep, int idTemp)
        {
            if (ModelState.IsValid)
            {
                sectionPostCommentStep.Email = User.Identity!.Name;
                _context.Add(sectionPostCommentStep);
                await _context.SaveChangesAsync();
                idTemp = _context.SectionPostSteps.Find(idTemp)!.Id_SectionThirdStep;
                return RedirectToAction(nameof(Index), "SectionPostSteps", new { @idTemp = idTemp });
            }
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == sectionPostCommentStep.Id_SectionPostStep), "Id", "Title", sectionPostCommentStep.Id_SectionPostStep);
            return View(sectionPostCommentStep);
        }

        // GET: AdministratorArea/SectionPostCommentSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SectionPostCommentSteps == null)
            {
                return NotFound();
            }

            var sectionPostCommentStep = await _context.SectionPostCommentSteps.FindAsync(id);
            if (sectionPostCommentStep == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == sectionPostCommentStep.Id_SectionPostStep), "Id", "Title", sectionPostCommentStep.Id_SectionPostStep);
            return View(sectionPostCommentStep);
        }

        // POST: AdministratorArea/SectionPostCommentSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Comment,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostCommentStep sectionPostCommentStep)
        {
            if (id != sectionPostCommentStep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionPostCommentStep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionPostCommentStepExists(sectionPostCommentStep.Id))
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
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps, "Id", "Name", sectionPostCommentStep.Id_SectionPostStep);
            return View(sectionPostCommentStep);
        }

        // GET: AdministratorArea/SectionPostCommentSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SectionPostCommentSteps == null)
            {
                return NotFound();
            }

            var sectionPostCommentStep = await _context.SectionPostCommentSteps
                .Include(s => s.SectionPostStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostCommentStep == null)
            {
                return NotFound();
            }

            return View(sectionPostCommentStep);
        }

        // POST: AdministratorArea/SectionPostCommentSteps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SectionPostCommentSteps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionPostCommentSteps'  is null.");
            }
            var sectionPostCommentStep = await _context.SectionPostCommentSteps.FindAsync(id);
            if (sectionPostCommentStep != null)
            {
                _context.SectionPostCommentSteps.Remove(sectionPostCommentStep);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { @idTemp = sectionPostCommentStep.Id_SectionPostStep });
        }

        private bool SectionPostCommentStepExists(int id)
        {
            return _context.SectionPostCommentSteps.Any(e => e.Id == id);
        }
    }
}
