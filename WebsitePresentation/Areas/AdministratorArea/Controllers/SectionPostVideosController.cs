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
    public class SectionPostVideosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectionPostVideosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdministratorArea/SectionPostVideos
        public async Task<IActionResult> Index(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.SectionPostVideos.Where(m => m.Id_SectionPostStep == idTemp).Include(s => s.SectionPostSocialVideo).Include(s => s.SectionPostStep);
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostVideos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SectionPostVideos == null)
            {
                return NotFound();
            }

            var sectionPostVideo = await _context.SectionPostVideos
                .Include(s => s.SectionPostSocialVideo)
                .Include(s => s.SectionPostStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostVideo == null)
            {
                return NotFound();
            }

            return View(sectionPostVideo);
        }

        // GET: AdministratorArea/SectionPostVideos/Create
        public IActionResult Create(int? idTemp)
        {
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                ViewData["Id_SectionPostSocialVideo"] = new SelectList(_context.SectionPostSocialVideos, "Id", "Title");
                ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == idTemp), "Id", "Title");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionPostVideos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Id_SectionPostSocialVideo,VideoAddress,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostVideo sectionPostVideo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sectionPostVideo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create), "SectionPostImages", new { @idTemp = sectionPostVideo.Id_SectionPostStep });
            }
            ViewData["Id_SectionPostSocialVideo"] = new SelectList(_context.SectionPostSocialVideos, "Id", "Title", sectionPostVideo.Id_SectionPostSocialVideo);
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == sectionPostVideo.Id_SectionPostStep), "Id", "Title", sectionPostVideo.Id_SectionPostStep);
            ViewBag.idTemp = sectionPostVideo.Id_SectionPostStep;
            return View(sectionPostVideo);
        }

        // GET: AdministratorArea/SectionPostVideos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SectionPostVideos == null)
            {
                return NotFound();
            }

            var sectionPostVideo = await _context.SectionPostVideos.FindAsync(id);
            if (sectionPostVideo == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionPostSocialVideo"] = new SelectList(_context.SectionPostSocialVideos, "Id", "Title", sectionPostVideo.Id_SectionPostSocialVideo);
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == sectionPostVideo.Id_SectionPostStep), "Id", "Title", sectionPostVideo.Id_SectionPostStep);
            return View(sectionPostVideo);
        }

        // POST: AdministratorArea/SectionPostVideos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Id_SectionPostSocialVideo,VideoAddress,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostVideo sectionPostVideo)
        {
            if (id != sectionPostVideo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionPostVideo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionPostVideoExists(sectionPostVideo.Id))
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
            ViewData["Id_SectionPostSocialVideo"] = new SelectList(_context.SectionPostSocialVideos, "Id", "Title", sectionPostVideo.Id_SectionPostSocialVideo);
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps, "Id", "Title", sectionPostVideo.Id_SectionPostStep);
            return View(sectionPostVideo);
        }

        // GET: AdministratorArea/SectionPostVideos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SectionPostVideos == null)
            {
                return NotFound();
            }

            var sectionPostVideo = await _context.SectionPostVideos
                .Include(s => s.SectionPostSocialVideo)
                .Include(s => s.SectionPostStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostVideo == null)
            {
                return NotFound();
            }

            return View(sectionPostVideo);
        }

        // POST: AdministratorArea/SectionPostVideos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SectionPostVideos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionPostVideos'  is null.");
            }
            var sectionPostVideo = await _context.SectionPostVideos.FindAsync(id);
            if (sectionPostVideo != null)
            {
                _context.SectionPostVideos.Remove(sectionPostVideo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionPostVideoExists(int id)
        {
            return _context.SectionPostVideos.Any(e => e.Id == id);
        }
    }
}
