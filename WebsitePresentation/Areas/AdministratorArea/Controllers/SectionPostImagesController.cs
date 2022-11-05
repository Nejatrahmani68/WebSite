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
    public class SectionPostImagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectionPostImagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdministratorArea/SectionPostImages
        public async Task<IActionResult> Index(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.SectionPostImages.Where(m => m.Id_SectionPostStep == idTemp).Include(s => s.SectionPostStep);
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SectionPostImages == null)
            {
                return NotFound();
            }

            var sectionPostImage = await _context.SectionPostImages
                .Include(s => s.SectionPostStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostImage == null)
            {
                return NotFound();
            }

            return View(sectionPostImage);
        }

        // GET: AdministratorArea/SectionPostImages/Create
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

        // POST: AdministratorArea/SectionPostImages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,PictureAddress,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName"),] SectionPostImage sectionPostImage, int idTemp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sectionPostImage);
                await _context.SaveChangesAsync();
                idTemp = _context.SectionPostSteps.Find(idTemp)!.Id_SectionThirdStep;
                return RedirectToAction(nameof(Index), "SectionPostSteps", new { @idTemp = idTemp });
            }
            ViewBag.idTemp = idTemp;
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == sectionPostImage.Id_SectionPostStep), "Id", "Title", sectionPostImage.Id_SectionPostStep);
            return View(sectionPostImage);
        }

        // GET: AdministratorArea/SectionPostImages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SectionPostImages == null)
            {
                return NotFound();
            }

            var sectionPostImage = await _context.SectionPostImages.FindAsync(id);
            if (sectionPostImage == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == sectionPostImage.Id_SectionPostStep), "Id", "Title", sectionPostImage.Id_SectionPostStep);
            return View(sectionPostImage);
        }

        // POST: AdministratorArea/SectionPostImages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,PictureAddress,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostImage sectionPostImage)
        {
            if (id != sectionPostImage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionPostImage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionPostImageExists(sectionPostImage.Id))
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
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps, "Id", "Title", sectionPostImage.Id_SectionPostStep);
            return View(sectionPostImage);
        }

        // GET: AdministratorArea/SectionPostImages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SectionPostImages == null)
            {
                return NotFound();
            }

            var sectionPostImage = await _context.SectionPostImages
                .Include(s => s.SectionPostStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostImage == null)
            {
                return NotFound();
            }

            return View(sectionPostImage);
        }

        // POST: AdministratorArea/SectionPostImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SectionPostImages == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionPostImages'  is null.");
            }
            var sectionPostImage = await _context.SectionPostImages.FindAsync(id);
            if (sectionPostImage != null)
            {
                _context.SectionPostImages.Remove(sectionPostImage);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionPostImageExists(int id)
        {
            return _context.SectionPostImages.Any(e => e.Id == id);
        }
    }
}
