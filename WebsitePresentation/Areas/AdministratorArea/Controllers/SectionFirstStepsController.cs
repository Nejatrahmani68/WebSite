﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Services;
using System.Globalization;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Admin,Administrator")]
    public class SectionFirstStepsController : Controller
    {
        private readonly ServiceSectionFirstStep _context;
        private readonly ServiceAdminControl _serviceAdminControl;

        public SectionFirstStepsController(ServiceAdminControl serviceAdminControl, ServiceSectionFirstStep context)
        {
            _serviceAdminControl = serviceAdminControl;
            _context = context;
        }

        // GET: AdministratorArea/SectionFirstSteps
        public async Task<IActionResult> Index()
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return View(await _context.GetAllAsync());
        }

        // GET: AdministratorArea/SectionFirstSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || await _context.GetAllAsync() == null)
            {
                return NotFound();
            }

            var sectionFirstStep = await _context.GetByIdAsync(id);
            if (sectionFirstStep == null)
            {
                return NotFound();
            }

            return View(sectionFirstStep);
        }

        // GET: AdministratorArea/SectionFirstSteps/Create
        public IActionResult Create()
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return View();
        }

        // POST: AdministratorArea/SectionFirstSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Id,Active,Timable,StartDate,EndDate,TagsName")] SectionFirstStep sectionFirstStep)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                sectionFirstStep.Id_LanguageStep = _context.LanguageId();
                sectionFirstStep.Email = User.Identity!.Name;
                await _context.AddAsync(sectionFirstStep);
                return RedirectToAction(nameof(Index));
            }
            return View(sectionFirstStep);
        }

        // GET: AdministratorArea/SectionFirstSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || await _context.GetAllAsync() == null)
            {
                return NotFound();
            }
            var sectionFirstStep = await _context.GetByIdAsync(id);
            if (sectionFirstStep == null)
            {
                return NotFound();
            }
            return View(sectionFirstStep);
        }

        // POST: AdministratorArea/SectionFirstSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName,Id_LanguageStep")] SectionFirstStep sectionFirstStep)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != sectionFirstStep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.UpdateAsync(sectionFirstStep);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionFirstStepExists(sectionFirstStep.Id))
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
            return View(sectionFirstStep);
        }

        // GET: AdministratorArea/SectionFirstSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null ||await _context.GetAllAsync() == null)
            {
                return NotFound();
            }

            var sectionFirstStep = await _context.GetByIdAsync(id);
            if (sectionFirstStep == null)
            {
                return NotFound();
            }

            return View(sectionFirstStep);
        }

        // POST: AdministratorArea/SectionFirstSteps/Delete/5
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
            if (await _context.GetAllAsync() == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SectionFirstSteps'  is null.");
            }
            var sectionFirstStep = await _context.GetByIdAsync(id);
            if (sectionFirstStep != null)
            {
                await _context.RemoveAsync(sectionFirstStep);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool SectionFirstStepExists(int id)
        {
            return _context.SectionFirstStepExistsAsync(id);
        }
       
    }
}
