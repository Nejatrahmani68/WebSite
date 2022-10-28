using DataAccess.Data;
using Model;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Builders
{
    public class BuilderFillData
    {
        private readonly ApplicationDbContext _db;
        private readonly ViewModelHomePage _viewModelHomePage;

        public BuilderFillData(ApplicationDbContext db, ViewModelHomePage viewModelHomePage)
        {
            _db = db;
            _viewModelHomePage = viewModelHomePage;
        }
        public IEnumerable<SectionFirstStep>? FillFirstStepSectionData()
        {
            IEnumerable<SectionFirstStep> fillFirstStepSectionData = _db.SectionFirstSteps.Where(m=>m.Active==true && (m.Timable==false ||(m.StartDate<=System.DateTime.Now && System.DateTime.Now<=m.EndDate)));
            return fillFirstStepSectionData;
        }
        public IEnumerable<SectionSecondStep>? FillSecondStepSectionData()
        {
            IEnumerable<SectionSecondStep> fillSecondStepSectionData = _db.SectionSecondSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillSecondStepSectionData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionData()
        {
            IEnumerable<SectionPostStep> fillPostStepSectionData = _db.SectionPostSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillPostStepSectionData;
        }
        public IEnumerable<SectionPostImage>? FillSectionPostImageData()
        {
            IEnumerable<SectionPostImage> fillSectionPostImageData = _db.SectionPostImages.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillSectionPostImageData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop10Data()
        {
            IEnumerable<SectionPostStep> fillPostStepSectionData = _db.SectionPostSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m=>m.CreateDate).Take(10);
            return fillPostStepSectionData;
        }
    }
}
