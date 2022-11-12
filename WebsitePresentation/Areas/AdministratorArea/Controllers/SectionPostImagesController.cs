using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using DataAccess.Services;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Admin,Administrator")]
    public class SectionPostImagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _env;

        [Obsolete]
        public SectionPostImagesController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: AdministratorArea/SectionPostImages
        public async Task<IActionResult> Index(int? idTemp)
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
                var applicationDbContext = _context.SectionPostImages.Where(m => m.Id_SectionPostStep == idTemp).Include(s => s.SectionPostStep);
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // GET: AdministratorArea/SectionPostImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
                ViewData["Id_SectionPostStep"] = new SelectList(_context.SectionPostSteps.Where(m => m.Id == idTemp), "Id", "Title");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionPostImages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create(List<IFormFile> files, [Bind("Title,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,TagsName"),] SectionPostImage sectionPostImage, int idTemp)
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
                sectionPostImage.Email = User.Identity!.Name;
                long size = files.Sum(f => f.Length);
                var filePaths = new List<string>();
                foreach (var formFile in files)
                {
                    if (formFile.Length > 0)
                    {
                        // full path to file in temp location
                        string newFilename = sectionPostImage.Id_SectionPostStep + "-" + Guid.NewGuid().ToString() + Path.GetExtension(formFile.FileName);
                        string filePath = Path.Combine(_env.WebRootPath, "Images", "ImageLarge", newFilename);
                        filePaths.Add(filePath);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                        SectionPostImage sectionPostImageForAll = new SectionPostImage();
                        sectionPostImageForAll.Id_SectionPostStep = sectionPostImage.Id_SectionPostStep;
                        sectionPostImageForAll.Active = sectionPostImage.Active;
                        sectionPostImageForAll.Timable = sectionPostImage.Timable;
                        sectionPostImageForAll.Title = sectionPostImage.Title;
                        sectionPostImageForAll.Email = sectionPostImage.Email;
                        sectionPostImageForAll.StartDate = sectionPostImage.StartDate;
                        sectionPostImageForAll.EndDate = sectionPostImage.EndDate;
                        sectionPostImageForAll.TagsName = sectionPostImage.TagsName;
                        sectionPostImageForAll.Email = sectionPostImage.Email;
                        sectionPostImageForAll.PictureAddress = newFilename;
                        _context.Add(sectionPostImageForAll);
                        await _context.SaveChangesAsync();
                    }
                }
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
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,PictureAddress,Id_SectionPostStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionPostImage sectionPostImage)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
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
        [Authorize(Roles = "Delete,Administrator,FullWriter")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (_context.SectionPostImages == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionPostImages'  is null.");
            }
            var sectionPostImage = await _context.SectionPostImages.FindAsync(id);
            if (sectionPostImage != null)
            {
                _context.SectionPostImages.Remove(sectionPostImage);
                if (sectionPostImage.PictureAddress != null)
                {
                    string pictureAddress = Path.Combine(_env.WebRootPath, "Images", "ImageLarge", sectionPostImage.PictureAddress);
                    if (System.IO.File.Exists(pictureAddress))
                    {
                        System.IO.File.Delete(pictureAddress);
                    }
                }
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { @idTemp = sectionPostImage!.Id_SectionPostStep });
        }

        private bool SectionPostImageExists(int id)
        {
            return _context.SectionPostImages.Any(e => e.Id == id);
        }
    }
}
