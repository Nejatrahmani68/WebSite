using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using DataAccess.Services;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Admin,Administrator")]
    public class SectionSecondStepsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;

        public SectionSecondStepsController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: AdministratorArea/SectionSecondSteps
        public async Task<IActionResult> Index(int? idTemp)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.SectionSecondSteps!.Where(m => m.Id_SectionFirstStep == idTemp).OrderByDescending(m => m.CreateDate).Include(s => s.SectionFirstStep);
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionSecondSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                ViewData["Id_SectionFirstStep"] = new SelectList(_context.SectionFirstSteps!.Where(m => m.Id == idTemp), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionSecondSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Id_SectionFirstStep,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionSecondStep sectionSecondStep)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionSecondSteps == null)
            {
                return NotFound();
            }

            var sectionSecondStep = await _context.SectionSecondSteps.FindAsync(id);
            if (sectionSecondStep == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionFirstStep"] = new SelectList(_context.SectionFirstSteps!.Where(m => m.Id == sectionSecondStep.Id_SectionFirstStep), "Id", "Name", sectionSecondStep.Id_SectionFirstStep);
            return View(sectionSecondStep);
        }

        // POST: AdministratorArea/SectionSecondSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Id_SectionFirstStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionSecondStep sectionSecondStep)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
        [Authorize(Roles = "Delete,Administrator,FullWriter")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            return RedirectToAction(nameof(Index), new { @idTemp = sectionSecondStep!.Id_SectionFirstStep });
        }

        private bool SectionSecondStepExists(int id)
        {
            return _context.SectionSecondSteps!.Any(e => e.Id == id);
        }
    }
}
