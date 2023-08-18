using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Services;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Admin,Administrator")]
    public class SectionPostFilesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;
        [Obsolete]
        private readonly IHostingEnvironment _env;

        [Obsolete]
        public SectionPostFilesController(ApplicationDbContext context, IHostingEnvironment env, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _env = env;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: AdministratorArea/SectionPostFiles
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
                var applicationDbContext = _context.SectionPostFiles!.Where(m => m.Id_SectionPostStep == idTemp).OrderByDescending(m => m.CreateDate).Include(s => s.SectionPostStep);
                var ParentDetail = _context.SectionPostSteps!.Find(idTemp);
                ViewBag.ParentDetail = ParentDetail!.Id + "-" + ParentDetail!.Title;
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostFiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostFiles == null)
            {
                return NotFound();
            }

            var sectionPostFile = await _context.SectionPostFiles
                .Include(s => s.SectionPostStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostFile == null)
            {
                return NotFound();
            }

            return View(sectionPostFile);
        }

        // GET: AdministratorArea/SectionPostFiles/Create
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

        // POST: AdministratorArea/SectionPostFiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create(List<IFormFile> files, [Bind("Title,FileAddress,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostFile sectionPostFile, int idTemp)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                sectionPostFile.Email = User.Identity!.Name;
                long size = files.Sum(f => f.Length);
                var filePaths = new List<string>();
                foreach (var formFile in files)
                {
                    if (formFile.Length > 0)
                    {
                        // full path to file in temp location
                        string newFilename = sectionPostFile.Id_SectionPostStep + "-" + Guid.NewGuid().ToString() + Path.GetExtension(formFile.FileName);
                        string filePath = Path.Combine(_env.WebRootPath, "Files", "PostFiles", newFilename);
                        filePaths.Add(filePath);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                        SectionPostFile sectionPostFileForAll = new SectionPostFile();
                        sectionPostFileForAll.Id_SectionPostStep = sectionPostFile.Id_SectionPostStep;
                        sectionPostFileForAll.Active = sectionPostFile.Active;
                        sectionPostFileForAll.Timable = sectionPostFile.Timable;
                        sectionPostFileForAll.Title = sectionPostFile.Title;
                        sectionPostFileForAll.Email = sectionPostFile.Email;
                        sectionPostFileForAll.StartDate = sectionPostFile.StartDate;
                        sectionPostFileForAll.EndDate = sectionPostFile.EndDate;
                        sectionPostFileForAll.TagsName = sectionPostFile.TagsName;
                        sectionPostFileForAll.Email = sectionPostFile.Email;
                        sectionPostFileForAll.FileAddress = newFilename;
                        if (formFile.Length < 1024)
                        {
                            sectionPostFileForAll.FileSize = formFile.Length.ToString() + "B";
                        }
                        if (formFile.Length >= 1024 && formFile.Length<1048576)
                        {
                            sectionPostFileForAll.FileSize = (formFile.Length/1024).ToString()+"KB";
                        }
                        if (formFile.Length >= 1048576 )
                        {
                            sectionPostFileForAll.FileSize = (formFile.Length / 1048576).ToString()+"MB";
                        }
                        sectionPostFileForAll.FileType = Path.GetExtension(formFile.FileName);
                        _context.Add(sectionPostFileForAll);
                        await _context.SaveChangesAsync();
                    }
                }
                return RedirectToAction("Index", new { @idTemp = sectionPostFile.Id_SectionPostStep });
            }
            ViewBag.idTemp = idTemp;
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps!.Where(m => m.Id == sectionPostFile.Id_SectionPostStep), "Id", "Title", sectionPostFile.Id_SectionPostStep);
            return View(sectionPostFile);
        }

        // GET: AdministratorArea/SectionPostFiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostFiles == null)
            {
                return NotFound();
            }

            var sectionPostFile = await _context.SectionPostFiles.FindAsync(id);
            if (sectionPostFile == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps!.Where(m => m.Id == sectionPostFile.Id_SectionPostStep), "Id", "Title", sectionPostFile.Id_SectionPostStep);
            return View(sectionPostFile);
        }

        // POST: AdministratorArea/SectionPostFiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,FileAddress,FileType,FileSize,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostFile sectionPostFile)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != sectionPostFile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionPostFile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionPostFileExists(sectionPostFile.Id))
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
            ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps, "Id", "Title", sectionPostFile.Id_SectionPostStep);
            return View(sectionPostFile);
        }

        // GET: AdministratorArea/SectionPostFiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionPostFiles == null)
            {
                return NotFound();
            }

            var sectionPostFile = await _context.SectionPostFiles
                .Include(s => s.SectionPostStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionPostFile == null)
            {
                return NotFound();
            }

            return View(sectionPostFile);
        }

        // POST: AdministratorArea/SectionPostFiles/Delete/5
        [Authorize(Roles = "Delete,Administrator,FullWriter")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (_context.SectionPostFiles == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionPostFiles'  is null.");
            }
            var sectionPostFile = await _context.SectionPostFiles.FindAsync(id);
            if (sectionPostFile != null)
            {
                _context.SectionPostFiles.Remove(sectionPostFile);
                if (sectionPostFile.FileAddress != null)
                {
                    string pictureAddress = Path.Combine(_env.WebRootPath, "Files", "PostFiles", sectionPostFile.FileAddress);
                    if (System.IO.File.Exists(pictureAddress))
                    {
                        System.IO.File.Delete(pictureAddress);
                    }
                }
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { @idTemp = sectionPostFile!.Id_SectionPostStep });
        }

        private bool SectionPostFileExists(int id)
        {
          return _context.SectionPostFiles!.Any(e => e.Id == id);
        }
    }
}
