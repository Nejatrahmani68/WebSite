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
    public class SectionPostTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectionPostTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdministratorArea/SectionPostTypes
        public async Task<IActionResult> Index()
        {
              return View(await _context.SectionPostTypes.ToListAsync());
        }

        // GET: AdministratorArea/SectionPostTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SectionPostTypes == null)
            {
                return NotFound();
            }

            var sectionPostType = await _context.SectionPostTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostType == null)
            {
                return NotFound();
            }

            return View(sectionPostType);
        }

        // GET: AdministratorArea/SectionPostTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdministratorArea/SectionPostTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionPostType sectionPostType)
        {
            if (ModelState.IsValid)
            {
                sectionPostType.Email = User.Identity!.Name;
                _context.Add(sectionPostType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sectionPostType);
        }

        // GET: AdministratorArea/SectionPostTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SectionPostTypes == null)
            {
                return NotFound();
            }

            var sectionPostType = await _context.SectionPostTypes.FindAsync(id);
            if (sectionPostType == null)
            {
                return NotFound();
            }
            return View(sectionPostType);
        }

        // POST: AdministratorArea/SectionPostTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostType sectionPostType)
        {
            if (id != sectionPostType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionPostType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionPostTypeExists(sectionPostType.Id))
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
            return View(sectionPostType);
        }

        // GET: AdministratorArea/SectionPostTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SectionPostTypes == null)
            {
                return NotFound();
            }

            var sectionPostType = await _context.SectionPostTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostType == null)
            {
                return NotFound();
            }

            return View(sectionPostType);
        }

        // POST: AdministratorArea/SectionPostTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SectionPostTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionPostTypes'  is null.");
            }
            var sectionPostType = await _context.SectionPostTypes.FindAsync(id);
            if (sectionPostType != null)
            {
                _context.SectionPostTypes.Remove(sectionPostType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionPostTypeExists(int id)
        {
          return _context.SectionPostTypes.Any(e => e.Id == id);
        }
    }
}
