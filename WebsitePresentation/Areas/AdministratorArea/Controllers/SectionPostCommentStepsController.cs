using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using DataAccess.Services;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Admin,Administrator")]
    public class SectionPostCommentStepsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;

        public SectionPostCommentStepsController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: AdministratorArea/SectionPostCommentSteps
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
                var applicationDbContext = _context.SectionPostCommentSteps!.Where(m => m.Id_SectionPostStep == idTemp).Include(s => s.SectionPostStep).OrderByDescending(m=>m.CreateDate);
                var ParentDetail = _context.SectionPostSteps!.Find(idTemp);
                ViewBag.ParentDetail = ParentDetail!.Id + "-" + ParentDetail!.Title;
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostCommentSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps!.Where(m => m.Id == idTemp), "Id", "Title");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionPostCommentSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Comment,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionPostCommentStep sectionPostCommentStep, int idTemp)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                sectionPostCommentStep.Email = User.Identity!.Name;
                _context.Add(sectionPostCommentStep);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { @idTemp = sectionPostCommentStep.Id_SectionPostStep });
            }
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps!.Where(m => m.Id == sectionPostCommentStep.Id_SectionPostStep), "Id", "Title", sectionPostCommentStep.Id_SectionPostStep);
            return View(sectionPostCommentStep);
        }

        // GET: AdministratorArea/SectionPostCommentSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostCommentSteps == null)
            {
                return NotFound();
            }

            var sectionPostCommentStep = await _context.SectionPostCommentSteps.FindAsync(id);
            if (sectionPostCommentStep == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps!.Where(m => m.Id == sectionPostCommentStep.Id_SectionPostStep), "Id", "Title", sectionPostCommentStep.Id_SectionPostStep);
            return View(sectionPostCommentStep);
        }

        // POST: AdministratorArea/SectionPostCommentSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Comment,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostCommentStep sectionPostCommentStep)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            return RedirectToAction(nameof(Index), new { @idTemp = sectionPostCommentStep!.Id_SectionPostStep });
        }

        private bool SectionPostCommentStepExists(int id)
        {
            return _context.SectionPostCommentSteps!.Any(e => e.Id == id);
        }
    }
}
