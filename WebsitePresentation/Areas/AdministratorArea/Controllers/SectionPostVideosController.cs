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
    public class SectionPostVideosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;

        public SectionPostVideosController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: AdministratorArea/SectionPostVideos
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
                var applicationDbContext = _context.SectionPostVideos!.Where(m => m.Id_SectionPostStep == idTemp).OrderByDescending(m => m.CreateDate).Include(s => s.SectionPostSocialVideo).Include(s => s.SectionPostStep);
                var ParentDetail = _context.SectionPostSteps!.Find(idTemp);
                ViewBag.ParentDetail = ParentDetail!.Id + "-" + ParentDetail!.Title;
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostVideos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
        [Authorize(Roles = "Add,Administrator,FullWriter")]
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
                ViewData["Id_SectionPostSocialVideo"] = new SelectList(_context.SectionPostSocialVideos, "Id", "Title");
                ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps!.Where(m => m.Id == idTemp), "Id", "Title");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionPostVideos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Id_SectionPostSocialVideo,VideoAddress,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionPostVideo sectionPostVideo)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                sectionPostVideo.Email = User.Identity!.Name;
                _context.Add(sectionPostVideo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { @idTemp = sectionPostVideo.Id_SectionPostStep });
            }
            ViewData["Id_SectionPostSocialVideo"] = new SelectList(_context.SectionPostSocialVideos, "Id", "Title", sectionPostVideo.Id_SectionPostSocialVideo);
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps!.Where(m => m.Id == sectionPostVideo.Id_SectionPostStep), "Id", "Title", sectionPostVideo.Id_SectionPostStep);
            ViewBag.idTemp = sectionPostVideo.Id_SectionPostStep;
            return View(sectionPostVideo);
        }

        // GET: AdministratorArea/SectionPostVideos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps!.Where(m => m.Id == sectionPostVideo.Id_SectionPostStep), "Id", "Title", sectionPostVideo.Id_SectionPostStep);
            return View(sectionPostVideo);
        }

        // POST: AdministratorArea/SectionPostVideos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Id_SectionPostSocialVideo,VideoAddress,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostVideo sectionPostVideo)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
                return RedirectToAction(nameof(Index), new { @idTemp = sectionPostVideo.Id_SectionPostStep });
            }
            ViewData["Id_SectionPostSocialVideo"] = new SelectList(_context.SectionPostSocialVideos, "Id", "Title", sectionPostVideo.Id_SectionPostSocialVideo);
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps, "Id", "Title", sectionPostVideo.Id_SectionPostStep);
            return View(sectionPostVideo);
        }

        // GET: AdministratorArea/SectionPostVideos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            return RedirectToAction(nameof(Index), new { @idTemp = sectionPostVideo!.Id_SectionPostStep });
        }

        private bool SectionPostVideoExists(int id)
        {
            return _context.SectionPostVideos!.Any(e => e.Id == id);
        }
    }
}
