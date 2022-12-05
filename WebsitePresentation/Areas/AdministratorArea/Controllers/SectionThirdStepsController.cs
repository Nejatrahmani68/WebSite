﻿using Microsoft.AspNetCore.Mvc;
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
    public class SectionThirdStepsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;
        public SectionThirdStepsController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: AdministratorArea/SectionThirdSteps
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
                var applicationDbContext = _context.SectionThirdSteps!.Where(m => m.Id_SectionSecondStep == idTemp).Include(s => s.SectionSecondStep);
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "SectionFirstSteps");

        }

        // GET: AdministratorArea/SectionThirdSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionThirdSteps == null)
            {
                return NotFound();
            }

            var sectionThirdStep = await _context.SectionThirdSteps
                .Include(s => s.SectionSecondStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionThirdStep == null)
            {
                return NotFound();
            }

            return View(sectionThirdStep);
        }

        // GET: AdministratorArea/SectionThirdSteps/Create
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
                ViewData["Id_SectionSecondStep"] = new SelectList(_context.SectionSecondSteps!.Where(m => m.Id == idTemp), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }

        // POST: AdministratorArea/SectionThirdSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Id_SectionSecondStep,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionThirdStep sectionThirdStep)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                sectionThirdStep.Email = User.Identity!.Name;
                _context.Add(sectionThirdStep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { @idTemp = sectionThirdStep.Id_SectionSecondStep });
            }
            ViewData["Id_SectionSecondStep"] = new SelectList(_context.SectionSecondSteps, "Id", "Name", sectionThirdStep.Id_SectionSecondStep);
            ViewBag.idTemp = sectionThirdStep.Id_SectionSecondStep;
            return View(sectionThirdStep);
        }

        // GET: AdministratorArea/SectionThirdSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionThirdSteps == null)
            {
                return NotFound();
            }

            var sectionThirdStep = await _context.SectionThirdSteps.FindAsync(id);
            if (sectionThirdStep == null)
            {
                return NotFound();
            }
            ViewData["Id_SectionSecondStep"] = new SelectList(_context.SectionSecondSteps!.Where(m => m.Id == sectionThirdStep.Id_SectionSecondStep), "Id", "Name", sectionThirdStep.Id_SectionSecondStep);
            return View(sectionThirdStep);
        }

        // POST: AdministratorArea/SectionThirdSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Id_SectionSecondStep,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] SectionThirdStep sectionThirdStep)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != sectionThirdStep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionThirdStep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionThirdStepExists(sectionThirdStep.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { @idTemp = sectionThirdStep.Id_SectionSecondStep });
            }
            ViewData["Id_SectionSecondStep"] = new SelectList(_context.SectionSecondSteps, "Id", "Name", sectionThirdStep.Id_SectionSecondStep);
            return View(sectionThirdStep);
        }

        // GET: AdministratorArea/SectionThirdSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.SectionThirdSteps == null)
            {
                return NotFound();
            }

            var sectionThirdStep = await _context.SectionThirdSteps
                .Include(s => s.SectionSecondStep)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionThirdStep == null)
            {
                return NotFound();
            }

            return View(sectionThirdStep);
        }

        // POST: AdministratorArea/SectionThirdSteps/Delete/5
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
            if (_context.SectionThirdSteps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionThirdSteps'  is null.");
            }
            var sectionThirdStep = await _context.SectionThirdSteps.FindAsync(id);
            if (sectionThirdStep != null)
            {
                _context.SectionThirdSteps.Remove(sectionThirdStep);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { @idTemp = sectionThirdStep!.Id_SectionSecondStep });
        }

        private bool SectionThirdStepExists(int id)
        {
            return _context.SectionThirdSteps!.Any(e => e.Id == id);
        }
    }
}
