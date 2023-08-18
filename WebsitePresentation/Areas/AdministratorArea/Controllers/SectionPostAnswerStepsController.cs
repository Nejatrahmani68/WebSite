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
    public class SectionPostAnswerStepsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;

        public SectionPostAnswerStepsController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: AdministratorArea/SectionPostAnswerSteps
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
                var applicationDbContext = _context.SectionPostAnswerSteps!.Where(m => m.Id_SectionPostCommentStep == idTemp).Include(s => s.SectionPostCommentStep).OrderByDescending(m => m.CreateDate);
                var ParentDetail = _context.SectionPostCommentSteps!.Find(idTemp);
                ViewBag.ParentDetail = ParentDetail!.Id + "-" + ParentDetail!.Comment; 
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostAnswerSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostAnswerSteps == null)
            {
                return NotFound();
            }

            var sectionPostAnswerStep = await _context.SectionPostAnswerSteps
                .Include(s => s.SectionPostCommentStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostAnswerStep == null)
            {
                return NotFound();
            }

            return View(sectionPostAnswerStep);
        }

        // GET: AdministratorArea/SectionPostAnswerSteps/Create
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
                ViewData["Id_SectionPostCommentStep"] = new SelectList(_context.SectionPostCommentSteps!.Where(m => m.Id == idTemp), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionPostAnswerSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Answer,Id_SectionPostCommentStep,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionPostAnswerStep sectionPostAnswerStep, int idTemp)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                sectionPostAnswerStep.Email = User.Identity!.Name;
                _context.Add(sectionPostAnswerStep);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { @idTemp = sectionPostAnswerStep.Id_SectionPostCommentStep });
            }
            ViewData["Id_SectionPostCommentStep"] = new SelectList(_context.SectionPostCommentSteps!.Where(m => m.Id == sectionPostAnswerStep.Id_SectionPostCommentStep), "Id", "Name", sectionPostAnswerStep.Id_SectionPostCommentStep);
            return View(sectionPostAnswerStep);
        }

        // GET: AdministratorArea/SectionPostAnswerSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostAnswerSteps == null)
            {
                return NotFound();
            }

            var sectionPostAnswerStep = await _context.SectionPostAnswerSteps.FindAsync(id);
            if (sectionPostAnswerStep == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionPostCommentStep"] = new SelectList(_context.SectionPostCommentSteps!.Where(m => m.Id == sectionPostAnswerStep.Id_SectionPostCommentStep), "Id", "Name", sectionPostAnswerStep.Id_SectionPostCommentStep);
            return View(sectionPostAnswerStep);
        }

        // POST: AdministratorArea/SectionPostAnswerSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Answer,Id_SectionPostCommentStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostAnswerStep sectionPostAnswerStep)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != sectionPostAnswerStep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionPostAnswerStep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionPostAnswerStepExists(sectionPostAnswerStep.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { @idTemp = sectionPostAnswerStep.Id_SectionPostCommentStep });
            }
            ViewData["Id_SectionPostCommentStep"] = new SelectList(_context.SectionPostCommentSteps, "Id", "Name", sectionPostAnswerStep.Id_SectionPostCommentStep);
            return View(sectionPostAnswerStep);
        }

        // GET: AdministratorArea/SectionPostAnswerSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostAnswerSteps == null)
            {
                return NotFound();
            }

            var sectionPostAnswerStep = await _context.SectionPostAnswerSteps
                .Include(s => s.SectionPostCommentStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostAnswerStep == null)
            {
                return NotFound();
            }

            return View(sectionPostAnswerStep);
        }

        // POST: AdministratorArea/SectionPostAnswerSteps/Delete/5
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
            if (_context.SectionPostAnswerSteps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionPostAnswerSteps'  is null.");
            }
            var sectionPostAnswerStep = await _context.SectionPostAnswerSteps.FindAsync(id);
            if (sectionPostAnswerStep != null)
            {
                _context.SectionPostAnswerSteps.Remove(sectionPostAnswerStep);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { @idTemp = sectionPostAnswerStep!.Id_SectionPostCommentStep });
        }

        private bool SectionPostAnswerStepExists(int id)
        {
            return _context.SectionPostAnswerSteps!.Any(e => e.Id == id);
        }
    }
}
