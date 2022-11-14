using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using DataAccess.Services;
using X.PagedList;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Admin,Administrator")]
    public class SectionPostStepsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectionPostStepsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdministratorArea/SectionPostSteps
        public async Task<IActionResult> Index(int? idTemp, int? page)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 50;
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.SectionPostSteps.Where(m => m.Id_SectionThirdStep == idTemp).Include(s => s.SectionPostType).Include(s => s.SectionThirdStep);
                return View(await applicationDbContext.ToPagedListAsync(pageNumber, PageSize));
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostSteps
        public async Task<IActionResult> IndexByPostType(int? idTemp, int? page)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 50;
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.SectionPostSteps.Where(m => m.Id_SectionPostType == idTemp).Include(s => s.SectionPostType).Include(s => s.SectionThirdStep);
                return View(await applicationDbContext.ToPagedListAsync(pageNumber, PageSize));
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }
        // GET: AdministratorArea/SectionPostSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostSteps == null)
            {
                return NotFound();
            }

            var sectionPostStep = await _context.SectionPostSteps
                .Include(s => s.SectionPostType)
                .Include(s => s.SectionThirdStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostStep == null)
            {
                return NotFound();
            }

            return View(sectionPostStep);
        }

        // GET: AdministratorArea/SectionPostSteps/Create
        public IActionResult Create(int? idTemp)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                ViewData["Id_SectionPostType"] = new SelectList(_context.SectionPostTypes, "Id", "Title");
                ViewData["Id_SectionThirdStep"] = new SelectList(_context.SectionThirdSteps.Where(m => m.Id == idTemp), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionPostSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_SectionPostType,Id_SectionThirdStep,Title,ShortDescription,FullDescription,ViewsNumber,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionPostStep sectionPostStep)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                sectionPostStep.Email = User.Identity!.Name;
                _context.Add(sectionPostStep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create), "SectionPostVideos", new {@idTemp=sectionPostStep.Id});
            }
            ViewData["Id_SectionPostType"] = new SelectList(_context.SectionPostTypes, "Id", "Title", sectionPostStep.Id_SectionPostType);
            ViewData["Id_SectionThirdStep"] = new SelectList(_context.SectionThirdSteps, "Id", "Name", sectionPostStep.Id_SectionThirdStep);
            ViewBag.idTemp = sectionPostStep.Id_SectionThirdStep;
            return View(sectionPostStep);
        }

        // GET: AdministratorArea/SectionPostSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostSteps == null)
            {
                return NotFound();
            }

            var sectionPostStep = await _context.SectionPostSteps.FindAsync(id);
            if (sectionPostStep == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionPostType"] = new SelectList(_context.SectionPostTypes, "Id", "Title", sectionPostStep.Id_SectionPostType);
            ViewData["Id_SectionThirdStep"] = new SelectList(_context.SectionThirdSteps.Where(m => m.Id==sectionPostStep.Id_SectionThirdStep), "Id", "Name", sectionPostStep.Id_SectionThirdStep);
            return View(sectionPostStep);
        }

        // POST: AdministratorArea/SectionPostSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_SectionPostType,Id_SectionThirdStep,Title,ShortDescription,FullDescription,ViewsNumber,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostStep sectionPostStep)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != sectionPostStep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionPostStep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionPostStepExists(sectionPostStep.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { @idTemp = sectionPostStep.Id_SectionThirdStep });
            }
            ViewData["Id_SectionPostType"] = new SelectList(_context.SectionPostTypes, "Id", "Title", sectionPostStep.Id_SectionPostType);
            ViewData["Id_SectionThirdStep"] = new SelectList(_context.SectionThirdSteps, "Id", "Name", sectionPostStep.Id_SectionThirdStep);
            return View(sectionPostStep);
        }

        // GET: AdministratorArea/SectionPostSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostSteps == null)
            {
                return NotFound();
            }

            var sectionPostStep = await _context.SectionPostSteps
                .Include(s => s.SectionPostType)
                .Include(s => s.SectionThirdStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostStep == null)
            {
                return NotFound();
            }

            return View(sectionPostStep);
        }

        // POST: AdministratorArea/SectionPostSteps/Delete/5
        [Authorize(Roles = "Delete,Administrator,FullWriter")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (_context.SectionPostSteps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionPostSteps'  is null.");
            }
            var sectionPostStep = await _context.SectionPostSteps.FindAsync(id);
            if (sectionPostStep != null)
            {
                _context.SectionPostSteps.Remove(sectionPostStep);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { @idTemp = sectionPostStep!.Id_SectionThirdStep });
        }

        private bool SectionPostStepExists(int id)
        {
            return _context.SectionPostSteps.Any(e => e.Id == id);
        }
    }
}
